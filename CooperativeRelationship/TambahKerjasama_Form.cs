﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeRelationship
{
    public partial class TambahKerjasama_Form : Form
    {
        int y;
        public string fokusPerjanjianData = "";
        public string unitPenggunaData = "";
        public Dictionary<string, string> narahubungFisipData;
        public Dictionary<string, string> narahubungInstitusiData;
        private string databaseSource;
        private string id;
        private string filePath;
        private string docPath;
        private string tahun;
        private int activeMode;
        private DocumentList list;
        private string documentPathFile;

        public TambahKerjasama_Form()
        {
            InitializeComponent();
            y = judul.Location.Y;
            MinimumSize = Size;
            narahubungFisipData = new Dictionary<string, string>();
            narahubungInstitusiData = new Dictionary<string, string>();
            databaseSource =
                    Form1.RootDirectory + "\\hubunganKerjaSama.db";
            button1.Click += new EventHandler(button1_Click);
        }

        public TambahKerjasama_Form(string tahun, int activeMode, DocumentList list) : this()
        {
            this.activeMode = activeMode;
            this.tahun = tahun;
            this.list = list;

            DateTime currentDate = mulaiBerlaku_DateTimePicker.Value;

            mulaiBerlaku_DateTimePicker.Value = new DateTime(int.Parse(tahun), currentDate.Month, currentDate.Day);
            tanggalTTD_DateTimePicker.Value = new DateTime(int.Parse(tahun), currentDate.Month, currentDate.Day);
            if (activeMode == DocumentList.KERJASAMA_DALAM_NEGERI)
                dalamNegeri_RadioButton.Select();
            else
                luarNegeri_RadioButton.Select();
        }

        public TambahKerjasama_Form(string id, DocumentList list) : this()
        {
            this.list = list;
            this.id = id;
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
            {
                string query = "select * from kerjasama where id = " + id;
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        Dictionary<string, int> monthNumber = new Dictionary<string, int>();
                        monthNumber.Add("January", 1);
                        monthNumber.Add("February", 2);
                        monthNumber.Add("March", 3);
                        monthNumber.Add("April", 4);
                        monthNumber.Add("May", 5);
                        monthNumber.Add("June", 6);
                        monthNumber.Add("July", 7);
                        monthNumber.Add("August", 8);
                        monthNumber.Add("September", 9);
                        monthNumber.Add("October", 10);
                        monthNumber.Add("November", 11);
                        monthNumber.Add("December", 12);

                        monthNumber.Add("Januari", 1);
                        monthNumber.Add("Februari", 2);
                        monthNumber.Add("Maret", 3);
                        monthNumber.Add("Mei", 5);
                        monthNumber.Add("Juni", 6);
                        monthNumber.Add("Juli", 7);
                        monthNumber.Add("Agustus", 8);
                        monthNumber.Add("Oktober", 10);
                        monthNumber.Add("Desember", 12);

                        // set form
                        if (result.Read())
                        {
                            filePath = result["filePath"] + "";
                            docPath = result["documentPath"] + "";
                            judulFile_TextBox.Text = result["namaFile"] + "";
                            if ((result["jenisKerjasama"] + "").Equals(DocumentList.KERJASAMA_DALAM_NEGERI + ""))
                                dalamNegeri_RadioButton.Select();
                            else
                                luarNegeri_RadioButton.Select();
                            institusi_TextBox.Text = result["institusi"] + "";
                            noPerjanjianFisip_TextBox.Text = result["nomorPerjanjianFisip"] + "";
                            noPerjanjianInstitusi_TextBox.Text = result["nomorPerjanjianInstitusi"] + "";
                            penandatanganFisip_TextBox.Text = result["penandatanganFisip"] + "";
                            penandatanganInstitusi_TextBox.Text = result["penandatanganInstitusi"] + "";
                            unitPengusul_TextBox.Text = result["unitPengusul"] + "";
                            nilaiKerjasama_TextBox.Text = result["nilaiKerjasama"] + "";

                            string[] ttd = (result["tempatTanggalTTD"] + "").Split(',');
                            tempatTtd_TextBox.Text = ttd[0];

                            string[] dates = ttd[1].Split(' ');
                            int year = int.Parse(dates[dates.Length - 1]);
                            int month = monthNumber[dates[dates.Length - 2] + ""];
                            int date = int.Parse(dates[dates.Length - 3]);
                            tanggalTTD_DateTimePicker.Value = new DateTime(year, month, date);

                            dates = (result["mulaiBerlaku"] + "").Split(' ');
                            year = int.Parse(dates[dates.Length - 1]);
                            month = monthNumber[dates[dates.Length - 2] + ""];
                            date = int.Parse(dates[dates.Length - 3]);
                            mulaiBerlaku_DateTimePicker.Value = new DateTime(year, month, date);
                            //mulaiBerlaku_DateTimePicker.Text = result["mulaiBerlaku"] + "";

                            dates = (result["berhentiBerlaku"] + "").Split(' ');
                            year = int.Parse(dates[dates.Length - 1]);
                            month = monthNumber[dates[dates.Length - 2] + ""];
                            date = int.Parse(dates[dates.Length - 3]);
                            berakhirPada_DateTimePicker.Value = new DateTime(year, month, date);

                            fokusPerjanjianData = result["fokusPerjanjian"] + "";
                            unitPenggunaData = result["unitPengguna"] + "";
                            narahubungFisipData.Add("nama", result["namaNarahubungFisip"] + "");
                            narahubungFisipData.Add("email", result["emailNarahubungFisip"] + "");
                            narahubungFisipData.Add("jabatan", result["jabatanNarahubungFisip"] + "");
                            narahubungFisipData.Add("handphone", result["handphoneNarahubungFisip"] + "");

                            narahubungInstitusiData.Add("nama", result["namaNarahubungInstitusi"] + "");
                            narahubungInstitusiData.Add("email", result["emailNarahubungInstitusi"] + "");
                            narahubungInstitusiData.Add("jabatan", result["jabatanNarahubungInstitusi"] + "");
                            narahubungInstitusiData.Add("handphone", result["handphoneNarahubungInstitusi"] + "");

                            browse_textBox.Text = result["documentPath"] + "";

                            button1.Click -= new EventHandler(button1_Click);
                            button1.Click += new EventHandler(button1_Click2);
                        }
                    }
                }
                conn.Close();
            }
        }

        // event handlers
        private void TambahKerjasama_Form_SizeChanged(object sender, EventArgs e)
        {
            judul.Location = new Point(
                this.Width / 2 - judul.Width / 2,
                y
            );
        }

        private void editFokusPerjanjian_Button_Click(object sender, EventArgs e)
        {
            FokusPerjanjian fokusPerjanjian = new FokusPerjanjian(this);
            fokusPerjanjian.ShowDialog();
        }

        private void editUnitPengguna_Button_Click(object sender, EventArgs e)
        {
            UnitPengguna unitPengguna = new UnitPengguna(this);
            unitPengguna.ShowDialog();
        }

        private void editNarahubung_Button_Click(object sender, EventArgs e)
        {
            Narahubung narahubung = new Narahubung(this);
            narahubung.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DocumentHandler creatingProcess = new DocumentHandler();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
                {
                    conn.Open();

                    // insert new document
                    int tahun = mulaiBerlaku_DateTimePicker.Value.Year;
                    int pilihan = (dalamNegeri_RadioButton.Checked) ? 1 : 2;
                    string tempattanggalttd = tempatTtd_TextBox.Text + ", " + tanggalTTD_DateTimePicker.Value.ToString("dd MMMM yyyy");
                    string mulaiBerlaku = mulaiBerlaku_DateTimePicker.Value.ToString("dd MMMM yyyy");
                    string berhentiBerlaku = berakhirPada_DateTimePicker.Value.ToString("dd MMMM yyyy");
                    string filePath =
                        ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + judulFile_TextBox.Text + ".docx";
                    string documntPath = 
                        "Dokumen Perjanjian\\" + ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + tahun + "\\" +
                        browse_textBox.Text;

                    //copy file
                    if (!File.Exists(Form1.RootDirectory + "\\" + documntPath))
                        File.Copy(documentPathFile, Form1.RootDirectory + "\\" + documntPath);
                    else
                    {
                        MessageBox.Show("Nama file dokumen sudah digunakan.\nUbah nama dokumen yang akan disimpan sebelum memasukkan data baru.");
                        return;
                    }

                    string query = "insert into kerjasama values" +
                        "(null, '" + judulFile_TextBox.Text + "'," +
                        "" + tahun + ", " + pilihan + "," +
                        "'" + institusi_TextBox.Text + "', '" + noPerjanjianFisip_TextBox.Text + "'," +
                        "'" + noPerjanjianInstitusi_TextBox.Text + "', '" + tempattanggalttd + "'," +
                        "'" + mulaiBerlaku + "', '" + berhentiBerlaku + "'," +
                        "'" + fokusPerjanjianData + "', '" + penandatanganFisip_TextBox.Text + "', '" + penandatanganInstitusi_TextBox.Text + "'" +
                        ", '" + unitPengusul_TextBox.Text + "', '" + unitPenggunaData + "', '" + narahubungFisipData["nama"] + "'," +
                        "'" + narahubungFisipData["handphone"] + "', '" + narahubungFisipData["email"] + "'," +
                        "'" + narahubungInstitusiData["nama"] + "', '" + narahubungInstitusiData["handphone"] + "'," +
                        "'" + narahubungInstitusiData["email"] + "', '" + narahubungFisipData["jabatan"] + "'," +
                        "'" + narahubungInstitusiData["jabatan"] + "', " + nilaiKerjasama_TextBox.Text + "," +
                        "'" + filePath + "', '"+ documntPath + "')";

                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, conn))
                            command.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Pastikan semua informasi terisi dan tidak terjadi duplikasi pada nomor surat perjanjian.\n" + ex.Message);
                        return;
                    }


                    // get latest id
                    int latestID = 0;
                    query = "select max(id) from kerjasama";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                        latestID = int.Parse(command.ExecuteScalar().ToString());


                    // update value
                    string filePathWithoutDocx =
                        Form1.RootDirectory + "\\"
                        + ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + tahun + "\\" + latestID + "_"
                        + judulFile_TextBox.Text + "_";

                    filePath =
                        ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + tahun + "\\" + latestID + "_"
                        + judulFile_TextBox.Text + "_.docx";

                    query = "update kerjasama set filepath='" + filePath + "' where id=" + latestID;

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                        command.ExecuteNonQuery();


                    creatingProcess.FilePath = filePathWithoutDocx;
                    creatingProcess.BerhentiBerlaku = berhentiBerlaku;
                    creatingProcess.EmailNarahubungFisip = narahubungFisipData["email"];
                    creatingProcess.Judul = judulFile_TextBox.Text;
                    creatingProcess.EmailNarahubungInstitusi = narahubungInstitusiData["email"];
                    creatingProcess.FokusPerjanjian = fokusPerjanjianData;
                    creatingProcess.HandphoneNarahubungFisip = narahubungFisipData["handphone"];
                    creatingProcess.HandphoneNarahubungInstitusi = narahubungInstitusiData["handphone"];
                    creatingProcess.Institusi = institusi_TextBox.Text;
                    creatingProcess.JabatanNarahubungFisip = narahubungFisipData["jabatan"];
                    creatingProcess.JabatanNarahubungInstitusi = narahubungInstitusiData["jabatan"];
                    creatingProcess.MulaiBerlaku = mulaiBerlaku;
                    creatingProcess.NamaNarahubungFisip = narahubungFisipData["nama"];
                    creatingProcess.NamaNarahubungInstitusi = narahubungInstitusiData["nama"];
                    creatingProcess.NilaiKerjasama = nilaiKerjasama_TextBox.Text;
                    creatingProcess.NomorPerjanjianFisip = noPerjanjianFisip_TextBox.Text;
                    creatingProcess.NomorPerjanjianInstitusi = noPerjanjianInstitusi_TextBox.Text;
                    creatingProcess.PenandatanganFisip = penandatanganFisip_TextBox.Text;
                    creatingProcess.PenandatanganInstitusi = penandatanganInstitusi_TextBox.Text;
                    creatingProcess.TempatTanggalTTD = tempattanggalttd;
                    creatingProcess.UnitPengguna = unitPenggunaData;
                    creatingProcess.UnitPengusul = unitPengusul_TextBox.Text;
                    
                    conn.Close();
                }

                creatingProcess.Create();
                MessageBox.Show("File berhasil dibuat");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("File gagal dibuat.\n" + ex.Message);
            }

            list.reloadList(sender, e);
            Close();
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
            {
                // delete row
                string query = "delete from kerjasama where id=" + id;
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    int affectedLine = command.ExecuteNonQuery();
                    Console.WriteLine(affectedLine);
                }
                conn.Close();
                filePath = Form1.RootDirectory + "\\" + filePath;
                docPath = Form1.RootDirectory + "\\" + docPath;
                if (File.Exists(filePath))
                {
                    MessageBox.Show("Test");
                    File.Delete(filePath);
                }
                if (File.Exists(docPath))
                {
                    MessageBox.Show("Test");
                    File.Delete(docPath);
                }
                MessageBox.Show(docPath + " " + filePath);
            }
            button1_Click(sender, e);
        }

        private void nilaiKerjasama_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            browseDocument.Filter = "PDF File|*.pdf";
            browseDocument.FileName = "";

            DialogResult result = browseDocument.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                documentPathFile = browseDocument.FileName;
                browse_textBox.Text = browseDocument.SafeFileName;
            }
        }


        // other functions
    }
}
