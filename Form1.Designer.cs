
namespace WindowsFormsApp9
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(16, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(177, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Hamburger";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(16, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Döner";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(16, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 36);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Pizza";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 358);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(367, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Mayonez";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(789, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 33);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Burger Sos";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(525, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 33);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Ketçap";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.Location = new System.Drawing.Point(674, 45);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(97, 33);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Turşu";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(28, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 205);
            this.button1.TabIndex = 8;
            this.button1.Text = "SiparişVer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox8.Location = new System.Drawing.Point(367, 106);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(101, 33);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Küçük";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox6.Location = new System.Drawing.Point(525, 106);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 33);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "Orta";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox5.Location = new System.Drawing.Point(674, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 33);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Büyük";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox7.Location = new System.Drawing.Point(674, 162);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(142, 33);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Bol Tavuk";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox9.Location = new System.Drawing.Point(525, 162);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(113, 33);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Sossuz";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Visible = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox10.Location = new System.Drawing.Point(367, 162);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(119, 33);
            this.checkBox10.TabIndex = 13;
            this.checkBox10.Text = "Bol Sos";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 662);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
    }
}

