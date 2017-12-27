using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using BrightIdeasSoftware;
using PopupControl;
using System.Diagnostics;
using System.IO;

namespace CooperativeRelationship
{
    public partial class DocumentList : Form
    {
        public static int KERJASAMA_DALAM_NEGERI = 1;
        public static int KERJASAMA_LUAR_NEGERI = 2;
        private string databaseSource;

        int activeMode;
        string tahun;
        Form1 parent;

        public DocumentList(Form1 parent, int activeMode, string tahun)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.activeMode = activeMode;
            this.tahun = tahun;
            this.parent = parent;
            Text = "Daftar Perjanjian Kerjasama Tahun " + tahun;

            databaseSource = 
                Form1.RootDirectory + "\\hubunganKerjaSama.db";
        }

        private void tambahKerjasama_button_Click(object sender, EventArgs e)
        {
            new TambahKerjasama_Form(tahun, activeMode, this).Show();
        }

        private void tambahKerjasama_button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Hand;
        }

        private void tambahKerjasama_button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Cursor = Cursors.Arrow;
        }

        private void DocumentList_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + this.databaseSource))
            {
                string query = "SELECT * FROM kerjasama WHERE jenisKerjasama=" + this.activeMode + " AND tahun=" + this.tahun;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        populateListView(result);
                    }
                }
                conn.Close();
            }
        }

        private Popup createPopup (string message)
        {
            Popup popup;

            ComplexPopup complexPopup = new ComplexPopup();
            Panel panel = new Panel();
            panel.Parent = complexPopup;
            panel.Dock = DockStyle.Fill;

            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Parent = panel;

            popup = new Popup(complexPopup);
            popup.Size = new Size(Screen.PrimaryScreen.Bounds.Width / 3, 200);
            popup.Resizable = true;

            if (SystemInformation.IsComboBoxAnimationEnabled)
            {
                popup.ShowingAnimation = PopupAnimations.Slide | PopupAnimations.TopToBottom;
                popup.HidingAnimation = PopupAnimations.Slide | PopupAnimations.BottomToTop;
            }
            else
            {
                popup.ShowingAnimation = popup.HidingAnimation = PopupAnimations.None;
            }
            return popup;
        }

        public void reloadList(object sender, EventArgs e)
        {
            documents.Items.Clear();
            DocumentList_Load(sender, e);
        }

        private void populateListView(SQLiteDataReader result)
        {
            List<Document> list = new List<Document>();
            // populate objectlistview
            while (result.Read())
            {
                Popup nomorPerjanjianPopup = createPopup("Nomor Perjanjian dengan Institusi " + result["institusi"] +
                "\n\nNomor Perjanjian di FISIP:\n" + result["nomorPerjanjianFisip"] + "\n"
                + "Nomor Perjanjian di Institusi Terkait:\n" + result["nomorPerjanjianInstitusi"]);

                string[] words = (result["fokusPerjanjian"] + "").Split('|');
                string focuses = "Fokus Perjanjian dengan Instintusi " + result["institusi"] + "\n\n";
                string users = "Unit Pengguna dalam Perjanjian dengan Institusi " + result["institusi"] + "\n\n";

                foreach (string word in words)
                    if (!word.Equals(""))
                        focuses += "\n- " + word;

                words = (result["unitPengguna"] + "").Split('|');

                foreach (string word in words)
                    if (!word.Equals(""))
                        users += "\n- " + word;

                Popup masaBerlakuPopup = 
                    createPopup("Masa Berlaku Perjanjian dengan Institusi " + result["institusi"] + "\n\n" +
                    "Mulai berlaku pada:\n    > " + result["mulaiBerlaku"] + "\n" +
                    "Berakhir pada:\n    > " + result["berhentiBerlaku"]);
                Popup fokusPerjanjianPopup = createPopup(focuses);
                Popup penandatanganPopup = 
                    createPopup("Penandatangan Perjanjian dengan Institusi " + result["institusi"] + "\n\n" +
                    "Penandatangan Fakultas Ilmu Sosial dan Ilmu Politik:\n    > " + 
                    result["penandatanganFisip"] + "\n" +
                    "Penandatangan Intitusi terkait:\n    > " + result["penandatanganInstitusi"]);
                Popup unitPenggunaPopup = createPopup(users);
                Popup narahubungPopup = 
                    createPopup("Narahubung dalam Perjanjian dengan Institusi\n" + result["institusi"]);

                Document document = new Document(result["institusi"] + "", "Lihat Detail", result["tempatTanggalTTD"] + "",
                    "Lihat Detail", "Lihat Detail", "Lihat Detail", result["unitPengusul"] + "",
                    "Lihat Detail", "Lihat Detail", result["nilaiKerjasama"] + "", result["filePath"] + "", result["documentPath"] + "",
                    nomorPerjanjianPopup, masaBerlakuPopup, fokusPerjanjianPopup, penandatanganPopup, unitPenggunaPopup,
                    narahubungPopup);
                document.PathFile = result["filePath"] + "";
                document.Id = result["id"] + "";

                list.Add(document);
            }
            
            // show the popup when click the button
            documents.ButtonClick += delegate (object sender, CellClickEventArgs e)
            {
                // pop up detail
                Document clickedDocument = (Document)e.Model;

                if (e.Column.Text.Equals("Nomor Perjanjian"))
                    clickedDocument.NomorPerjanjianPopup
                    .Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Masa Berlaku"))
                    clickedDocument.MasaBerlakuPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Fokus Perjanjian"))
                    clickedDocument.FokusPerjanjianPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Penandatangan"))
                    clickedDocument.PenandatanganPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Unit Pengguna"))
                    clickedDocument.UnitPenggunaPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Narahubung"))
                    clickedDocument.NarahubungPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6,
                        Screen.PrimaryScreen.Bounds.Height / 2 - 125));
                else if (e.Column.Text.Equals("Edit"))
                {
                    TambahKerjasama_Form form = new TambahKerjasama_Form(clickedDocument.Id, this);
                    form.Show();
                }
                else if (e.Column.Text.Equals("Hapus"))
                {
                    using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
                    {
                        // delete row
                        string query = "delete from kerjasama where id=" + clickedDocument.Id;
                        conn.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, conn))
                        {
                            int affectedLine = command.ExecuteNonQuery();
                            Console.WriteLine(affectedLine);
                        }
                        conn.Close();
                        if (File.Exists(clickedDocument.PathFile))
                        {
                            File.Delete(clickedDocument.PathFile);
                        }
                    }
                    reloadList(sender, e);
                }
                else if (e.Column.Text.Equals("Buka Dokumen"))
                {
                    System.Diagnostics.Process.Start(@clickedDocument.DocumentPath);
                }
            };

            // opens the *.docx file when doubleclick on item
            documents.CellClick += delegate (object sender, CellClickEventArgs e)
            {
                if (e.ClickCount == 2)
                {
                    try
                    {
                        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                        object missing = System.Reflection.Missing.Value;
                        wordApp.Visible = true;
                        wordApp.ShowAnimation = true;
                        Microsoft.Office.Interop.Word.Document writer = wordApp.Documents.Open(((Document)e.Model).PathFile);
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            };

            documents.RowHeight = 35;
            documents.FullRowSelect = true;
            documents.SetObjects(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + this.databaseSource))
            {
                string query = "SELECT * FROM kerjasama WHERE jenisKerjasama=" + this.activeMode + " AND tahun=" + this.tahun
                    + " AND institusi LIKE '%"+ search_textBox.Text +"%'";
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        documents.Items.Clear();
                        populateListView(result);
                    }
                }
                conn.Close();
            }
        }

        private void search_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

    class Document
    {
        private string institusi;
        private string nomorPerjanjian;
        private string tempatTanggalTTD;
        private string masaBerlaku;
        private string fokusPerjanjian;
        private string penandatangan;
        private string unitPengusul;
        private string unitPengguna;
        private string narahubung;
        private string nilaiKerjasama;
        private string pathFile;
        private string id;
        private string documentPath;
        Popup nomorPerjanjianPopup;
        Popup masaBerlakuPopup;
        Popup fokusPerjanjianPopup;
        Popup penandatanganPopup;
        Popup unitPenggunaPopup;
        Popup narahubungPopup;

        public Document(string institusi, string nomor, string tempatTanggalTTD,
            string masaBerlaku, string fokusPerjanjian, string penandatangan, string unitPengusul,
            string unitPengguna, string narahubung, string nilaiKerjasama, string PathFile, string documentPath, Popup nomorPerjanjianPopup, 
            Popup masaBerlakuPopup, Popup fokusPerjanjianPopup, Popup penandatanganPopup, Popup unitPenggunaPopup, 
            Popup narahubungPopup)
        {
            Institusi = institusi;
            NomorPerjanjian = nomor;
            TempatTanggalTTD = tempatTanggalTTD;
            MasaBerlaku = masaBerlaku;
            FokusPerjanjian = fokusPerjanjian;
            Penandatangan = penandatangan;
            UnitPengusul = unitPengusul;
            UnitPengguna = unitPengguna;
            Narahubung = narahubung;
            NilaiKerjasama = nilaiKerjasama;
            PathFile = pathFile;
            DocumentPath = documentPath;
            NomorPerjanjianPopup = nomorPerjanjianPopup;
            MasaBerlakuPopup = masaBerlakuPopup;
            FokusPerjanjianPopup = fokusPerjanjianPopup;
            PenandatanganPopup = penandatanganPopup;
            UnitPenggunaPopup = unitPenggunaPopup;
            NarahubungPopup = narahubungPopup;
        }

        public Popup NomorPerjanjianPopup { get => nomorPerjanjianPopup; set => nomorPerjanjianPopup = value; }
        public Popup MasaBerlakuPopup { get => masaBerlakuPopup; set => masaBerlakuPopup = value; }
        public Popup FokusPerjanjianPopup { get => fokusPerjanjianPopup; set => fokusPerjanjianPopup = value; }
        public Popup PenandatanganPopup { get => penandatanganPopup; set => penandatanganPopup = value; }
        public Popup UnitPenggunaPopup { get => unitPenggunaPopup; set => unitPenggunaPopup = value; }
        public Popup NarahubungPopup { get => narahubungPopup; set => narahubungPopup = value; }
        public string Institusi { get => institusi; set => institusi = value; }
        public string NomorPerjanjian { get => nomorPerjanjian; set => nomorPerjanjian = value; }
        public string TempatTanggalTTD { get => tempatTanggalTTD; set => tempatTanggalTTD = value; }
        public string MasaBerlaku { get => masaBerlaku; set => masaBerlaku = value; }
        public string FokusPerjanjian { get => fokusPerjanjian; set => fokusPerjanjian = value; }
        public string Penandatangan { get => penandatangan; set => penandatangan = value; }
        public string UnitPengusul { get => unitPengusul; set => unitPengusul = value; }
        public string UnitPengguna { get => unitPengguna; set => unitPengguna = value; }
        public string Narahubung { get => narahubung; set => narahubung = value; }
        public string NilaiKerjasama { get => nilaiKerjasama; set => nilaiKerjasama = value; }
        public string PathFile { get => pathFile; set => pathFile = value; }
        public string Id { get => id; set => id = value; }
        public string DocumentPath { get => documentPath; set => documentPath = value; }

        public string Edit() { return "Edit"; }
        public string BukaDokumen() { return "Buka"; }
        public string Hapus() { return "Hapus"; }
    }

}
