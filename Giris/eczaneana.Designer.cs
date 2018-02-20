namespace Giris
{
    partial class eczaneana
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
            this.components = new System.ComponentModel.Container();
            this.ilacadi = new System.Windows.Forms.ComboBox();
            this.ilacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.girisDataSet = new Giris.girisDataSet();
            this.ilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adetil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stokdurum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ilacTableAdapter = new Giris.girisDataSetTableAdapters.ilacTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilacadi
            // 
            this.ilacadi.DataSource = this.ilacBindingSource1;
            this.ilacadi.DisplayMember = "ilac_adi";
            this.ilacadi.FormattingEnabled = true;
            this.ilacadi.Location = new System.Drawing.Point(152, 26);
            this.ilacadi.Name = "ilacadi";
            this.ilacadi.Size = new System.Drawing.Size(121, 21);
            this.ilacadi.TabIndex = 0;
            this.ilacadi.ValueMember = "ilac_adi";
            this.ilacadi.SelectedIndexChanged += new System.EventHandler(this.ilacadi_SelectedIndexChanged);
            // 
            // ilacBindingSource1
            // 
            this.ilacBindingSource1.DataMember = "ilac";
            this.ilacBindingSource1.DataSource = this.girisDataSet;
            // 
            // girisDataSet
            // 
            this.girisDataSet.DataSetName = "girisDataSet";
            this.girisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(152, 79);
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            this.fiyat.Size = new System.Drawing.Size(121, 20);
            this.fiyat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlaç Adı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sipariş Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adetil
            // 
            this.adetil.Location = new System.Drawing.Point(152, 105);
            this.adetil.Name = "adetil";
            this.adetil.Size = new System.Drawing.Size(121, 20);
            this.adetil.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Durumu";
            // 
            // stokdurum
            // 
            this.stokdurum.Location = new System.Drawing.Point(152, 53);
            this.stokdurum.Name = "stokdurum";
            this.stokdurum.ReadOnly = true;
            this.stokdurum.Size = new System.Drawing.Size(121, 20);
            this.stokdurum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ilacadi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.adetil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stokdurum);
            this.groupBox1.Controls.Add(this.fiyat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 235);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sipariş";
            // 
            // ilacTableAdapter
            // 
            this.ilacTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(62, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 41);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Not : Stok durumundan fazla sayıda verilen ürünler geçikmeli olarak teslim edilir" +
    ".";
            // 
            // eczaneana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "eczaneana";
            this.Text = "..::<|~Ecza Depo Otomasyonu~|>::..";
            this.Load += new System.EventHandler(this.eczaneana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ilacadi;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    
        private System.Windows.Forms.BindingSource ilacBindingSource;
      
        private System.Windows.Forms.TextBox adetil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokdurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private girisDataSet girisDataSet;
        private System.Windows.Forms.BindingSource ilacBindingSource1;
        private girisDataSetTableAdapters.ilacTableAdapter ilacTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}