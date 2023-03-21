namespace hesap_makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(12, 30);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(439, 38);
            this.txtSonuc.TabIndex = 0;
            this.txtSonuc.Text = "0";
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 51);
            this.button4.TabIndex = 1;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.optHesap);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 51);
            this.button5.TabIndex = 1;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 51);
            this.button6.TabIndex = 1;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(101, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 51);
            this.button7.TabIndex = 1;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(190, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 51);
            this.button8.TabIndex = 1;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(279, 131);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 51);
            this.button9.TabIndex = 1;
            this.button9.Text = "*";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.optHesap);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(368, 131);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(83, 51);
            this.button10.TabIndex = 1;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 188);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(83, 51);
            this.button11.TabIndex = 1;
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(101, 188);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(83, 51);
            this.button12.TabIndex = 1;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(190, 188);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(83, 51);
            this.button13.TabIndex = 1;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(279, 188);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(83, 51);
            this.button14.TabIndex = 1;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.optHesap);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(368, 188);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 108);
            this.button15.TabIndex = 1;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 245);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(172, 51);
            this.button16.TabIndex = 1;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.RakamOlay);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(190, 245);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(83, 51);
            this.button19.TabIndex = 1;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(279, 245);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(83, 51);
            this.button20.TabIndex = 1;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.optHesap);
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(12, 9);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 16);
            this.lbSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSonuc);
            this.Name = "Form1";
            this.Text = "hesap makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label lbSonuc;
    }
}

