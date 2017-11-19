using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativeRelationship
{
    public partial class Narahubung : Form
    {
        TambahKerjasama_Form parent;

        public Narahubung(TambahKerjasama_Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.narahubungFisipData.Add("nama", fisipNama.Text);
            parent.narahubungFisipData.Add("handphone", fisipHandphone.Text);
            parent.narahubungFisipData.Add("email", fisipEmail.Text);
            parent.narahubungFisipData.Add("jabatan", fisipJabatan.Text);

            parent.narahubungInstitusiData.Add("nama", institusiNama.Text);
            parent.narahubungInstitusiData.Add("handphone", institusiHandphone.Text);
            parent.narahubungInstitusiData.Add("email", institusiEmail.Text);
            parent.narahubungInstitusiData.Add("jabatan", institusiJabatan.Text);
            Close();
        }

        private void fisipHandphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fisipEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                var email = new MailAddress((sender as TextBox).Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format email salah. Contoh email: xxx@yyy.zzz");
            }
            catch (ArgumentException ex)
            {}
        }
    }
}
