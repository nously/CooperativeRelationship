namespace CooperativeRelationship
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.highlight_luarNegeri = new System.Windows.Forms.Panel();
            this.highlight_dalamNegeri = new System.Windows.Forms.Panel();
            this.luarNegeri_Button = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dalamNegeri_Button = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rootDirP = new System.Windows.Forms.Label();
            this.judulTahun = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahunBaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.folderUtamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanTeknisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rootFolder_Dialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.luarNegeri_Button.SuspendLayout();
            this.dalamNegeri_Button.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 470);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highlight_luarNegeri);
            this.groupBox1.Controls.Add(this.highlight_dalamNegeri);
            this.groupBox1.Controls.Add(this.luarNegeri_Button);
            this.groupBox1.Controls.Add(this.dalamNegeri_Button);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Perjanjian";
            // 
            // highlight_luarNegeri
            // 
            this.highlight_luarNegeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.highlight_luarNegeri.Location = new System.Drawing.Point(5, 80);
            this.highlight_luarNegeri.Name = "highlight_luarNegeri";
            this.highlight_luarNegeri.Size = new System.Drawing.Size(10, 44);
            this.highlight_luarNegeri.TabIndex = 2;
            this.highlight_luarNegeri.Visible = false;
            // 
            // highlight_dalamNegeri
            // 
            this.highlight_dalamNegeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.highlight_dalamNegeri.Location = new System.Drawing.Point(5, 23);
            this.highlight_dalamNegeri.Name = "highlight_dalamNegeri";
            this.highlight_dalamNegeri.Size = new System.Drawing.Size(10, 45);
            this.highlight_dalamNegeri.TabIndex = 1;
            // 
            // luarNegeri_Button
            // 
            this.luarNegeri_Button.Controls.Add(this.label2);
            this.luarNegeri_Button.Location = new System.Drawing.Point(21, 80);
            this.luarNegeri_Button.Name = "luarNegeri_Button";
            this.luarNegeri_Button.Size = new System.Drawing.Size(168, 44);
            this.luarNegeri_Button.TabIndex = 1;
            this.luarNegeri_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luarNegeri_Button_MouseClick);
            this.luarNegeri_Button.MouseEnter += new System.EventHandler(this.luarNegeri_Button_MouseEnter);
            this.luarNegeri_Button.MouseLeave += new System.EventHandler(this.luarNegeri_Button_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Luar Negeri";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luarNegeri_Button_MouseClick);
            this.label2.MouseEnter += new System.EventHandler(this.luarNegeri_Button_MouseEnter);
            // 
            // dalamNegeri_Button
            // 
            this.dalamNegeri_Button.Controls.Add(this.label1);
            this.dalamNegeri_Button.Location = new System.Drawing.Point(21, 23);
            this.dalamNegeri_Button.Name = "dalamNegeri_Button";
            this.dalamNegeri_Button.Size = new System.Drawing.Size(168, 45);
            this.dalamNegeri_Button.TabIndex = 0;
            this.dalamNegeri_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dalamNegeri_Button_MouseClick);
            this.dalamNegeri_Button.MouseEnter += new System.EventHandler(this.dalamNegeri_Button_MouseEnter);
            this.dalamNegeri_Button.MouseLeave += new System.EventHandler(this.dalamNegeri_Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dalam Negeri";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dalamNegeri_Button_MouseClick);
            this.label1.MouseEnter += new System.EventHandler(this.dalamNegeri_Button_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.rootDirP);
            this.panel2.Controls.Add(this.judulTahun);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(195, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 469);
            this.panel2.TabIndex = 1;
            // 
            // rootDirP
            // 
            this.rootDirP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rootDirP.AutoSize = true;
            this.rootDirP.ForeColor = System.Drawing.Color.White;
            this.rootDirP.Location = new System.Drawing.Point(7, 450);
            this.rootDirP.Name = "rootDirP";
            this.rootDirP.Size = new System.Drawing.Size(35, 13);
            this.rootDirP.TabIndex = 2;
            this.rootDirP.Text = "label3";
            // 
            // judulTahun
            // 
            this.judulTahun.AutoSize = true;
            this.judulTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulTahun.ForeColor = System.Drawing.Color.White;
            this.judulTahun.Location = new System.Drawing.Point(15, 13);
            this.judulTahun.Name = "judulTahun";
            this.judulTahun.Size = new System.Drawing.Size(199, 20);
            this.judulTahun.TabIndex = 1;
            this.judulTahun.Text = "Daftar Tahun Perjanjian";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 405);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tahunBaruToolStripMenuItem,
            this.toolStripSeparator1,
            this.folderUtamaToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tahunBaruToolStripMenuItem
            // 
            this.tahunBaruToolStripMenuItem.Name = "tahunBaruToolStripMenuItem";
            this.tahunBaruToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tahunBaruToolStripMenuItem.Text = "Tambah Tahun";
            this.tahunBaruToolStripMenuItem.Click += new System.EventHandler(this.tahunBaruToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // folderUtamaToolStripMenuItem
            // 
            this.folderUtamaToolStripMenuItem.Name = "folderUtamaToolStripMenuItem";
            this.folderUtamaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.folderUtamaToolStripMenuItem.Text = "Ganti Folder Utama";
            this.folderUtamaToolStripMenuItem.Click += new System.EventHandler(this.folderUtamaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Keluar";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bantuanTeknisToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // bantuanTeknisToolStripMenuItem
            // 
            this.bantuanTeknisToolStripMenuItem.Name = "bantuanTeknisToolStripMenuItem";
            this.bantuanTeknisToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bantuanTeknisToolStripMenuItem.Text = "Bantuan Teknis";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem1.Text = "Tentang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(896, 532);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manajemen Kerjasama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.luarNegeri_Button.ResumeLayout(false);
            this.luarNegeri_Button.PerformLayout();
            this.dalamNegeri_Button.ResumeLayout(false);
            this.dalamNegeri_Button.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dalamNegeri_Button;
        private System.Windows.Forms.Panel luarNegeri_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel highlight_dalamNegeri;
        private System.Windows.Forms.Panel highlight_luarNegeri;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label judulTahun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahunBaruToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanTeknisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem folderUtamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.FolderBrowserDialog rootFolder_Dialog1;
        private System.Windows.Forms.Label rootDirP;
    }
}

