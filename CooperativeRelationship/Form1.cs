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
    public partial class Form1 : Form
    {
        static string RootDirectory;
        int activeMode;
        string tahun;
        private string databaseSource;


        public Form1()
        {
            InitializeComponent();

            bool filled = true;
            using (var reader = new StreamReader(@"root_directory.txt"))
            {
                var line = reader.ReadLine();
                RootDirectory = line;
                if (line == null)
                {
                    filled = false;
                }
            }

            if (!filled)
            {
                File.WriteAllText("root_directory.txt",
                    Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama");
            }


            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama"))
            {
                string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama";
                Directory.CreateDirectory(root);
                Directory.CreateDirectory(root + "\\Dalam Negeri");
                Directory.CreateDirectory(root + "\\Luar Negeri");
            }

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db"))
                File.Copy(@".\hubunganKerjaSama.db",
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db");

            databaseSource = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";
        }

        private void dalamNegeri_Button_MouseLeave(object sender, EventArgs e)
        {
            dalamNegeri_Button.BackColor = Color.Transparent;
            dalamNegeri_Button.Cursor = Cursors.Arrow;
        }

        private void dalamNegeri_Button_MouseEnter(object sender, EventArgs e)
        {
            dalamNegeri_Button.BackColor = Color.FromArgb(44, 62, 80);
            dalamNegeri_Button.Cursor = Cursors.Hand;
        }

        private void luarNegeri_Button_MouseEnter(object sender, EventArgs e)
        {
            luarNegeri_Button.BackColor = Color.FromArgb(44, 62, 80);
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
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            judulTahun.Text = "Kerjasama Dalam Negeri";
            activeMode = DocumentList.KERJASAMA_DALAM_NEGERI;

            loadTahun();
        }

        private void luarNegeri_Button_MouseClick(object sender, MouseEventArgs e)
        {
            highlight_luarNegeri.Visible = true;
            highlight_dalamNegeri.Visible = false;
            label2.ForeColor = Color.White;
            label1.ForeColor = Color.White;
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

            pan.BackColor = Color.FromArgb(150, 236, 240, 241);
            pan.Cursor = Cursors.Hand;
        }

        private void tahun_panel_MouseLeave(object sender, EventArgs e)
        {
            Panel pan = sender as Panel;
            pan.BackColor = Color.FromArgb(185, 245, 222, 179);
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
                            panel.BackColor = Color.FromArgb(185, 245, 222, 179);
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

        public void reload(object sender, EventArgs e) { Form1_Load(sender, e); }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Panel panelTahun in flowLayoutPanel1.Controls)
            {
                panelTahun.Size = new Size(flowLayoutPanel1.Width, 40);
            }
        }

        private void tahunBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFolder_Form form = new CreateFolder_Form(this);
            form.ShowDialog();
        }

        private void kerjasamaBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahKerjasama_Form form = new TambahKerjasama_Form();
            form.Show();
        }

        private void folderUtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rootFolder_Dialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Semua dokumen akan disimpan di folder: " + rootFolder_Dialog1.SelectedPath);
                File.WriteAllText("root_directory.txt", rootFolder_Dialog1.SelectedPath);
            }
        }
    }
}
