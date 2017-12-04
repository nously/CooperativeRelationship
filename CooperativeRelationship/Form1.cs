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
    public partial class Form1 : Form
    {
        int activeMode;
        string tahun;
        private string databaseSource;

        public Form1()
        {
            InitializeComponent();
            databaseSource = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";
        }

        private void dalamNegeri_Button_MouseLeave(object sender, EventArgs e)
        {
            dalamNegeri_Button.BackColor = Color.Transparent;
            dalamNegeri_Button.Cursor = Cursors.Arrow;
        }

        private void dalamNegeri_Button_MouseEnter(object sender, EventArgs e)
        {
            dalamNegeri_Button.BackColor = Color.White;
            dalamNegeri_Button.Cursor = Cursors.Hand;
        }

        private void luarNegeri_Button_MouseEnter(object sender, EventArgs e)
        {
            luarNegeri_Button.BackColor = Color.White;
            luarNegeri_Button.Cursor = Cursors.Hand;
        }

        private void luarNegeri_Button_MouseLeave(object sender, EventArgs e)
        {
            luarNegeri_Button.BackColor = Color.Transparent;
            luarNegeri_Button.Cursor = Cursors.Arrow;
        }

        private void dalamNegeri_Button_MouseClick(object sender, MouseEventArgs e)
        {
            highlight_dalamNegeri.Visible = true;
            highlight_luarNegeri.Visible = false;
            label1.ForeColor = Color.FromArgb(52, 152, 219);
            label2.ForeColor = Color.Black;
            judulTahun.Text = "Kerjasama Dalam Negeri";
            activeMode = DocumentList.KERJASAMA_DALAM_NEGERI;

            loadTahun();
        }

        private void luarNegeri_Button_MouseClick(object sender, MouseEventArgs e)
        {
            highlight_luarNegeri.Visible = true;
            highlight_dalamNegeri.Visible = false;
            label2.ForeColor = Color.FromArgb(52, 152, 219);
            label1.ForeColor = Color.Black;
            judulTahun.Text = "Kerjasama Luar Negeri";
            activeMode = DocumentList.KERJASAMA_LUAR_NEGERI;

            loadTahun();
        }

        private void tahun_panel_MouseEnter(object sender, EventArgs e)
        {
            Control pan = sender as Control;

            if (pan is Label)
            {
                pan = pan.Parent;
            }

            pan.BackColor = Color.FromArgb(240, 240, 240);
            pan.Cursor = Cursors.Hand;
        }

        private void tahun_panel_MouseLeave(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;
            pan.BackColor = Color.White;
            pan.Cursor = Cursors.Arrow;
        }

        private void tahun_panel_Click(object sender, EventArgs e)
        {
            string[] words = ((Control)sender).Name.Split('_');

            new DocumentList(this, activeMode, words[1]).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            judulTahun.Text = "Kerjasama Dalam Negeri";
            activeMode = DocumentList.KERJASAMA_DALAM_NEGERI;

            loadTahun();
        }

        void loadTahun ()
        {
            flowLayoutPanel1.Controls.Clear();
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + this.databaseSource))
            {
                string query = "SELECT * FROM daftar_tahun WHERE jenis_kerjasama=" + activeMode + " ORDER BY tahun asc";
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            Label tahun = new Label();
                            Panel panel = new Panel();
                            tahun.Text = "Dimulai Tahun " + result["tahun"];

                            panel.Size = new Size(flowLayoutPanel1.Width, 40);
                            panel.Margin = new Padding(1, 1, 1, 1);
                            tahun.Location = new Point(25, 13);
                            tahun.AutoSize = true;

                            panel.Click += new EventHandler(tahun_panel_Click);
                            tahun.Click += new EventHandler(tahun_panel_Click);
                            panel.MouseEnter += new EventHandler(tahun_panel_MouseEnter);
                            tahun.MouseEnter += new EventHandler(tahun_panel_MouseEnter);
                            panel.MouseLeave += new EventHandler(tahun_panel_MouseLeave);

                            panel.Name = "panel_" + result["tahun"];
                            tahun.Name = "label_" + result["tahun"];

                            tahun.Parent = panel;
                            panel.Parent = flowLayoutPanel1;
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Panel panelTahun in flowLayoutPanel1.Controls)
            {
                panelTahun.Size = new Size(flowLayoutPanel1.Width, 40);
            }
        }

        private void tahunBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create folder
            // create row
        }

        private void kerjasamaBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahKerjasama_Form form = new TambahKerjasama_Form();
            form.Show();
        }
    }
}
