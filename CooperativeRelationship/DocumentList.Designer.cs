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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tambahKerjasama_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
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
            this.bukaDokumen = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.edit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hapus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tambahKerjasama_button);
            this.panel1.Location = new System.Drawing.Point(12, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 52);
            this.panel1.TabIndex = 1;
            // 
            // tambahKerjasama_button
            // 
            this.tambahKerjasama_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tambahKerjasama_button.Location = new System.Drawing.Point(746, 9);
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
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.search_textBox);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 37);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(766, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // search_textBox
            // 
            this.search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textBox.Location = new System.Drawing.Point(97, 9);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(663, 20);
            this.search_textBox.TabIndex = 0;
            this.search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textBox_KeyDown);
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
            this.documents.AllColumns.Add(this.bukaDokumen);
            this.documents.AllColumns.Add(this.edit);
            this.documents.AllColumns.Add(this.hapus);
            this.documents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
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
            this.nilaiKerjasama,
            this.bukaDokumen,
            this.edit,
            this.hapus});
            this.documents.Cursor = System.Windows.Forms.Cursors.Default;
            this.documents.Location = new System.Drawing.Point(12, 56);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(866, 476);
            this.documents.TabIndex = 3;
            this.documents.UseCompatibleStateImageBehavior = false;
            this.documents.View = System.Windows.Forms.View.Details;
            // 
            // institusi
            // 
            this.institusi.AspectName = "Institusi";
            this.institusi.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institusi.HeaderImageKey = "";
            this.institusi.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.institusi.Sortable = false;
            this.institusi.Text = "Institusi";
            this.institusi.UseInitialLetterForGroup = true;
            this.institusi.Width = 170;
            this.institusi.WordWrap = true;
            // 
            // tempatTanggalTTD
            // 
            this.tempatTanggalTTD.AspectName = "TempatTanggalTTD";
            this.tempatTanggalTTD.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempatTanggalTTD.Sortable = false;
            this.tempatTanggalTTD.Text = "Tempat Tanggal TTD";
            this.tempatTanggalTTD.Width = 146;
            // 
            // nomorPerjanjian
            // 
            this.nomorPerjanjian.AspectName = "NomorPerjanjian";
            this.nomorPerjanjian.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomorPerjanjian.IsButton = true;
            this.nomorPerjanjian.Sortable = false;
            this.nomorPerjanjian.Text = "Nomor Perjanjian";
            this.nomorPerjanjian.UseFiltering = false;
            this.nomorPerjanjian.Width = 100;
            // 
            // masaBerlaku
            // 
            this.masaBerlaku.AspectName = "MasaBerlaku";
            this.masaBerlaku.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaBerlaku.IsButton = true;
            this.masaBerlaku.Sortable = false;
            this.masaBerlaku.Text = "Masa Berlaku";
            this.masaBerlaku.Width = 100;
            // 
            // fokusPerjanjian
            // 
            this.fokusPerjanjian.AspectName = "FokusPerjanjian";
            this.fokusPerjanjian.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fokusPerjanjian.IsButton = true;
            this.fokusPerjanjian.Sortable = false;
            this.fokusPerjanjian.Text = "Fokus Perjanjian";
            this.fokusPerjanjian.Width = 100;
            // 
            // penandatangan
            // 
            this.penandatangan.AspectName = "Penandatangan";
            this.penandatangan.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penandatangan.IsButton = true;
            this.penandatangan.Sortable = false;
            this.penandatangan.Text = "Penandatangan";
            this.penandatangan.Width = 100;
            // 
            // unitPengguna
            // 
            this.unitPengguna.AspectName = "UnitPengguna";
            this.unitPengguna.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPengguna.IsButton = true;
            this.unitPengguna.Sortable = false;
            this.unitPengguna.Text = "Unit Pengguna";
            this.unitPengguna.Width = 100;
            // 
            // narahubung
            // 
            this.narahubung.AspectName = "Narahubung";
            this.narahubung.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narahubung.IsButton = true;
            this.narahubung.Sortable = false;
            this.narahubung.Text = "Narahubung";
            this.narahubung.Width = 100;
            // 
            // unitPengusul
            // 
            this.unitPengusul.AspectName = "UnitPengusul";
            this.unitPengusul.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPengusul.Sortable = false;
            this.unitPengusul.Text = "Unit Pengusul";
            this.unitPengusul.Width = 115;
            // 
            // nilaiKerjasama
            // 
            this.nilaiKerjasama.AspectName = "NilaiKerjasama";
            this.nilaiKerjasama.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaiKerjasama.Sortable = false;
            this.nilaiKerjasama.Text = "Nilai Kerjasama";
            this.nilaiKerjasama.UseFiltering = false;
            this.nilaiKerjasama.Width = 93;
            // 
            // bukaDokumen
            // 
            this.bukaDokumen.AspectName = "BukaDokumen";
            this.bukaDokumen.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bukaDokumen.IsButton = true;
            this.bukaDokumen.Sortable = false;
            this.bukaDokumen.Text = "Buka Dokumen";
            this.bukaDokumen.UseFiltering = false;
            this.bukaDokumen.Width = 90;
            // 
            // edit
            // 
            this.edit.AspectName = "Edit";
            this.edit.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.IsButton = true;
            this.edit.Sortable = false;
            this.edit.Text = "Edit";
            this.edit.UseFiltering = false;
            // 
            // hapus
            // 
            this.hapus.AspectName = "Hapus";
            this.hapus.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.IsButton = true;
            this.hapus.Sortable = false;
            this.hapus.Text = "Hapus";
            this.hapus.UseFiltering = false;
            // 
            // DocumentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 602);
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
        private System.Windows.Forms.TextBox search_textBox;
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
        private BrightIdeasSoftware.OLVColumn edit;
        private BrightIdeasSoftware.OLVColumn hapus;
        private BrightIdeasSoftware.OLVColumn bukaDokumen;
    }
}