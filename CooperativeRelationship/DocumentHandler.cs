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

        private Microsoft.Office.Interop.Word.Table configureTable(Microsoft.Office.Interop.Word.Table table, int numRows, int numColumns)
        {
            int rowPointer = 1;

            // check fokusperjanjian amount
            string[] fokus = FokusPerjanjian.Split('_');

            // check unit pengguna amount
            string[] pengguna = UnitPengguna.Split('_');

            table.Range.ParagraphFormat.SpaceAfter = 0;
            table.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
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
            rowPointer += 1;

            // rowPointer == 2
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));
            rowPointer += 2;

            // rowPointer == 4
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 5));
            rowPointer += 2;

            // rowPointer == 6
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            rowPointer += 1;

            // rowPointer == 7
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 8));
            table.Cell(rowPointer + 1, 3).Split(1, 4);
            table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + 1, 1));
            table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + 1, 2));
            table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + 1, 7));
            rowPointer += 2;

            // rowPointer == 9
            int fokusNum = fokus.Length;
            for (int i = 0; i < fokusNum; i++)
                table.Cell(rowPointer + i, 3).Merge(table.Cell(rowPointer + i, 8));
            if (fokusNum > 1)
            {
                table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + fokusNum - 1, 1));
                table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + fokusNum - 1, 2));
                table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + fokusNum - 1, 4));
            }
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
            rowPointer += 3;

            // baris 7
            table.Cell(rowPointer, 3).Merge(table.Cell(rowPointer, 8));
            rowPointer += 1;

            // baris 8
            int penggunaNum = pengguna.Length;
            for (int i = 0; i < penggunaNum; i++)
                table.Cell(rowPointer + i, 3).Merge(table.Cell(rowPointer + i, 8));
            if (penggunaNum > 1)
            {
                table.Cell(rowPointer, 1).Merge(table.Cell(rowPointer + penggunaNum - 1, 1));
                table.Cell(rowPointer, 2).Merge(table.Cell(rowPointer + penggunaNum - 1, 2));
                table.Cell(rowPointer, 4).Merge(table.Cell(rowPointer + penggunaNum - 1, 4));
            }
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
            rowPointer += 4;

            // baris 10
            table.Cell(rowPointer + 1, 3).Merge(table.Cell(rowPointer + 1, 5));
            table.Cell(rowPointer + 1, 4).Merge(table.Cell(rowPointer + 1, 6));

            return table;
        }

        private void populateData(Microsoft.Office.Interop.Word.Table table)
        {

        }

        public bool Create()
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(FilePath);
                // check fokusperjanjian amount
                string[] fokus = FokusPerjanjian.Split('_');

                // check unit pengguna amount
                string[] pengguna = FokusPerjanjian.Split('_');

                int numColumns = 9;
                int numRows = fokus.Length + pengguna.Length + 17;

                // create document
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document writer = wordApp.Documents.Add(
                    ref missing, ref missing, ref missing, ref missing);

                wordApp.Visible = false;
                wordApp.ShowAnimation = false;

                writer = configureDocument(writer);

                writer.Content.Text = Judul;
                writer.Range(0, 5).ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                // table configuration
                object endOfDoc = "\\endofdoc";
                Microsoft.Office.Interop.Word.Range rangeOfWord = writer.Bookmarks.get_Item(endOfDoc).Range;
                Microsoft.Office.Interop.Word.Table table = writer.Tables.Add(rangeOfWord, numRows, numColumns, ref missing, ref missing);

                table = configureTable(table, numRows, numColumns);

                // populating table with data
                populateData(table);

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
