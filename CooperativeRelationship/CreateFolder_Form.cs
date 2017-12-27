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
using System.IO;

namespace CooperativeRelationship
{
    public partial class CreateFolder_Form : Form
    {
        Form1 parent;
        string databaseSource;

        public CreateFolder_Form(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            databaseSource =
                    Form1.RootDirectory + "\\hubunganKerjaSama.db";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
            {
                string jenis =
                    ((dalam.Checked) ? DocumentList.KERJASAMA_DALAM_NEGERI : DocumentList.KERJASAMA_LUAR_NEGERI)
                    + "";

                string query = "select * from daftar_tahun where tahun=" + tahun.Text
                    + " and jenis_kerjasama=" + jenis;

                bool exist = true;
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            string path =
                                Form1.RootDirectory + "\\" + ((dalam.Checked) ? dalam.Text : luar.Text) + "\\" +
                                tahun.Text;
                            string path2 =
                                Form1.RootDirectory + "\\Dokumen Perjanjian\\" + ((dalam.Checked) ? dalam.Text : luar.Text) + "\\" +
                                tahun.Text;

                            // create folder
                            Directory.CreateDirectory(path);
                            Directory.CreateDirectory(path2);

                            // add row
                            exist = false;
                        }
                        else
                        {
                            MessageBox.Show("Tahun sudah tersedia.");
                        }
                    }
                }
                if (!exist)
                {
                    query = "insert into daftar_tahun values (null, " + tahun.Text + ", " + jenis + ")";

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                        command.ExecuteNonQuery();
                }

                conn.Close();
            }
            parent.reload(sender, e);
            Close();
        }

        private void tahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
