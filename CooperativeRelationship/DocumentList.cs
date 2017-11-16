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

            databaseSource = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";
        }

        private void tambahKerjasama_button_Click(object sender, EventArgs e)
        {
            new TambahKerjasama_Form().Show();
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
                //string query = "SELECT * FROM kerjasama";

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

        private void populateListView(SQLiteDataReader result)
        {
            List<Document> list = new List<Document>();
            while (result.Read())
            {
                Popup nomorPerjanjianPopup = createPopup("Nomor Perjanjian dengan Institusi \n" + result["institusi"] +
                "\n\nNomor Perjanjian di FISIP:\n" + result["nomorPerjanjianFisip"] + "\n"
                + "Nomor Perjanjian di Institusi Terkait:\n" + result["nomorPerjanjianInstitusi"]);

                Popup masaBerlakuPopup = createPopup("Masa Berlaku Perjanjian dengan Institusi\n" + result["institusi"]);
                Popup fokusPerjanjianPopup = createPopup("Fokus Perjanjian dengan Instintusi\n" + result["institusi"]);
                Popup penandatanganPopup = createPopup("Penandatangan Perjanjian dengan Institusi\n" + result["institusi"]);
                Popup unitPenggunaPopup = createPopup("Unit Pengguna dalam Perjanjian dengan Institusi\n" + result["institusi"]);
                Popup narahubungPopup = createPopup("Narahubung dalam Perjanjian dengan Institusi\n" + result["institusi"]);


                Document document = new Document(result["institusi"] + "", "Lihat Detail", result["tempatTanggalTTD"] + "",
                    "Lihat Detail", "Lihat Detail", "Lihat Detail", result["unitPengusul"] + "", 
                    "Lihat Detail", "Lihat Detail", result["nilaiKerjasama"] + "", nomorPerjanjianPopup, masaBerlakuPopup,
                    fokusPerjanjianPopup, penandatanganPopup, unitPenggunaPopup, narahubungPopup);

                list.Add(document);
            }

            documents.ButtonClick += delegate (object sender, CellClickEventArgs e)
            {
                // pop up detail
                Document clickedDocument = (Document)e.Model;

                if (e.Column.Text.Equals("Nomor Perjanjian"))
                    clickedDocument.NomorPerjanjianPopup.Show(new Point(Screen.PrimaryScreen.Bounds.Width / 2 - Screen.PrimaryScreen.Bounds.Width / 6, 
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
            };
            documents.RowHeight = 35;
            documents.FullRowSelect = true;
            documents.SetObjects(list);
            
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
        Popup nomorPerjanjianPopup;
        Popup masaBerlakuPopup;
        Popup fokusPerjanjianPopup;
        Popup penandatanganPopup;
        Popup unitPenggunaPopup;
        Popup narahubungPopup;

        public Document(string institusi, string nomor, string tempatTanggalTTD,
            string masaBerlaku, string fokusPerjanjian, string penandatangan, string unitPengusul,
            string unitPengguna, string narahubung, string nilaiKerjasama, Popup nomorPerjanjianPopup, Popup masaBerlakuPopup,
            Popup fokusPerjanjianPopup, Popup penandatanganPopup, Popup unitPenggunaPopup, Popup narahubungPopup)
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
    }

}
