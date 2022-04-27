namespace WİnOrnek1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DiziOlustur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_SayiUret = new System.Windows.Forms.Button();
            this.btn_RastgeleSayi = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btn_Liste = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DiziOlustur
            // 
            this.btn_DiziOlustur.Location = new System.Drawing.Point(39, 172);
            this.btn_DiziOlustur.Name = "btn_DiziOlustur";
            this.btn_DiziOlustur.Size = new System.Drawing.Size(133, 41);
            this.btn_DiziOlustur.TabIndex = 0;
            this.btn_DiziOlustur.Text = "Dizi oluştur";
            this.btn_DiziOlustur.UseVisualStyleBackColor = true;
            this.btn_DiziOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 154);
            this.listBox1.TabIndex = 1;
            // 
            // btn_SayiUret
            // 
            this.btn_SayiUret.Location = new System.Drawing.Point(208, 172);
            this.btn_SayiUret.Name = "btn_SayiUret";
            this.btn_SayiUret.Size = new System.Drawing.Size(103, 41);
            this.btn_SayiUret.TabIndex = 2;
            this.btn_SayiUret.Text = "1-10 arasında ki sayılar";
            this.btn_SayiUret.UseVisualStyleBackColor = true;
            this.btn_SayiUret.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_RastgeleSayi
            // 
            this.btn_RastgeleSayi.Location = new System.Drawing.Point(317, 172);
            this.btn_RastgeleSayi.Name = "btn_RastgeleSayi";
            this.btn_RastgeleSayi.Size = new System.Drawing.Size(137, 41);
            this.btn_RastgeleSayi.TabIndex = 3;
            this.btn_RastgeleSayi.Text = "rasgele 50 sayı";
            this.btn_RastgeleSayi.UseVisualStyleBackColor = true;
            this.btn_RastgeleSayi.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(178, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(184, 154);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "eleman sayısı";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(597, 55);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(116, 23);
            this.txtSayi.TabIndex = 6;
            // 
            // btn_Liste
            // 
            this.btn_Liste.Location = new System.Drawing.Point(610, 84);
            this.btn_Liste.Name = "btn_Liste";
            this.btn_Liste.Size = new System.Drawing.Size(103, 23);
            this.btn_Liste.TabIndex = 7;
            this.btn_Liste.Text = "Liste Oluştur";
            this.btn_Liste.UseVisualStyleBackColor = true;
            this.btn_Liste.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(368, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(118, 154);
            this.listBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btn_Liste);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_RastgeleSayi);
            this.Controls.Add(this.btn_SayiUret);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_DiziOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DiziOlustur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_SayiUret;
        private System.Windows.Forms.Button btn_RastgeleSayi;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btn_Liste;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button1;
    }
}
