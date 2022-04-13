using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK_47_Panel_Scan
{
    public partial class panelScanForm : Form
    {
        public panelScanForm()
        {
            InitializeComponent();
        }

        private void btnVictimAdd_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress add = IPAddress.Parse(txtVictim.Text);
                listVictims.Items.Add("https://" + txtVictim.Text);
            }
            catch (Exception)
            {
                if (!checkIP.Checked)
                    listVictims.Items.Add(UrlControl(txtVictim.Text));
                else
                    foreach (IPAddress ipAddress in Dns.GetHostAddresses(hostControl(txtVictim.Text)))
                        listVictims.Items.Add("https://" + ipAddress.ToString());
            }
            txtVictim.Text = "";
        }
        private void btnSelectedVictimRemove_Click(object sender, EventArgs e)
        {
            if (listVictims.SelectedIndex != -1)
                listVictims.Items.RemoveAt(listVictims.SelectedIndex);
        }
        private void btnVictimExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listVictims.Items)
                    sw.WriteLine(item);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        private void btnVictimInport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "")
                    { line = sr.ReadLine(); continue; }
                    listVictims.Items.Add(UrlControl(line));
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }
        private void btnDorkAdd_Click(object sender, EventArgs e)
        {
            if (txtDork.Text != "")
                if (txtDork.Text[0] != '/')
                    listDorks.Items.Add('/' + txtDork.Text);
                else
                    listDorks.Items.Add(txtDork.Text);
            txtDork.Text = "";
        }
        private void btnSelectedDorkRemove_Click(object sender, EventArgs e)
        {
            if (listDorks.SelectedIndex != -1)
                listDorks.Items.RemoveAt(listDorks.SelectedIndex);
        }
        private void btnDorkExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var item in listDorks.Items)
                    sw.WriteLine(item);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }
        private void btnDorkInport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "")
                    { line = sr.ReadLine(); continue; }
                    if (line[0] != '/')
                        listDorks.Items.Add('/' + line);
                    else
                        listDorks.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }

        private string UrlControl(string Ur)
        {
            string returnedString = Ur;

            if (!Ur.StartsWith("https://") && !Ur.StartsWith("http://"))
                if (!Ur.StartsWith("www."))
                    returnedString = "https://www." + Ur;
                else
                    returnedString = "https://" + Ur;

            if (Ur[Ur.Length - 1] == '/')
                returnedString = returnedString.Substring(0, returnedString.Length - 1);

            return returnedString;
        }
        private string hostControl(string Ur)
        {
            string returnedString = Ur;
            if (Ur.StartsWith("https://") || Ur.StartsWith("http://"))
            {
                int i = 0;
                foreach (char item in Ur)
                {
                    if (item == 'w')
                        break;
                    i++;
                }
                returnedString = Ur.Substring(i, Ur.Length - i);
            }
            return returnedString;
        }
        Thread th;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (listDorks.Items.Count == 0)
            {
                MessageBox.Show("Aranacak objeler eklenmemiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listVictims.Items.Count == 0)
            {
                MessageBox.Show("Hedefler eklenmemiş !", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnStartStop.Text == "Başlat")
            {
                progressBar1.Maximum = listVictims.Items.Count * listDorks.Items.Count;
                progressBar1.Minimum = 0;
                progressBar1.Value = 0;
                dataGridView1.Rows.Clear();

                th = new Thread(start);
                th.Start();
                btnStartStop.Text = "Durdur";

            }
            else {
                th.Abort();
                btnStartStop.Text = "Başlat";
            }
        }

        private void start()
        {
            foreach (var victim in listVictims.Items)
            {
                foreach (var dork in listDorks.Items)
                {
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(victim.ToString() + dork.ToString());
                    try
                    {
                        HttpWebResponse cevap = (HttpWebResponse)request.GetResponse();
                        if (cevap.StatusCode.ToString() == "OK")
                        {
                            dataGridView1.Rows.Add(new string[] { victim.ToString(), dork.ToString(), "Var" });
                        }
                    }
                    catch (Exception)
                    {

                    }
                    progressBar1.Value += 1;
                }
            }
            MessageBox.Show("Bitti.","Hellö *_*",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void panelScanForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
