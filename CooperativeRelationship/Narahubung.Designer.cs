namespace CooperativeRelationship
{
    partial class Narahubung
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fisipJabatan = new System.Windows.Forms.TextBox();
            this.fisipEmail = new System.Windows.Forms.TextBox();
            this.fisipHandphone = new System.Windows.Forms.TextBox();
            this.fisipNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.institusiJabatan = new System.Windows.Forms.TextBox();
            this.institusiEmail = new System.Windows.Forms.TextBox();
            this.institusiHandphone = new System.Windows.Forms.TextBox();
            this.institusiNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Detail Narahubung";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fisipJabatan);
            this.groupBox1.Controls.Add(this.fisipEmail);
            this.groupBox1.Controls.Add(this.fisipHandphone);
            this.groupBox1.Controls.Add(this.fisipNama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narahubung FISIP";
            // 
            // fisipJabatan
            // 
            this.fisipJabatan.Location = new System.Drawing.Point(123, 177);
            this.fisipJabatan.Name = "fisipJabatan";
            this.fisipJabatan.Size = new System.Drawing.Size(145, 20);
            this.fisipJabatan.TabIndex = 7;
            // 
            // fisipEmail
            // 
            this.fisipEmail.Location = new System.Drawing.Point(123, 135);
            this.fisipEmail.Name = "fisipEmail";
            this.fisipEmail.Size = new System.Drawing.Size(145, 20);
            this.fisipEmail.TabIndex = 6;
            this.fisipEmail.Leave += new System.EventHandler(this.fisipEmail_Leave);
            // 
            // fisipHandphone
            // 
            this.fisipHandphone.Location = new System.Drawing.Point(123, 88);
            this.fisipHandphone.MaxLength = 15;
            this.fisipHandphone.Name = "fisipHandphone";
            this.fisipHandphone.Size = new System.Drawing.Size(145, 20);
            this.fisipHandphone.TabIndex = 5;
            this.fisipHandphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fisipHandphone_KeyPress);
            // 
            // fisipNama
            // 
            this.fisipNama.Location = new System.Drawing.Point(123, 42);
            this.fisipNama.Name = "fisipNama";
            this.fisipNama.Size = new System.Drawing.Size(145, 20);
            this.fisipNama.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Jabatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Handphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.institusiJabatan);
            this.groupBox2.Controls.Add(this.institusiEmail);
            this.groupBox2.Controls.Add(this.institusiHandphone);
            this.groupBox2.Controls.Add(this.institusiNama);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(310, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narahubung Institusi Terkait";
            // 
            // institusiJabatan
            // 
            this.institusiJabatan.Location = new System.Drawing.Point(123, 177);
            this.institusiJabatan.Name = "institusiJabatan";
            this.institusiJabatan.Size = new System.Drawing.Size(145, 20);
            this.institusiJabatan.TabIndex = 7;
            // 
            // institusiEmail
            // 
            this.institusiEmail.Location = new System.Drawing.Point(123, 135);
            this.institusiEmail.Name = "institusiEmail";
            this.institusiEmail.Size = new System.Drawing.Size(145, 20);
            this.institusiEmail.TabIndex = 6;
            this.institusiEmail.Leave += new System.EventHandler(this.fisipEmail_Leave);
            // 
            // institusiHandphone
            // 
            this.institusiHandphone.Location = new System.Drawing.Point(123, 88);
            this.institusiHandphone.MaxLength = 15;
            this.institusiHandphone.Name = "institusiHandphone";
            this.institusiHandphone.Size = new System.Drawing.Size(145, 20);
            this.institusiHandphone.TabIndex = 5;
            this.institusiHandphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fisipHandphone_KeyPress);
            // 
            // institusiNama
            // 
            this.institusiNama.Location = new System.Drawing.Point(123, 42);
            this.institusiNama.Name = "institusiNama";
            this.institusiNama.Size = new System.Drawing.Size(145, 20);
            this.institusiNama.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Jabatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Alamat E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "No. Handphone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nama";
            // 
            // Narahubung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Narahubung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narahubung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fisipJabatan;
        private System.Windows.Forms.TextBox fisipEmail;
        private System.Windows.Forms.TextBox fisipHandphone;
        private System.Windows.Forms.TextBox fisipNama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox institusiJabatan;
        private System.Windows.Forms.TextBox institusiEmail;
        private System.Windows.Forms.TextBox institusiHandphone;
        private System.Windows.Forms.TextBox institusiNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}