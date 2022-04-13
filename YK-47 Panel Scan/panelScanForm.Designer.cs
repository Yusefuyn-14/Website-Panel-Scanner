namespace YK_47_Panel_Scan
{
    partial class panelScanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVictim = new System.Windows.Forms.TextBox();
            this.btnVictimAdd = new System.Windows.Forms.Button();
            this.listVictims = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkIP = new System.Windows.Forms.CheckBox();
            this.btnSelectedVictimRemove = new System.Windows.Forms.Button();
            this.btnVictimInport = new System.Windows.Forms.Button();
            this.btnVictimExport = new System.Windows.Forms.Button();
            this.btnDorkExport = new System.Windows.Forms.Button();
            this.btnDorkInport = new System.Windows.Forms.Button();
            this.btnSelectedDorkRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listDorks = new System.Windows.Forms.ListBox();
            this.btnDorkAdd = new System.Windows.Forms.Button();
            this.txtDork = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResultExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hedef :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVictim
            // 
            this.txtVictim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVictim.Location = new System.Drawing.Point(118, 6);
            this.txtVictim.Name = "txtVictim";
            this.txtVictim.Size = new System.Drawing.Size(372, 20);
            this.txtVictim.TabIndex = 1;
            // 
            // btnVictimAdd
            // 
            this.btnVictimAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVictimAdd.Location = new System.Drawing.Point(496, 4);
            this.btnVictimAdd.Name = "btnVictimAdd";
            this.btnVictimAdd.Size = new System.Drawing.Size(84, 23);
            this.btnVictimAdd.TabIndex = 2;
            this.btnVictimAdd.Text = "Ekle";
            this.btnVictimAdd.UseVisualStyleBackColor = true;
            this.btnVictimAdd.Click += new System.EventHandler(this.btnVictimAdd_Click);
            // 
            // listVictims
            // 
            this.listVictims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVictims.FormattingEnabled = true;
            this.listVictims.Location = new System.Drawing.Point(118, 28);
            this.listVictims.Name = "listVictims";
            this.listVictims.Size = new System.Drawing.Size(372, 95);
            this.listVictims.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hedefler :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkIP
            // 
            this.checkIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIP.BackColor = System.Drawing.Color.White;
            this.checkIP.Location = new System.Drawing.Point(449, 8);
            this.checkIP.Name = "checkIP";
            this.checkIP.Size = new System.Drawing.Size(39, 16);
            this.checkIP.TabIndex = 5;
            this.checkIP.Text = "IP";
            this.checkIP.UseVisualStyleBackColor = false;
            // 
            // btnSelectedVictimRemove
            // 
            this.btnSelectedVictimRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedVictimRemove.Location = new System.Drawing.Point(496, 28);
            this.btnSelectedVictimRemove.Name = "btnSelectedVictimRemove";
            this.btnSelectedVictimRemove.Size = new System.Drawing.Size(84, 23);
            this.btnSelectedVictimRemove.TabIndex = 6;
            this.btnSelectedVictimRemove.Text = "Seçileni Kaldır";
            this.btnSelectedVictimRemove.UseVisualStyleBackColor = true;
            this.btnSelectedVictimRemove.Click += new System.EventHandler(this.btnSelectedVictimRemove_Click);
            // 
            // btnVictimInport
            // 
            this.btnVictimInport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVictimInport.Location = new System.Drawing.Point(496, 100);
            this.btnVictimInport.Name = "btnVictimInport";
            this.btnVictimInport.Size = new System.Drawing.Size(84, 23);
            this.btnVictimInport.TabIndex = 7;
            this.btnVictimInport.Text = "İçe Aktar";
            this.btnVictimInport.UseVisualStyleBackColor = true;
            this.btnVictimInport.Click += new System.EventHandler(this.btnVictimInport_Click);
            // 
            // btnVictimExport
            // 
            this.btnVictimExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVictimExport.Location = new System.Drawing.Point(496, 76);
            this.btnVictimExport.Name = "btnVictimExport";
            this.btnVictimExport.Size = new System.Drawing.Size(84, 23);
            this.btnVictimExport.TabIndex = 8;
            this.btnVictimExport.Text = "Dışa Aktar";
            this.btnVictimExport.UseVisualStyleBackColor = true;
            this.btnVictimExport.Click += new System.EventHandler(this.btnVictimExport_Click);
            // 
            // btnDorkExport
            // 
            this.btnDorkExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDorkExport.Location = new System.Drawing.Point(496, 196);
            this.btnDorkExport.Name = "btnDorkExport";
            this.btnDorkExport.Size = new System.Drawing.Size(84, 23);
            this.btnDorkExport.TabIndex = 17;
            this.btnDorkExport.Text = "Dışa Aktar";
            this.btnDorkExport.UseVisualStyleBackColor = true;
            this.btnDorkExport.Click += new System.EventHandler(this.btnDorkExport_Click);
            // 
            // btnDorkInport
            // 
            this.btnDorkInport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDorkInport.Location = new System.Drawing.Point(496, 220);
            this.btnDorkInport.Name = "btnDorkInport";
            this.btnDorkInport.Size = new System.Drawing.Size(84, 23);
            this.btnDorkInport.TabIndex = 16;
            this.btnDorkInport.Text = "İçe Aktar";
            this.btnDorkInport.UseVisualStyleBackColor = true;
            this.btnDorkInport.Click += new System.EventHandler(this.btnDorkInport_Click);
            // 
            // btnSelectedDorkRemove
            // 
            this.btnSelectedDorkRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedDorkRemove.Location = new System.Drawing.Point(496, 148);
            this.btnSelectedDorkRemove.Name = "btnSelectedDorkRemove";
            this.btnSelectedDorkRemove.Size = new System.Drawing.Size(84, 23);
            this.btnSelectedDorkRemove.TabIndex = 15;
            this.btnSelectedDorkRemove.Text = "Seçileni Kaldır";
            this.btnSelectedDorkRemove.UseVisualStyleBackColor = true;
            this.btnSelectedDorkRemove.Click += new System.EventHandler(this.btnSelectedDorkRemove_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Paneller :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listDorks
            // 
            this.listDorks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDorks.FormattingEnabled = true;
            this.listDorks.Location = new System.Drawing.Point(118, 148);
            this.listDorks.Name = "listDorks";
            this.listDorks.Size = new System.Drawing.Size(372, 95);
            this.listDorks.TabIndex = 12;
            // 
            // btnDorkAdd
            // 
            this.btnDorkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDorkAdd.Location = new System.Drawing.Point(496, 124);
            this.btnDorkAdd.Name = "btnDorkAdd";
            this.btnDorkAdd.Size = new System.Drawing.Size(84, 23);
            this.btnDorkAdd.TabIndex = 11;
            this.btnDorkAdd.Text = "Ekle";
            this.btnDorkAdd.UseVisualStyleBackColor = true;
            this.btnDorkAdd.Click += new System.EventHandler(this.btnDorkAdd_Click);
            // 
            // txtDork
            // 
            this.txtDork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDork.Location = new System.Drawing.Point(118, 126);
            this.txtDork.Name = "txtDork";
            this.txtDork.Size = new System.Drawing.Size(372, 20);
            this.txtDork.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Panel :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listDorks);
            this.panel1.Controls.Add(this.listVictims);
            this.panel1.Controls.Add(this.btnDorkExport);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDorkAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkIP);
            this.panel1.Controls.Add(this.btnVictimExport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDorkInport);
            this.panel1.Controls.Add(this.txtDork);
            this.panel1.Controls.Add(this.btnVictimInport);
            this.panel1.Controls.Add(this.btnVictimAdd);
            this.panel1.Controls.Add(this.txtVictim);
            this.panel1.Controls.Add(this.btnSelectedVictimRemove);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSelectedDorkRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 250);
            this.panel1.TabIndex = 18;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 250);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(592, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartStop.Location = new System.Drawing.Point(0, 273);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(592, 23);
            this.btnStartStop.TabIndex = 20;
            this.btnStartStop.Text = "Başlat";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnResultExport);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 206);
            this.panel2.TabIndex = 21;
            // 
            // btnResultExport
            // 
            this.btnResultExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResultExport.Location = new System.Drawing.Point(0, 183);
            this.btnResultExport.Name = "btnResultExport";
            this.btnResultExport.Size = new System.Drawing.Size(592, 23);
            this.btnResultExport.TabIndex = 21;
            this.btnResultExport.Text = "Dışarı Aktar";
            this.btnResultExport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Site";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dork";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Durum";
            this.Column3.Name = "Column3";
            // 
            // panelScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Name = "panelScanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Scanner";
            this.Load += new System.EventHandler(this.panelScanForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVictim;
        private System.Windows.Forms.Button btnVictimAdd;
        private System.Windows.Forms.ListBox listVictims;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkIP;
        private System.Windows.Forms.Button btnSelectedVictimRemove;
        private System.Windows.Forms.Button btnVictimInport;
        private System.Windows.Forms.Button btnVictimExport;
        private System.Windows.Forms.Button btnDorkExport;
        private System.Windows.Forms.Button btnDorkInport;
        private System.Windows.Forms.Button btnSelectedDorkRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listDorks;
        private System.Windows.Forms.Button btnDorkAdd;
        private System.Windows.Forms.TextBox txtDork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResultExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

