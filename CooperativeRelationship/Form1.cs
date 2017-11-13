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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Black;
        }

        private void luarNegeri_Button_MouseClick(object sender, MouseEventArgs e)
        {
            highlight_luarNegeri.Visible = true;
            highlight_dalamNegeri.Visible = false;
            label2.ForeColor = Color.Red;
            label1.ForeColor = Color.Black;
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
    }
}
