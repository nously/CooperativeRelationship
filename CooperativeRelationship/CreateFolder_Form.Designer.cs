namespace CooperativeRelationship
{
    partial class CreateFolder_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tahun = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dalam = new System.Windows.Forms.RadioButton();
            this.luar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tambah Tahun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tahun";
            // 
            // tahun
            // 
            this.tahun.Location = new System.Drawing.Point(100, 39);
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(185, 20);
            this.tahun.TabIndex = 2;
            this.tahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tahun_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.luar);
            this.panel1.Controls.Add(this.dalam);
            this.panel1.Location = new System.Drawing.Point(101, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 23);
            this.panel1.TabIndex = 3;
            // 
            // dalam
            // 
            this.dalam.AutoSize = true;
            this.dalam.Checked = true;
            this.dalam.Location = new System.Drawing.Point(3, 3);
            this.dalam.Name = "dalam";
            this.dalam.Size = new System.Drawing.Size(89, 17);
            this.dalam.TabIndex = 0;
            this.dalam.TabStop = true;
            this.dalam.Text = "Dalam Negeri";
            this.dalam.UseVisualStyleBackColor = true;
            // 
            // luar
            // 
            this.luar.AutoSize = true;
            this.luar.Location = new System.Drawing.Point(95, 3);
            this.luar.Name = "luar";
            this.luar.Size = new System.Drawing.Size(80, 17);
            this.luar.TabIndex = 1;
            this.luar.TabStop = true;
            this.luar.Text = "Luar Negeri";
            this.luar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jenis Perjanjian";
            // 
            // CreateFolder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tahun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CreateFolder_Form";
            this.Text = "CreateFolder_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tahun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton luar;
        private System.Windows.Forms.RadioButton dalam;
        private System.Windows.Forms.Label label2;
    }
}