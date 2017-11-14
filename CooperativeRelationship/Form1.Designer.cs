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
            this.judulTahun = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tahun_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.luarNegeri_Button.SuspendLayout();
            this.dalamNegeri_Button.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tahun_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 493);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highlight_luarNegeri);
            this.groupBox1.Controls.Add(this.highlight_dalamNegeri);
            this.groupBox1.Controls.Add(this.luarNegeri_Button);
            this.groupBox1.Controls.Add(this.dalamNegeri_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Kerjasama";
            // 
            // highlight_luarNegeri
            // 
            this.highlight_luarNegeri.BackColor = System.Drawing.Color.Red;
            this.highlight_luarNegeri.Location = new System.Drawing.Point(5, 59);
            this.highlight_luarNegeri.Name = "highlight_luarNegeri";
            this.highlight_luarNegeri.Size = new System.Drawing.Size(10, 33);
            this.highlight_luarNegeri.TabIndex = 2;
            this.highlight_luarNegeri.Visible = false;
            // 
            // highlight_dalamNegeri
            // 
            this.highlight_dalamNegeri.BackColor = System.Drawing.Color.Red;
            this.highlight_dalamNegeri.Location = new System.Drawing.Point(5, 23);
            this.highlight_dalamNegeri.Name = "highlight_dalamNegeri";
            this.highlight_dalamNegeri.Size = new System.Drawing.Size(10, 33);
            this.highlight_dalamNegeri.TabIndex = 1;
            // 
            // luarNegeri_Button
            // 
            this.luarNegeri_Button.Controls.Add(this.label2);
            this.luarNegeri_Button.Location = new System.Drawing.Point(21, 59);
            this.luarNegeri_Button.Name = "luarNegeri_Button";
            this.luarNegeri_Button.Size = new System.Drawing.Size(150, 33);
            this.luarNegeri_Button.TabIndex = 1;
            this.luarNegeri_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luarNegeri_Button_MouseClick);
            this.luarNegeri_Button.MouseEnter += new System.EventHandler(this.luarNegeri_Button_MouseEnter);
            this.luarNegeri_Button.MouseLeave += new System.EventHandler(this.luarNegeri_Button_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 10);
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
            this.dalamNegeri_Button.Size = new System.Drawing.Size(150, 33);
            this.dalamNegeri_Button.TabIndex = 0;
            this.dalamNegeri_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dalamNegeri_Button_MouseClick);
            this.dalamNegeri_Button.MouseEnter += new System.EventHandler(this.dalamNegeri_Button_MouseEnter);
            this.dalamNegeri_Button.MouseLeave += new System.EventHandler(this.dalamNegeri_Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 10);
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
            this.panel2.Controls.Add(this.judulTahun);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 493);
            this.panel2.TabIndex = 1;
            // 
            // judulTahun
            // 
            this.judulTahun.AutoSize = true;
            this.judulTahun.Location = new System.Drawing.Point(17, 26);
            this.judulTahun.Name = "judulTahun";
            this.judulTahun.Size = new System.Drawing.Size(122, 13);
            this.judulTahun.TabIndex = 1;
            this.judulTahun.Text = "Daftar Tahun Kerjasama";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.tahun_panel);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 423);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tahun_panel
            // 
            this.tahun_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tahun_panel.Controls.Add(this.label3);
            this.tahun_panel.Location = new System.Drawing.Point(1, 1);
            this.tahun_panel.Margin = new System.Windows.Forms.Padding(1);
            this.tahun_panel.Name = "tahun_panel";
            this.tahun_panel.Size = new System.Drawing.Size(663, 21);
            this.tahun_panel.TabIndex = 0;
            this.tahun_panel.Click += new System.EventHandler(this.tahun_panel_Click);
            this.tahun_panel.MouseEnter += new System.EventHandler(this.tahun_panel_MouseEnter);
            this.tahun_panel.MouseLeave += new System.EventHandler(this.tahun_panel_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dimulai Tahun 2017";
            this.label3.Click += new System.EventHandler(this.tahun_panel_Click);
            this.label3.MouseEnter += new System.EventHandler(this.tahun_panel_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dimulai Tahun 2017";
            this.label4.Click += new System.EventHandler(this.tahun_panel_Click);
            this.label4.MouseEnter += new System.EventHandler(this.tahun_panel_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(1, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 21);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.tahun_panel_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.tahun_panel_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.tahun_panel_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Manajemen Kerjasama";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.luarNegeri_Button.ResumeLayout(false);
            this.luarNegeri_Button.PerformLayout();
            this.dalamNegeri_Button.ResumeLayout(false);
            this.dalamNegeri_Button.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tahun_panel.ResumeLayout(false);
            this.tahun_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel tahun_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}

