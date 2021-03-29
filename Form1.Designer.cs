namespace bilgicns
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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.buttonbas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbldogru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonA.Location = new System.Drawing.Point(187, 291);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(185, 65);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonb
            // 
            this.buttonb.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonb.Location = new System.Drawing.Point(408, 291);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(185, 65);
            this.buttonb.TabIndex = 1;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = false;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttonc
            // 
            this.buttonc.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonc.Location = new System.Drawing.Point(187, 380);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(185, 65);
            this.buttonc.TabIndex = 2;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = false;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // buttond
            // 
            this.buttond.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttond.Location = new System.Drawing.Point(411, 380);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(182, 65);
            this.buttond.TabIndex = 3;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = false;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // buttonbas
            // 
            this.buttonbas.BackColor = System.Drawing.Color.Pink;
            this.buttonbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonbas.Location = new System.Drawing.Point(672, 313);
            this.buttonbas.Name = "buttonbas";
            this.buttonbas.Size = new System.Drawing.Size(166, 85);
            this.buttonbas.TabIndex = 4;
            this.buttonbas.Text = "BAŞLA";
            this.buttonbas.UseVisualStyleBackColor = false;
            this.buttonbas.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(159, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 219);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "        BİLGİ YARIŞMAMIZA          HOŞ GELDİNİZ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Location = new System.Drawing.Point(744, 98);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(44, 13);
            this.lbldogru.TabIndex = 6;
            this.lbldogru.Text = "lbldogru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(920, 539);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonbas);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttonA);
            this.Name = "Form1";
            this.Text = "CNS9CNS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Button buttonbas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbldogru;
    }
}

