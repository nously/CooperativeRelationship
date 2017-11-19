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
                conn.Open();

                // insert new document
                int tahun = mulaiBerlaku_DateTimePicker.Value.Year;
                int pilihan = (dalamNegeri_RadioButton.Checked) ? 1 : 2;
                string tempattanggalttd = tempatTtd_TextBox.Text + tanggalTTD_DateTimePicker.Value.ToString("dd MMMM yyyy");
                string mulaiBerlaku = mulaiBerlaku_DateTimePicker.Value.ToString("dd MMMM yyyy");
                string berhentiBerlaku = berakhirPada_DateTimePicker.Value.ToString("dd MMMM yyyy");
                string filePath =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\"
                    + ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + judulFile_TextBox.Text + ".docx";
                
                string query = "insert into kerjasama values" +
                    "(null, '"+ judulFile_TextBox.Text +"'," +
                    ""+tahun+", "+pilihan+"," +
                    "'"+ institusi_TextBox.Text +"', '"+noPerjanjianFisip_TextBox.Text+"'," +
                    "'"+ noPerjanjianInstitusi_TextBox.Text +"', '"+tempattanggalttd+"'," +
                    "'"+mulaiBerlaku+"', '"+berhentiBerlaku+"'," +
                    "'"+fokusPerjanjianData+"', '"+ penandatanganFisip_TextBox.Text +"', '"+penandatanganInstitusi_TextBox.Text+"'" +
                    ", '"+ unitPengusul_TextBox.Text +"', '"+ unitPenggunaData +"', '"+narahubungFisipData["nama"]+"'," +
                    "'"+narahubungFisipData["handphone"]+"', '"+narahubungFisipData["email"]+"'," +
                    "'"+narahubungInstitusiData["nama"]+"', '"+narahubungInstitusiData["handphone"]+"'," +
                    "'"+narahubungInstitusiData["email"]+"', '"+narahubungFisipData["jabatan"]+"'," +
                    "'"+narahubungInstitusiData["jabatan"]+"', "+nilaiKerjasama_TextBox.Text+"," +
                    "'"+ filePath +"')";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    MessageBox.Show(command.ExecuteNonQuery() + "");


                // get latest id
                int latestID = 0;
                query = "select max(id) from kerjasama";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    latestID = int.Parse(command.ExecuteScalar().ToString());


                // update value
                filePath =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Hubungan Kerja Sama\\"
                    + ((pilihan == 1) ? "Dalam Negeri" : "Luar Negeri") + "\\" + latestID + "_"
                    + judulFile_TextBox.Text + "_.docx";

                query = "update kerjasama set filepath='"+filePath+"' where id=" + latestID;

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    MessageBox.Show(command.ExecuteNonQuery() + "");

                conn.Close();
            }
            DocumentHandler creatingProcess = new DocumentHandler();
            creatingProcess.Create();
        }


        // other functions
    }
}
