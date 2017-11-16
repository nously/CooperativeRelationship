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
            this.institusi = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tempatTanggalTTD = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nomorPerjanjian = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.masaBerlaku = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.fokusPerjanjian = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.penandatangan = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitPengguna = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.narahubung = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.unitPengusul = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.panel1.Location = new System.Drawing.Point(12, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 52);
            this.panel1.TabIndex = 1;
            // 
            // tambahKerjasama_button
            // 
            this.tambahKerjasama_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tambahKerjasama_button.Location = new System.Drawing.Point(1226, 9);
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
            this.panel2.Size = new System.Drawing.Size(1345, 37);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1246, 7);
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
            this.textBox1.Size = new System.Drawing.Size(1143, 20);
            this.textBox1.TabIndex = 0;
            // 
            // documents
            // 
            this.documents.AllColumns.Add(this.institusi);
            this.documents.AllColumns.Add(this.tempatTanggalTTD);
            this.documents.AllColumns.Add(this.nomorPerjanjian);
            this.documents.AllColumns.Add(this.masaBerlaku);
            this.documents.AllColumns.Add(this.fokusPerjanjian);
            this.documents.AllColumns.Add(this.penandatangan);
            this.documents.AllColumns.Add(this.unitPengguna);
            this.documents.AllColumns.Add(this.narahubung);
            this.documents.AllColumns.Add(this.unitPengusul);
            this.documents.AllColumns.Add(this.nilaiKerjasama);
            this.documents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documents.CellEditUseWholeCell = false;
            this.documents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.institusi,
            this.tempatTanggalTTD,
            this.nomorPerjanjian,
            this.masaBerlaku,
            this.fokusPerjanjian,
            this.penandatangan,
            this.unitPengguna,
            this.narahubung,
            this.unitPengusul,
            this.nilaiKerjasama});
            this.documents.Cursor = System.Windows.Forms.Cursors.Default;
            this.documents.Location = new System.Drawing.Point(12, 56);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(1346, 476);
            this.documents.TabIndex = 3;
            this.documents.UseCompatibleStateImageBehavior = false;
            this.documents.View = System.Windows.Forms.View.Details;
            // 
            // institusi
            // 
            this.institusi.AspectName = "Institusi";
            this.institusi.Sortable = false;
            this.institusi.Text = "Institusi";
            this.institusi.UseFiltering = false;
            this.institusi.Width = 175;
            this.institusi.WordWrap = true;
            // 
            // tempatTanggalTTD
            // 
            this.tempatTanggalTTD.AspectName = "TempatTanggalTTD";
            this.tempatTanggalTTD.DisplayIndex = 2;
            this.tempatTanggalTTD.Sortable = false;
            this.tempatTanggalTTD.Text = "Tempat Tanggal TTD";
            this.tempatTanggalTTD.Width = 146;
            // 
            // nomorPerjanjian
            // 
            this.nomorPerjanjian.AspectName = "NomorPerjanjian";
            this.nomorPerjanjian.DisplayIndex = 1;
            this.nomorPerjanjian.IsButton = true;
            this.nomorPerjanjian.Sortable = false;
            this.nomorPerjanjian.Text = "Nomor Perjanjian";
            this.nomorPerjanjian.UseFiltering = false;
            this.nomorPerjanjian.Width = 110;
            // 
            // masaBerlaku
            // 
            this.masaBerlaku.AspectName = "MasaBerlaku";
            this.masaBerlaku.IsButton = true;
            this.masaBerlaku.Sortable = false;
            this.masaBerlaku.Text = "Masa Berlaku";
            this.masaBerlaku.Width = 110;
            // 
            // fokusPerjanjian
            // 
            this.fokusPerjanjian.AspectName = "FokusPerjanjian";
            this.fokusPerjanjian.IsButton = true;
            this.fokusPerjanjian.Sortable = false;
            this.fokusPerjanjian.Text = "Fokus Perjanjian";
            this.fokusPerjanjian.Width = 110;
            // 
            // penandatangan
            // 
            this.penandatangan.AspectName = "Penandatangan";
            this.penandatangan.IsButton = true;
            this.penandatangan.Sortable = false;
            this.penandatangan.Text = "Penandatangan";
            this.penandatangan.Width = 110;
            // 
            // unitPengguna
            // 
            this.unitPengguna.AspectName = "UnitPengguna";
            this.unitPengguna.DisplayIndex = 7;
            this.unitPengguna.IsButton = true;
            this.unitPengguna.Sortable = false;
            this.unitPengguna.Text = "Unit Pengguna";
            this.unitPengguna.Width = 110;
            // 
            // narahubung
            // 
            this.narahubung.AspectName = "Narahubung";
            this.narahubung.DisplayIndex = 8;
            this.narahubung.IsButton = true;
            this.narahubung.Sortable = false;
            this.narahubung.Text = "Narahubung";
            this.narahubung.Width = 110;
            // 
            // unitPengusul
            // 
            this.unitPengusul.AspectName = "UnitPengusul";
            this.unitPengusul.DisplayIndex = 6;
            this.unitPengusul.Sortable = false;
            this.unitPengusul.Text = "Unit Pengusul";
            this.unitPengusul.Width = 175;
            // 
            // nilaiKerjasama
            // 
            this.nilaiKerjasama.AspectName = "NilaiKerjasama";
            this.nilaiKerjasama.Text = "Nilai Kerjasama";
            this.nilaiKerjasama.Width = 93;
            // 
            // DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 602);
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
        private BrightIdeasSoftware.OLVColumn institusi;
        private BrightIdeasSoftware.OLVColumn nomorPerjanjian;
        private BrightIdeasSoftware.OLVColumn tempatTanggalTTD;
        private BrightIdeasSoftware.OLVColumn masaBerlaku;
        private BrightIdeasSoftware.OLVColumn fokusPerjanjian;
        private BrightIdeasSoftware.OLVColumn penandatangan;
        private BrightIdeasSoftware.OLVColumn unitPengusul;
        private BrightIdeasSoftware.OLVColumn unitPengguna;
        private BrightIdeasSoftware.OLVColumn narahubung;
        private BrightIdeasSoftware.OLVColumn nilaiKerjasama;
    }
}