﻿using System;
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
            result.PageSetup.LeftMargin = 15;
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
            table.Range.ParagraphFormat.SpaceAfter = 0;
            table.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            table.Range.Font.Size = 11;
            table.Range.Bold = 0;

            //table.Columns[1].PreferredWidth = 200;
            //table.Columns[2].PreferredWidth = 550;

            // draws all borders
            for (int i = 1; i <= numRows; i++)
                for (int j = 1; j <= numColumns; j++)
                    table.Cell(i, j).Range.Borders.Enable = 1;

            return table;
        }

        private void populateData(Microsoft.Office.Interop.Word.Table table)
        {

        }

        public bool Create()
        {
            try
            {
                int rowPointer;

                // check fokusperjanjian amount
                string[] fokus = FokusPerjanjian.Split('_');

                // check unit pengguna amount
                string[] pengguna = FokusPerjanjian.Split('_');

                int numColumns = 9;
                int numRows = fokus.Length + pengguna.Length + 10;

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
                Console.Write(ex.Message);
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
    }
}
