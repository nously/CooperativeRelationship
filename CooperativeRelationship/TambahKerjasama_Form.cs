using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeRelationship
{
    public partial class TambahKerjasama_Form : Form
    {
        int y;
        public string fokusPerjanjianData = "";
        public string unitPenggunaData = "";
        public Dictionary<string, string> narahubungFisipData;
        public Dictionary<string, string> narahubungInstitusiData;
        private string databaseSource;

        public TambahKerjasama_Form()
        {
            InitializeComponent();
            y = judul.Location.Y;
            MinimumSize = Size;
            narahubungFisipData = new Dictionary<string, string>();
            narahubungInstitusiData = new Dictionary<string, string>();
            databaseSource =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";
        }

        // event handlers
        private void TambahKerjasama_Form_SizeChanged(object sender, EventArgs e)
        {
            judul.Location = new Point(
                this.Width / 2 - judul.Width / 2,
                y
            );
        }

        private void editFokusPerjanjian_Button_Click(object sender, EventArgs e)
        {
            FokusPerjanjian fokusPerjanjian = new FokusPerjanjian(this);
            fokusPerjanjian.ShowDialog();
        }

        private void editUnitPengguna_Button_Click(object sender, EventArgs e)
        {
            UnitPengguna unitPengguna = new UnitPengguna(this);
            unitPengguna.ShowDialog();
        }

        private void editNarahubung_Button_Click(object sender, EventArgs e)
        {
            Narahubung narahubung = new Narahubung(this);
            narahubung.ShowDialog();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
            {
                string query = "insert into kerjasama values" +
                    "(null, 'judul'," +
                    "'tahun', 'jenisKerjasama'," +
                    "'institusi', 'nomorPerjanjianFisip'," +
                    "'nomorPerjanjianInstitus', 'tempattanggalttd'," +
                    "'mulai berlaku', 'berhenti berlaku'," +
                    "'fokus perjanjian', 'nama narahubung fisip'," +
                    "'handphone narahubung fisip', 'email narahubung fisip'," +
                    "'nama narahubung institusi', 'handphone narahubung institusi'," +
                    "'email narahubung institusi', 'jabatan narahubung fisip'," +
                    "'jabatan narahubung institusi', nilai kerjasama," +
                    "'filePath')";
            }
        }
        // other functions
    }
}
