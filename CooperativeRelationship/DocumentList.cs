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

namespace CooperativeRelationship
{
    public partial class DocumentList : Form
    {

        static int KERJASAMA_DALAM_NEGERI = 1;
        static int KERJASAMA_LUAR_NEGERI = 2;

        public DocumentList()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
            List<Document> list = new List<Document>();

            list.Add(new Document("test", "nomor", "test", "test", "test", "test", "test", "test", "test", "test"));

            this.documents.SetObjects(list);
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
            nomorPerjanjian = nomor;
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
