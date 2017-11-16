using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PopupControl;

namespace CooperativeRelationship
{
    public partial class ComplexPopup : UserControl
    {

        public ComplexPopup()
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = new Size(1000, 1000);
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void WndProc(ref Message m)
        {
            if ((Parent as Popup).ProcessResizing(ref m))
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ComplexPopup
            // 
            this.Name = "ComplexPopup";
            this.ResumeLayout(false);

        }
    }
}
