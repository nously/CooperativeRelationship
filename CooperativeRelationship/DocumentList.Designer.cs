namespace CooperativeRelationship
{
    partial class DocumentList
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
            this.tambahKerjasama_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.documents = new BrightIdeasSoftware.ObjectListView();
            this.nomorPerjanjian = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.waktuTempatTTD = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.masaBerlaku = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fokusPerjanjian = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.penandatangan = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitPengusul = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitPengguna = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.narahubungFisip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.narahubungInstitusi = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nilaiKerjasama = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tambahKerjasama_button);
            this.panel1.Location = new System.Drawing.Point(12, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 52);
            this.panel1.TabIndex = 1;
            // 
            // tambahKerjasama_button
            // 
            this.tambahKerjasama_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tambahKerjasama_button.Location = new System.Drawing.Point(801, 9);
            this.tambahKerjasama_button.Name = "tambahKerjasama_button";
            this.tambahKerjasama_button.Size = new System.Drawing.Size(117, 35);
            this.tambahKerjasama_button.TabIndex = 0;
            this.tambahKerjasama_button.Text = "Tambah Kerjasama";
            this.tambahKerjasama_button.UseVisualStyleBackColor = true;
            this.tambahKerjasama_button.Click += new System.EventHandler(this.tambahKerjasama_button_Click);
            this.tambahKerjasama_button.MouseEnter += new System.EventHandler(this.tambahKerjasama_button_MouseEnter);
            this.tambahKerjasama_button.MouseLeave += new System.EventHandler(this.tambahKerjasama_button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 37);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(821, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Kerjasama";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(97, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 20);
            this.textBox1.TabIndex = 0;
            // 
            // documents
            // 
            this.documents.AllColumns.Add(this.nomorPerjanjian);
            this.documents.AllColumns.Add(this.waktuTempatTTD);
            this.documents.AllColumns.Add(this.masaBerlaku);
            this.documents.AllColumns.Add(this.fokusPerjanjian);
            this.documents.AllColumns.Add(this.penandatangan);
            this.documents.AllColumns.Add(this.unitPengusul);
            this.documents.AllColumns.Add(this.unitPengguna);
            this.documents.AllColumns.Add(this.narahubungFisip);
            this.documents.AllColumns.Add(this.narahubungInstitusi);
            this.documents.AllColumns.Add(this.nilaiKerjasama);
            this.documents.CellEditUseWholeCell = false;
            this.documents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomorPerjanjian,
            this.waktuTempatTTD,
            this.masaBerlaku,
            this.fokusPerjanjian,
            this.penandatangan,
            this.unitPengusul,
            this.unitPengguna,
            this.narahubungFisip,
            this.narahubungInstitusi,
            this.nilaiKerjasama});
            this.documents.Cursor = System.Windows.Forms.Cursors.Default;
            this.documents.Location = new System.Drawing.Point(12, 56);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(921, 388);
            this.documents.TabIndex = 3;
            this.documents.UseCompatibleStateImageBehavior = false;
            this.documents.View = System.Windows.Forms.View.Details;
            // 
            // nomorPerjanjian
            // 
            this.nomorPerjanjian.Text = "Nomor Perjanjian";
            this.nomorPerjanjian.Width = 102;
            // 
            // waktuTempatTTD
            // 
            this.waktuTempatTTD.Text = "Waktu dan Tempat Penandatanganan";
            this.waktuTempatTTD.Width = 198;
            // 
            // masaBerlaku
            // 
            this.masaBerlaku.Text = "Masa Berlaku";
            this.masaBerlaku.Width = 81;
            // 
            // fokusPerjanjian
            // 
            this.fokusPerjanjian.Text = "Fokus Perjanjian";
            // 
            // penandatangan
            // 
            this.penandatangan.Text = "Penandatangan";
            // 
            // unitPengusul
            // 
            this.unitPengusul.Text = "Unit Pengusul";
            // 
            // unitPengguna
            // 
            this.unitPengguna.Text = "Unit Pengguna";
            // 
            // narahubungFisip
            // 
            this.narahubungFisip.Text = "Narahubung FISIP";
            // 
            // narahubungInstitusi
            // 
            this.narahubungInstitusi.Text = "Narahubung Institusi";
            // 
            // nilaiKerjasama
            // 
            this.nilaiKerjasama.Text = "Nilai Kerjasama";
            // 
            // DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 514);
            this.Controls.Add(this.documents);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DocumentList";
            this.Text = "DocumentList";
            this.Load += new System.EventHandler(this.DocumentList_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tambahKerjasama_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.ObjectListView documents;
        private BrightIdeasSoftware.OLVColumn nomorPerjanjian;
        private BrightIdeasSoftware.OLVColumn waktuTempatTTD;
        private BrightIdeasSoftware.OLVColumn masaBerlaku;
        private BrightIdeasSoftware.OLVColumn fokusPerjanjian;
        private BrightIdeasSoftware.OLVColumn penandatangan;
        private BrightIdeasSoftware.OLVColumn unitPengusul;
        private BrightIdeasSoftware.OLVColumn unitPengguna;
        private BrightIdeasSoftware.OLVColumn narahubungFisip;
        private BrightIdeasSoftware.OLVColumn narahubungInstitusi;
        private BrightIdeasSoftware.OLVColumn nilaiKerjasama;
    }
}