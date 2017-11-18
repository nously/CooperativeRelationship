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
    public partial class FokusPerjanjian : Form
    {
        private string databaseSource;
        private TambahKerjasama_Form parent;
        private List<ComboBox> comboBoxes;

        public FokusPerjanjian(TambahKerjasama_Form parent)
        {
            InitializeComponent();
            databaseSource =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    "\\Hubungan Kerja Sama\\hubunganKerjaSama.db";

            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();

            label.Parent = panel;
            comboBox.Parent = panel;
            panel.Parent = fokusContainer_FlowLayout;

            label.AutoSize = true;
            label.Location = new Point(17, 7);
            label.Text = "Fokus Perjanjian " + fokusContainer_FlowLayout.Controls.Count;

            comboBox.Location = new Point(149, 3);
            comboBox.Size = new Size(406, 21);

            populateCombobox(comboBox);

            panel.Size = new Size(573, 27);
            panel.Margin = new Padding(1,1,1,1);

            comboBoxes.Add(comboBox);
        }

        private void FokusPerjanjian_Load(object sender, EventArgs e)
        {
            comboBoxes = new List<ComboBox>();

            populateCombobox(comboBox1);
            populateCombobox(comboBox2);
            populateCombobox(comboBox3);

            comboBoxes.Add(comboBox1);
            comboBoxes.Add(comboBox2);
            comboBoxes.Add(comboBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ComboBox comboBox in comboBoxes)
            {
                parent.fokusPerjanjianData += comboBox.Text + "|";
            }

            Close();
        }

        // other functions
        private void populateCombobox(ComboBox comboBox)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=" + databaseSource))
            {
                string query = "SELECT * FROM fokus_perjanjian";
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            comboBox.Items.Add(result[1] + "");
                        }
                    }
                }

                conn.Close();
            }
        }
    }
}
