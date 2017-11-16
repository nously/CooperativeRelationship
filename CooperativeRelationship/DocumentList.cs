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
        Popup popup;

        public DocumentList(Form1 parent, int activeMode, string tahun)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.activeMode = activeMode;
            this.tahun = tahun;
            this.parent = parent;

            databaseSource = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";

            Panel panel = new Panel();
            panel.BackColor = Color.AliceBlue;
            panel.Size = new Size(50, 50);
            popup = new Popup(panel);
            if (SystemInformation.IsComboBoxAnimationEnabled)
            {
                popup.ShowingAnimation = PopupAnimations.Slide | PopupAnimations.TopToBottom;
                popup.HidingAnimation = PopupAnimations.Slide | PopupAnimations.BottomToTop;
            }
            else
            {
                popup.ShowingAnimation = popup.HidingAnimation = PopupAnimations.None;
            }
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

        private void populateListView(SQLiteDataReader result)
        {
            List<Document> list = new List<Document>();
            while (result.Read())
            {
                Document document = new Document(result["institusi"] + "", "Lihat Detail", result["tempatTanggalTTD"] + "",
                    "Lihat Detail", "Lihat Detail", "Lihat Detail", result["unitPengusul"] + "", 
                    "Lihat Detail", "Lihat Detail", result["nilaiKerjasama"] + "");

                list.Add(document);
            }

            documents.ButtonClick += delegate (object sender, CellClickEventArgs e)
            {
                // pop up detail
                string x = ((Document)e.Model).Institusi;
                popup.Show(new Point(500,500));
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


        public Document(string institusi, string nomor, string tempatTanggalTTD,
            string masaBerlaku, string fokusPerjanjian, string penandatangan, string unitPengusul,
            string unitPengguna, string narahubung, string nilaiKerjasama
            ) {
            this.institusi = institusi;
            this.nomorPerjanjian = nomor;
            this.tempatTanggalTTD = tempatTanggalTTD;
            this.masaBerlaku = masaBerlaku;
            this.fokusPerjanjian = fokusPerjanjian;
            this.penandatangan = penandatangan;
            this.unitPengusul = unitPengusul;
            this.unitPengguna = unitPengguna;
            this.narahubung = narahubung;
            this.nilaiKerjasama = nilaiKerjasama;
        }

        public string Institusi
        {
            get
            {
                return institusi;
            }
        }

        public string NomorPerjanjian
        {
            get
            {
                return nomorPerjanjian;
            }
        }

        public string TempatTanggalTTD
        {
            get
            {
                return tempatTanggalTTD;
            }
        }

        public string MasaBerlaku
        {
            get
            {
                return masaBerlaku;
            }
        }

        public string FokusPerjanjian
        {
            get
            {
                return fokusPerjanjian;
            }
        }

        public string Penandatangan
        {
            get
            {
                return penandatangan;
            }
        }

        public string UnitPengusul
        {
            get
            {
                return unitPengusul;
            }
        }

        public string UnitPengguna
        {
            get
            {
                return unitPengguna;
            }
        }

        public string Narahubung
        {
            get
            {
                return narahubung;
            }
        }

        public string NilaiKerjasama
        {
            get
            {
                return nilaiKerjasama;
            }
        }
    }

}
