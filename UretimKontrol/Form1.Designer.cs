namespace UretimKontrol
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
            this.urunGrid = new System.Windows.Forms.DataGridView();
            this.urunAdiLbl = new System.Windows.Forms.Label();
            this.urunAdiTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.urunTarihDate = new System.Windows.Forms.DateTimePicker();
            this.uretimSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uretimMakineId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uretimPersonelId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uretimEkleBtn = new System.Windows.Forms.Button();
            this.uretimUrunId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.uretimGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunKategoriTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.personelGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.makineGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.urunGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uretimGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makineGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // urunGrid
            // 
            this.urunGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunGrid.Location = new System.Drawing.Point(44, 81);
            this.urunGrid.Name = "urunGrid";
            this.urunGrid.Size = new System.Drawing.Size(328, 150);
            this.urunGrid.TabIndex = 0;
            // 
            // urunAdiLbl
            // 
            this.urunAdiLbl.AutoSize = true;
            this.urunAdiLbl.Location = new System.Drawing.Point(29, 68);
            this.urunAdiLbl.Name = "urunAdiLbl";
            this.urunAdiLbl.Size = new System.Drawing.Size(48, 13);
            this.urunAdiLbl.TabIndex = 1;
            this.urunAdiLbl.Text = "Ürün Adi";
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Location = new System.Drawing.Point(111, 65);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(173, 20);
            this.urunAdiTxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.urunTarihDate);
            this.groupBox1.Controls.Add(this.uretimSayisi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uretimMakineId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.uretimPersonelId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.uretimEkleBtn);
            this.groupBox1.Controls.Add(this.uretimUrunId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(753, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üretim Girişi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Üretim Tarih";
            // 
            // urunTarihDate
            // 
            this.urunTarihDate.Location = new System.Drawing.Point(111, 160);
            this.urunTarihDate.Name = "urunTarihDate";
            this.urunTarihDate.Size = new System.Drawing.Size(200, 20);
            this.urunTarihDate.TabIndex = 16;
            // 
            // uretimSayisi
            // 
            this.uretimSayisi.Location = new System.Drawing.Point(111, 129);
            this.uretimSayisi.Name = "uretimSayisi";
            this.uretimSayisi.Size = new System.Drawing.Size(200, 20);
            this.uretimSayisi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Sayısı";
            // 
            // uretimMakineId
            // 
            this.uretimMakineId.Location = new System.Drawing.Point(111, 93);
            this.uretimMakineId.Name = "uretimMakineId";
            this.uretimMakineId.Size = new System.Drawing.Size(200, 20);
            this.uretimMakineId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Makine Id";
            // 
            // uretimPersonelId
            // 
            this.uretimPersonelId.Location = new System.Drawing.Point(111, 61);
            this.uretimPersonelId.Name = "uretimPersonelId";
            this.uretimPersonelId.Size = new System.Drawing.Size(200, 20);
            this.uretimPersonelId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uretimEkleBtn
            // 
            this.uretimEkleBtn.Location = new System.Drawing.Point(160, 204);
            this.uretimEkleBtn.Name = "uretimEkleBtn";
            this.uretimEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.uretimEkleBtn.TabIndex = 9;
            this.uretimEkleBtn.Text = "Üretim Kaydı";
            this.uretimEkleBtn.UseVisualStyleBackColor = true;
            this.uretimEkleBtn.Click += new System.EventHandler(this.uretimEkleBtn_Click);
            // 
            // uretimUrunId
            // 
            this.uretimUrunId.Location = new System.Drawing.Point(111, 26);
            this.uretimUrunId.Name = "uretimUrunId";
            this.uretimUrunId.Size = new System.Drawing.Size(200, 20);
            this.uretimUrunId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Id";
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.Location = new System.Drawing.Point(111, 204);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(75, 23);
            this.urunEkleBtn.TabIndex = 4;
            this.urunEkleBtn.Text = "Ürün Kaydı";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // uretimGrid
            // 
            this.uretimGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uretimGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uretimGrid.Location = new System.Drawing.Point(397, 81);
            this.uretimGrid.Name = "uretimGrid";
            this.uretimGrid.Size = new System.Drawing.Size(708, 150);
            this.uretimGrid.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.urunKategoriTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.urunEkleBtn);
            this.groupBox2.Controls.Add(this.urunAdiTxt);
            this.groupBox2.Controls.Add(this.urunAdiLbl);
            this.groupBox2.Location = new System.Drawing.Point(397, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 264);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Girişi";
            // 
            // urunKategoriTxt
            // 
            this.urunKategoriTxt.Location = new System.Drawing.Point(111, 106);
            this.urunKategoriTxt.Name = "urunKategoriTxt";
            this.urunKategoriTxt.Size = new System.Drawing.Size(173, 20);
            this.urunKategoriTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ürün Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Üretim Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Personel Bilgileri";
            // 
            // personelGrid
            // 
            this.personelGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelGrid.Location = new System.Drawing.Point(44, 294);
            this.personelGrid.Name = "personelGrid";
            this.personelGrid.Size = new System.Drawing.Size(328, 150);
            this.personelGrid.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Makine Bilgileri";
            // 
            // makineGrid
            // 
            this.makineGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.makineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.makineGrid.Location = new System.Drawing.Point(44, 504);
            this.makineGrid.Name = "makineGrid";
            this.makineGrid.Size = new System.Drawing.Size(328, 150);
            this.makineGrid.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 683);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.makineGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.personelGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uretimGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uretimGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makineGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView urunGrid;
        private System.Windows.Forms.Label urunAdiLbl;
        private System.Windows.Forms.TextBox urunAdiTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uretimPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uretimEkleBtn;
        private System.Windows.Forms.TextBox uretimUrunId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button urunEkleBtn;
        private System.Windows.Forms.DataGridView uretimGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox urunKategoriTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uretimSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uretimMakineId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker urunTarihDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView personelGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView makineGrid;
    }
}

