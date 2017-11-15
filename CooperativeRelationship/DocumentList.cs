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

            // Add the columns just like in database
            //documents.Columns.Add("Institusi", 250, HorizontalAlignment.Left);
            //documents.Columns.Add("Nomor Perjanjian", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Waktu, Tempat TTD", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Masa Berlaku", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Fokus Perjanjian", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Penandatangan", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Unit Pengusul", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Unit Pengguna", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Narahubung FISIP", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Narahubung Institusi", 100, HorizontalAlignment.Left);
            //documents.Columns.Add("Nilai Kerjasama", 100, HorizontalAlignment.Left);

            loadData();
        }

        private void loadData()
        {
            documents.FullRowSelect = true;

            string path =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";
            using (SQLiteConnection conn = new SQLiteConnection("data source="+path))
            {
                using (SQLiteCommand command = new SQLiteCommand("select * from kerjasama", conn))
                {
                    conn.Open();
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        while(result.Read())
                        {
                            var item = new ListViewItem(
                                new[] { result[4]+"", result[5]+"", result[7]+"" }
                                );

                            documents.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
