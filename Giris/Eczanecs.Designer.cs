namespace Giris
{
    partial class Eczanecs
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
            this.EczaneGir = new System.Windows.Forms.Button();
            this.EczaneKul = new System.Windows.Forms.TextBox();
            this.EczaneSif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EczaneGir
            // 
            this.EczaneGir.Location = new System.Drawing.Point(89, 182);
            this.EczaneGir.Name = "EczaneGir";
            this.EczaneGir.Size = new System.Drawing.Size(144, 23);
            this.EczaneGir.TabIndex = 0;
            this.EczaneGir.Text = "Giriş";
            this.EczaneGir.UseVisualStyleBackColor = true;
            this.EczaneGir.Click += new System.EventHandler(this.EczaneGir_Click);
            // 
            // EczaneKul
            // 
            this.EczaneKul.Location = new System.Drawing.Point(74, 45);
            this.EczaneKul.Name = "EczaneKul";
            this.EczaneKul.Size = new System.Drawing.Size(100, 20);
            this.EczaneKul.TabIndex = 1;
            // 
            // EczaneSif
            // 
            this.EczaneSif.Location = new System.Drawing.Point(74, 87);
            this.EczaneSif.Name = "EczaneSif";
            this.EczaneSif.PasswordChar = '*';
            this.EczaneSif.Size = new System.Drawing.Size(100, 20);
            this.EczaneSif.TabIndex = 2;
            this.EczaneSif.TextChanged += new System.EventHandler(this.EczaneSif_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EczaneKul);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EczaneSif);
            this.groupBox1.Location = new System.Drawing.Point(59, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eczane Kullanıcı Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Eczanecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(319, 244);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EczaneGir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Eczanecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..::<|~Ecza Depo Otomasyonu~|>::..";
            this.Load += new System.EventHandler(this.Eczanecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EczaneGir;
        private System.Windows.Forms.TextBox EczaneKul;
        private System.Windows.Forms.TextBox EczaneSif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}