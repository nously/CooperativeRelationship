using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeRelationship
{
    public partial class DocumentList : Form
    {
        public DocumentList()
        {
            InitializeComponent();
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
            documents.Columns.Add("Institusi", 170, HorizontalAlignment.Left);
            documents.Columns.Add("Nomor Perjanjian", 150, HorizontalAlignment.Left);
            documents.Columns.Add("Waktu, Tempat TTD", 170, HorizontalAlignment.Left);
            documents.Columns.Add("Mulai Berlaku", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Berhenti Berlaku", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Fokus Perjanjian", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Penandatangan FISIP", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Penandatangan Institusi", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Unit Pengusul", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Unit Pengguna", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Narahubung FISIP", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Narahubung Institusi", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Narahubung Institusi", 100, HorizontalAlignment.Left);
            documents.Columns.Add("Nilai Kerjasama", 100, HorizontalAlignment.Left);
        }
    }
}
