namespace hastane_v1_777
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKronikYok = new System.Windows.Forms.RadioButton();
            this.rbKronikvar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "soyadınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "doğum tarihi:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(181, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKronikYok);
            this.groupBox1.Controls.Add(this.rbKronikvar);
            this.groupBox1.Location = new System.Drawing.Point(28, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbKronikYok
            // 
            this.rbKronikYok.AutoSize = true;
            this.rbKronikYok.Location = new System.Drawing.Point(7, 59);
            this.rbKronikYok.Name = "rbKronikYok";
            this.rbKronikYok.Size = new System.Drawing.Size(118, 17);
            this.rbKronikYok.TabIndex = 1;
            this.rbKronikYok.TabStop = true;
            this.rbKronikYok.Text = "kronik hastalığı yok.";
            this.rbKronikYok.UseVisualStyleBackColor = true;
            // 
            // rbKronikvar
            // 
            this.rbKronikvar.AutoSize = true;
            this.rbKronikvar.Location = new System.Drawing.Point(7, 20);
            this.rbKronikvar.Name = "rbKronikvar";
            this.rbKronikvar.Size = new System.Drawing.Size(116, 17);
            this.rbKronikvar.TabIndex = 0;
            this.rbKronikvar.TabStop = true;
            this.rbKronikvar.Text = "kronik hastalığı var.";
            this.rbKronikvar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbKan
            // 
            this.cmbKan.FormattingEnabled = true;
            this.cmbKan.Items.AddRange(new object[] {
            "0Rh(-)",
            "0Rh(+)",
            "ARh(-)",
            "ARh(+)",
            "BRh(-)",
            "BRh(+)",
            "ABRh(-)",
            "ABRh(+)"});
            this.cmbKan.Location = new System.Drawing.Point(272, 242);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(121, 21);
            this.cmbKan.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 435);
            this.Controls.Add(this.cmbKan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKronikYok;
        private System.Windows.Forms.RadioButton rbKronikvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbKan;
    }
}

