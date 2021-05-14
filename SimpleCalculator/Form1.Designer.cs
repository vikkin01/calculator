
namespace SimpleCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bMC = new System.Windows.Forms.Button();
            this.bMR = new System.Windows.Forms.Button();
            this.bMp = new System.Windows.Forms.Button();
            this.bMmin = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b16 = new System.Windows.Forms.Button();
            this.b17 = new System.Windows.Forms.Button();
            this.b18 = new System.Windows.Forms.Button();
            this.b19 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b23 = new System.Windows.Forms.Button();
            this.b24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 66);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bMC
            // 
            this.bMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMC.Location = new System.Drawing.Point(12, 93);
            this.bMC.Name = "bMC";
            this.bMC.Size = new System.Drawing.Size(94, 63);
            this.bMC.TabIndex = 1;
            this.bMC.Text = "MC";
            this.bMC.UseVisualStyleBackColor = true;
            this.bMC.Click += new System.EventHandler(this.b1_Click);
            // 
            // bMR
            // 
            this.bMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMR.Location = new System.Drawing.Point(112, 93);
            this.bMR.Name = "bMR";
            this.bMR.Size = new System.Drawing.Size(94, 63);
            this.bMR.TabIndex = 2;
            this.bMR.Text = "MR";
            this.bMR.UseVisualStyleBackColor = true;
            this.bMR.Click += new System.EventHandler(this.button2_Click);
            // 
            // bMp
            // 
            this.bMp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMp.Location = new System.Drawing.Point(212, 93);
            this.bMp.Name = "bMp";
            this.bMp.Size = new System.Drawing.Size(94, 63);
            this.bMp.TabIndex = 3;
            this.bMp.Text = "M+";
            this.bMp.UseVisualStyleBackColor = true;
            this.bMp.Click += new System.EventHandler(this.bMp_Click);
            // 
            // bMmin
            // 
            this.bMmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMmin.Location = new System.Drawing.Point(312, 93);
            this.bMmin.Name = "bMmin";
            this.bMmin.Size = new System.Drawing.Size(94, 63);
            this.bMmin.TabIndex = 4;
            this.bMmin.Text = "M-";
            this.bMmin.UseVisualStyleBackColor = true;
            this.bMmin.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.Location = new System.Drawing.Point(12, 162);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(94, 63);
            this.b5.TabIndex = 5;
            this.b5.Text = "√x";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.Location = new System.Drawing.Point(112, 162);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(94, 63);
            this.b6.TabIndex = 6;
            this.b6.Text = "%";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bCE
            // 
            this.bCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCE.Location = new System.Drawing.Point(212, 162);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(94, 63);
            this.bCE.TabIndex = 7;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.b7_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bC.Location = new System.Drawing.Point(312, 162);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(94, 63);
            this.bC.TabIndex = 8;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.Location = new System.Drawing.Point(12, 231);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(94, 63);
            this.b9.TabIndex = 9;
            this.b9.Text = "7";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b10
            // 
            this.b10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b10.Location = new System.Drawing.Point(112, 231);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(94, 63);
            this.b10.TabIndex = 10;
            this.b10.Text = "8";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b11
            // 
            this.b11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b11.Location = new System.Drawing.Point(212, 231);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(94, 63);
            this.b11.TabIndex = 11;
            this.b11.Text = "9";
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b12
            // 
            this.b12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b12.Location = new System.Drawing.Point(312, 231);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(94, 63);
            this.b12.TabIndex = 12;
            this.b12.Text = "/";
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(12, 300);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 63);
            this.button13.TabIndex = 13;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // b14
            // 
            this.b14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b14.Location = new System.Drawing.Point(112, 300);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(94, 63);
            this.b14.TabIndex = 14;
            this.b14.Text = "5";
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.b14_Click);
            // 
            // b15
            // 
            this.b15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b15.Location = new System.Drawing.Point(212, 300);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(94, 63);
            this.b15.TabIndex = 15;
            this.b15.Text = "6";
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.b15_Click);
            // 
            // b16
            // 
            this.b16.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b16.Location = new System.Drawing.Point(312, 300);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(94, 63);
            this.b16.TabIndex = 16;
            this.b16.Text = "x";
            this.b16.UseVisualStyleBackColor = true;
            this.b16.Click += new System.EventHandler(this.b16_Click);
            // 
            // b17
            // 
            this.b17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b17.Location = new System.Drawing.Point(12, 369);
            this.b17.Name = "b17";
            this.b17.Size = new System.Drawing.Size(94, 63);
            this.b17.TabIndex = 17;
            this.b17.Text = "1";
            this.b17.UseVisualStyleBackColor = true;
            this.b17.Click += new System.EventHandler(this.b17_Click);
            // 
            // b18
            // 
            this.b18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b18.Location = new System.Drawing.Point(112, 369);
            this.b18.Name = "b18";
            this.b18.Size = new System.Drawing.Size(94, 63);
            this.b18.TabIndex = 18;
            this.b18.Text = "2";
            this.b18.UseVisualStyleBackColor = true;
            this.b18.Click += new System.EventHandler(this.b18_Click);
            // 
            // b19
            // 
            this.b19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b19.Location = new System.Drawing.Point(212, 369);
            this.b19.Name = "b19";
            this.b19.Size = new System.Drawing.Size(94, 63);
            this.b19.TabIndex = 19;
            this.b19.Text = "3";
            this.b19.UseVisualStyleBackColor = true;
            this.b19.Click += new System.EventHandler(this.b19_Click);
            // 
            // b20
            // 
            this.b20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b20.Location = new System.Drawing.Point(312, 369);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(94, 63);
            this.b20.TabIndex = 20;
            this.b20.Text = "-";
            this.b20.UseVisualStyleBackColor = true;
            this.b20.Click += new System.EventHandler(this.b20_Click);
            // 
            // b21
            // 
            this.b21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b21.Location = new System.Drawing.Point(12, 438);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(94, 63);
            this.b21.TabIndex = 21;
            this.b21.Text = ",";
            this.b21.UseVisualStyleBackColor = true;
            this.b21.Click += new System.EventHandler(this.b21_Click);
            // 
            // b22
            // 
            this.b22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b22.Location = new System.Drawing.Point(112, 438);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(94, 63);
            this.b22.TabIndex = 22;
            this.b22.Text = "0";
            this.b22.UseVisualStyleBackColor = true;
            this.b22.Click += new System.EventHandler(this.b22_Click);
            // 
            // b23
            // 
            this.b23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b23.Location = new System.Drawing.Point(212, 438);
            this.b23.Name = "b23";
            this.b23.Size = new System.Drawing.Size(94, 63);
            this.b23.TabIndex = 23;
            this.b23.Text = "=";
            this.b23.UseVisualStyleBackColor = true;
            this.b23.Click += new System.EventHandler(this.b23_Click);
            // 
            // b24
            // 
            this.b24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b24.Location = new System.Drawing.Point(312, 438);
            this.b24.Name = "b24";
            this.b24.Size = new System.Drawing.Size(94, 63);
            this.b24.TabIndex = 24;
            this.b24.Text = "+";
            this.b24.UseVisualStyleBackColor = true;
            this.b24.Click += new System.EventHandler(this.b24_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 522);
            this.Controls.Add(this.b24);
            this.Controls.Add(this.b23);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b19);
            this.Controls.Add(this.b18);
            this.Controls.Add(this.b17);
            this.Controls.Add(this.b16);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bMmin);
            this.Controls.Add(this.bMp);
            this.Controls.Add(this.bMR);
            this.Controls.Add(this.bMC);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bMC;
        private System.Windows.Forms.Button bMR;
        private System.Windows.Forms.Button bMp;
        private System.Windows.Forms.Button bMmin;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button b14;
        private System.Windows.Forms.Button b15;
        private System.Windows.Forms.Button b16;
        private System.Windows.Forms.Button b17;
        private System.Windows.Forms.Button b18;
        private System.Windows.Forms.Button b19;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b23;
        private System.Windows.Forms.Button b24;
    }
}

