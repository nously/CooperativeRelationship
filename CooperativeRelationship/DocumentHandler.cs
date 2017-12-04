using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace CooperativeRelationship
{
    public class DocumentHandler
    {
        private string judul;
        private string tahun;
        private string jenisKerjasama;
        private string institusi;
        private string nomorPerjanjianFisip;
        private string nomorPerjanjianInstitusi;
        private string tempatTanggalTTD;
        private string mulaiBerlaku;
        private string berhentiBerlaku;
        private string fokusPerjanjian;
        private string penandatanganFisip;
        private string penandatanganInstitusi;
        private string unitPengusul;
        private string unitPengguna;
        private string namaNarahubungFisip;
        private string handphoneNarahubungFisip;
        private string emailNarahubungFisip;
        private string namaNarahubungInstitusi;
        private string handphoneNarahubungInstitusi;
        private string emailNarahubungInstitusi;
        private string jabatanNarahubungFisip;
        private string jabatanNarahubungInstitusi;
        private string nilaiKerjasama;
        private string filePath;

        public DocumentHandler()
        {

        }

        private Microsoft.Office.Interop.Word.Document configureDocument(Microsoft.Office.Interop.Word.Document writer)
        {
            // change page orientation
            // set margin
            Microsoft.Office.Interop.Word.Document result = writer;
            result.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
            result.PageSetup.LeftMargin = 25;
            result.PageSetup.TopMargin = 15;

            return result;
        }

        private void saveDocument(Microsoft.Office.Interop.Word.Document writer, object missing)
        {
            Object savedir = filePath;
            writer.SaveAs2(ref savedir);
            writer.Close(ref missing, ref missing, ref missing);
        }

        private Microsoft.Office.Interop.Word.Table configureTable(
            Microsoft.Office.Interop.Word.Document writer, 
            Microsoft.Office.Interop.Word.Table table, int numRows, int numColumns)
        {
            int rowPointer = 1;

            // check fokusperjanjian amount
            string[] fokus = FokusPerjanjian.Split('|');

            // check unit pengguna amount
            string[] pengguna = UnitPengguna.Split('|');

            table.Range.ParagraphFormat.SpaceAfter = 0;
            table.Range.ParagraphFormat.Alignment = 
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            table.Range.Font.Size = 11;
            table.Range.Bold = 0;

            table.Columns[1].Width = 29;
            table.Columns[2].Width = 111;
            table.Columns[3].Width = 85;
            table.Columns[4].Width = 85;
            table.Columns[5].Width = 85;
            table.Columns[6].Width = 85;
            table.Columns[7].Width = 85;
            table.Columns[8].Width = 85;
            table.Columns[9].Width = 86;

            // draws all borders
            for (int i = 1; i <= numRows; i++)
                for (int j = 1; j <= numColumns; j++)
                    table.Cell(i, j).Range.Borders.Enable = 1;

            // merging  
            // rowPointer == 1
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Rows[1].Range.ParagraphFormat.Alignment = 
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            table.Cell(rowPointer, 1).Range.Text = "NO.";
            table.Cell(rowPointer, 2).Range.Text = "INDIKATOR PERJANJIAN";
            table.Cell(rowPointer, 3).Range.Text = "KETERANGAN DETAIL";
            table.Cell(rowPointer, 4).Range.Text = "KETERANGAN / STATUS";
            rowPointer += 1;

            // rowPointer == 2
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer, 3).Range.ParagraphFormat.Alignment =
            table.Cell(rowPointer + 1, 3).Range.ParagraphFormat.Alignment =
            table.Cell(rowPointer + 1, 4).Range.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

            table.Cell(rowPointer, 1).Range.Text = "01";
            table.Cell(rowPointer, 2).Range.Text = "Perjanjian Kerjasama Dilakukan Antara";
            table.Cell(rowPointer, 3).Range.Text = "Institusi";
            table.Cell(rowPointer + 1, 3).Range.Text = "Fakultas Ilmu Sosial dan Ilmu Politik";
            table.Cell(rowPointer + 1, 4).Range.Text = Institusi;
            
            rowPointer += 2;

            // rowPointer == 4
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));

            table.Cell(rowPointer, 1).Range.Text = "02";
            table.Cell(rowPointer, 2).Range.Text = "Nomor Perjanjian";
            table.Cell(rowPointer + 1, 3).Range.Text = NomorPerjanjianFisip;
            table.Cell(rowPointer + 1, 4).Range.Text = NomorPerjanjianInstitusi;
            rowPointer += 2;

            // rowPointer == 6
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer, 1).Range.Text = "03";
            table.Cell(rowPointer, 2).Range.Text = "Tempat dan Tanggal Penandatanganan";
            table.Cell(rowPointer, 3).Range.Text = TempatTanggalTTD;
            rowPointer += 1;

            // rowPointer == 7
            int tahunMulai, tahunBerakhir;
            tahunMulai = int.Parse(MulaiBerlaku.Substring(MulaiBerlaku.Length - 4));
            tahunBerakhir = int.Parse(BerhentiBerlaku.Substring(BerhentiBerlaku.Length - 4));
            int durasi = tahunBerakhir - tahunMulai;

            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 8));
            table.Cell(rowPointer + 1, 3).Split(1, 4);
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 7));
            table.Cell(rowPointer, 1).Range.Text = "04";
            table.Cell(rowPointer, 2).Range.Text = "Masa Berlaku";
            table.Cell(rowPointer, 3).Range.Text = durasi + " Tahun";
            table.Cell(rowPointer + 1, 3).Range.Text = "Dimulai Pada";
            table.Cell(rowPointer + 1, 4).Range.Text = MulaiBerlaku;
            table.Cell(rowPointer + 1, 5).Range.Text = "Berakhir Pada";
            table.Cell(rowPointer + 1, 6).Range.Text = BerhentiBerlaku;
            rowPointer += 2;

            // rowPointer == 9
            int fokusNum = fokus.Length;
            for (int i = 0; i < fokusNum; i++)
            {
                table.Cell(rowPointer + i, 3).Merge(table.Cell(rowPointer + i, 8));
                byte j = (byte) (i + 1);
                table.Cell(rowPointer + i, 3).Range.Text = j + ". " + fokus[i];
            }
                
            if (fokusNum > 1)
            {
                table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + fokusNum - 1, 1));
                table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + fokusNum - 1, 2));
                table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + fokusNum - 1, 4));
            }
            table.Cell(rowPointer, 1).Range.Text = "05";
            table.Cell(rowPointer, 2).Range.Text = "Fokus Perjanjian";
            rowPointer += fokusNum;

            // baris 6
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 2, 3).Merge(table.Cell(rowPointer + 2, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer + 2, 4).Merge(table.Cell(rowPointer + 2, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 2, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 2, 2));
            table.Cell(rowPointer + 1, 5).Merge(table.Cell(rowPointer + 2, 5));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer, 1).Range.Text = "06";
            table.Cell(rowPointer, 2).Range.Text = "Ditandatangani Oleh";
            table.Cell(rowPointer, 3).Range.Text = "Institusi";
            table.Cell(rowPointer + 1, 3).Range.Text = "Fakultas Ilmu Sosial dan Ilmu Politik";
            table.Cell(rowPointer + 1, 4).Range.Text = Institusi;
            table.Cell(rowPointer + 2, 3).Range.Text = PenandatanganFisip;
            table.Cell(rowPointer + 2, 4).Range.Text = PenandatanganInstitusi;
            table.Cell(rowPointer, 3).Range.ParagraphFormat.Alignment =
                table.Cell(rowPointer + 1, 3).Range.ParagraphFormat.Alignment =
                table.Cell(rowPointer + 1, 4).Range.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            rowPointer += 3;

            // baris 7
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer, 1).Range.Text = "07";
            table.Cell(rowPointer, 2).Range.Text = "Unit Pengusul";
            table.Cell(rowPointer, 3).Range.Text = UnitPengusul;
            rowPointer += 1;

            // baris 8
            int penggunaNum = pengguna.Length;
            for (int i = 0; i < penggunaNum; i++)
            {
                table.Cell(rowPointer + i, 3).Merge(table.Cell(rowPointer + i, 8));
                byte counter = (byte)(i + 1);
                table.Cell(rowPointer + i, 3).Range.Text = counter + ". " + pengguna[i];
            }

            if (penggunaNum > 1)
            {
                table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + penggunaNum - 1, 1));
                table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + penggunaNum - 1, 2));
                table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + penggunaNum - 1, 4));
            }
            table.Cell(rowPointer, 1).Range.Text = "08";
            table.Cell(rowPointer, 2).Range.Text = "Unit pengguna";
            rowPointer += penggunaNum;

            // baris 9
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 3, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 3, 2));
            table.Cell(rowPointer + 2, 9).Merge(table.Cell(rowPointer + 3, 9));
            table.Cell(rowPointer + 1, 5).Merge(table.Cell(rowPointer + 2, 9));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer, 1).Range.Text = "09";
            table.Cell(rowPointer, 2).Range.Text = "Nara Hubung";
            table.Cell(rowPointer, 3).Range.Text = "Institusi";
            table.Cell(rowPointer + 1, 3).Range.Text = "Fakultas Ilmu Sosial dan Ilmu Politik";
            table.Cell(rowPointer + 1, 4).Range.Text = Institusi;
            table.Cell(rowPointer + 2, 3).Range.Text =
                table.Cell(rowPointer + 2, 6).Range.Text = "Nama";
            table.Cell(rowPointer + 2, 4).Range.Text =
                table.Cell(rowPointer + 2, 7).Range.Text = "No. Handphone";
            table.Cell(rowPointer + 2, 5).Range.Text =
                table.Cell(rowPointer + 2, 8).Range.Text = "E-mail";
            table.Cell(rowPointer + 3, 3).Range.Text = NamaNarahubungFisip;
            table.Cell(rowPointer + 3, 4).Range.Text = HandphoneNarahubungFisip;
            table.Cell(rowPointer + 3, 5).Range.Text = EmailNarahubungFisip;

            table.Cell(rowPointer + 3, 6).Range.Text = NamaNarahubungInstitusi;
            table.Cell(rowPointer + 3, 7).Range.Text = HandphoneNarahubungInstitusi;
            table.Cell(rowPointer + 3, 8).Range.Text = EmailNarahubungInstitusi;

            rowPointer += 4;

            // baris 10
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Range.Text = "10";
            table.Cell(rowPointer, 2).Range.Text = "Jabatan/Fungsi Nara Hubung";
            table.Cell(rowPointer, 3).Range.Text = JabatanNarahubungFisip;
            table.Cell(rowPointer, 4).Range.Text = JabatanNarahubungInstitusi;

            return table;
        }

        private void populateData(Microsoft.Office.Interop.Word.Table table, int numRows, int numColumns)
        {
            
        }

        public bool Create()
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(FilePath);
                // check fokusperjanjian amount
                string[] fokus = FokusPerjanjian.Split('|');

                // check unit pengguna amount
                string[] pengguna = FokusPerjanjian.Split('|');

                int numColumns = 9;
                int numRows = fokus.Length + pengguna.Length + 17;

                // create document
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document writer = wordApp.Documents.Add(
                    ref missing, ref missing, ref missing, ref missing);

                wordApp.Visible = false;
                wordApp.ShowAnimation = false;
                writer.Content.Bold = 1;

                writer = configureDocument(writer);
                
                writer.Content.Text = Judul;
                writer.Range(0, 1).ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                // table configuration
                object endOfDoc = "\\endofdoc";
                Microsoft.Office.Interop.Word.Range rangeOfWord = writer.Bookmarks.get_Item(endOfDoc).Range;
                Microsoft.Office.Interop.Word.Table table = writer.Tables.Add(rangeOfWord, numRows, numColumns, ref missing, ref missing);

                table = configureTable(writer, table, numRows, numColumns);
                writer.Content.Bold = 0;
                // populating table with data
                populateData(table, numRows, numColumns);

                // save document
                saveDocument(writer, missing);
                wordApp.Quit(ref missing, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete()
        {
            return false;
        }


        public string Judul { get => judul; set => judul = value; }
        public string Institusi { get => institusi; set => institusi = value; }
        public string NomorPerjanjianFisip { get => nomorPerjanjianFisip; set => nomorPerjanjianFisip = value; }
        public string NomorPerjanjianInstitusi { get => nomorPerjanjianInstitusi; set => nomorPerjanjianInstitusi = value; }
        public string TempatTanggalTTD { get => tempatTanggalTTD; set => tempatTanggalTTD = value; }
        public string MulaiBerlaku { get => mulaiBerlaku; set => mulaiBerlaku = value; }
        public string BerhentiBerlaku { get => berhentiBerlaku; set => berhentiBerlaku = value; }
        public string FokusPerjanjian { get => fokusPerjanjian; set => fokusPerjanjian = value; }
        public string PenandatanganFisip { get => penandatanganFisip; set => penandatanganFisip = value; }
        public string PenandatanganInstitusi { get => penandatanganInstitusi; set => penandatanganInstitusi = value; }
        public string UnitPengusul { get => unitPengusul; set => unitPengusul = value; }
        public string UnitPengguna { get => unitPengguna; set => unitPengguna = value; }
        public string NamaNarahubungFisip { get => namaNarahubungFisip; set => namaNarahubungFisip = value; }
        public string HandphoneNarahubungFisip { get => handphoneNarahubungFisip; set => handphoneNarahubungFisip = value; }
        public string EmailNarahubungFisip { get => emailNarahubungFisip; set => emailNarahubungFisip = value; }
        public string NamaNarahubungInstitusi { get => namaNarahubungInstitusi; set => namaNarahubungInstitusi = value; }
        public string HandphoneNarahubungInstitusi { get => handphoneNarahubungInstitusi; set => handphoneNarahubungInstitusi = value; }
        public string EmailNarahubungInstitusi { get => emailNarahubungInstitusi; set => emailNarahubungInstitusi = value; }
        public string JabatanNarahubungFisip { get => jabatanNarahubungFisip; set => jabatanNarahubungFisip = value; }
        public string JabatanNarahubungInstitusi { get => jabatanNarahubungInstitusi; set => jabatanNarahubungInstitusi = value; }
        public string NilaiKerjasama { get => nilaiKerjasama; set => nilaiKerjasama = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public string Tahun { get => tahun; set => tahun = value; }
        public string JenisKerjasama { get => jenisKerjasama; set => jenisKerjasama = value; }
    }
}
