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
            documents.Columns.Clear();
            documents.Items.Clear();
            documents.View = View.Details;
            documents.Sorting = SortOrder.Ascending;
            documents.AllowColumnReorder = true;

            Document test = new Document();

            test.Institusi = "test";
            test.NomorPerjanjian = tambahKerjasama_button;
            test.TempatTanggalTTD = "test";

            documents.AddObject(test);
        }
    }

    class Document
    {
        public Document() { }

        public string Institusi
        {
            get; set;
        }

        public Button NomorPerjanjian
        {
            get; set;
        }

        public string TempatTanggalTTD
        {
            get; set;
        }

        public Button MasaBerlaku
        {
            get; set;
        }

        public Button FokusPerjanjian
        {
            get; set;
        }

        public Button Penandatangan
        {
            get; set;
        }

        public string UnitPengusul
        {
            get; set;
        }

        public Button UnitPengguna
        {
            get; set;
        }

        public Button Narahubung
        {
            get; set;
        }

        public string NilaiKerjasama
        {
            get; set;
        }
    }

}
