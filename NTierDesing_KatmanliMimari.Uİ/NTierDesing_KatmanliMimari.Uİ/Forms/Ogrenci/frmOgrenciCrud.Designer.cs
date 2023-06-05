namespace NTierDesing_KatmanliMimari.Uİ.Forms.Ogrenci
{
    partial class frmOgrenciCrud
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
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_ogrenciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Ogrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_ogrencisoyadi = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.Red;
            this.btn_silme.Location = new System.Drawing.Point(830, 315);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(175, 57);
            this.btn_silme.TabIndex = 13;
            this.btn_silme.Text = "SİL";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Location = new System.Drawing.Point(618, 312);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(175, 60);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Yellow;
            this.btn_kaydet.Location = new System.Drawing.Point(401, 310);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(175, 62);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_ogrenciadi
            // 
            this.txt_ogrenciadi.Location = new System.Drawing.Point(157, 78);
            this.txt_ogrenciadi.MaxLength = 50;
            this.txt_ogrenciadi.Name = "txt_ogrenciadi";
            this.txt_ogrenciadi.Size = new System.Drawing.Size(189, 20);
            this.txt_ogrenciadi.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÖĞRENCİ ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "ÖĞRENCİ CRUD FORMU";
            // 
            // lst_Ogrenciler
            // 
            this.lst_Ogrenciler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lst_Ogrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lst_Ogrenciler.FullRowSelect = true;
            this.lst_Ogrenciler.GridLines = true;
            this.lst_Ogrenciler.HideSelection = false;
            this.lst_Ogrenciler.Location = new System.Drawing.Point(401, 78);
            this.lst_Ogrenciler.Name = "lst_Ogrenciler";
            this.lst_Ogrenciler.Size = new System.Drawing.Size(634, 203);
            this.lst_Ogrenciler.TabIndex = 14;
            this.lst_Ogrenciler.UseCompatibleStateImageBehavior = false;
            this.lst_Ogrenciler.View = System.Windows.Forms.View.Details;
            this.lst_Ogrenciler.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ÖğrenciİD";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ÖğrenciAdı";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Şehir";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 197;
            // 
            // txt_ogrencisoyadi
            // 
            this.txt_ogrencisoyadi.Location = new System.Drawing.Point(157, 113);
            this.txt_ogrencisoyadi.MaxLength = 50;
            this.txt_ogrencisoyadi.Name = "txt_ogrencisoyadi";
            this.txt_ogrencisoyadi.Size = new System.Drawing.Size(189, 20);
            this.txt_ogrencisoyadi.TabIndex = 16;
            this.txt_ogrencisoyadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.Location = new System.Drawing.Point(1, 113);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(150, 20);
            this.lbl5.TabIndex = 15;
            this.lbl5.Text = "ÖĞRENCİ SOYADI";
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.AutoSize = true;
            this.lbl_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sehir.Location = new System.Drawing.Point(1, 147);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(46, 20);
            this.lbl_sehir.TabIndex = 17;
            this.lbl_sehir.Text = "Şehir";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Location = new System.Drawing.Point(157, 147);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(189, 21);
            this.cmb_sehir.TabIndex = 18;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(157, 183);
            this.txt_telefon.MaxLength = 20;
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(189, 20);
            this.txt_telefon.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "TELEFON";
            // 
            // frmOgrenciCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 415);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_sehir);
            this.Controls.Add(this.lbl_sehir);
            this.Controls.Add(this.txt_ogrencisoyadi);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lst_Ogrenciler);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_ogrenciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciCrud";
            this.Text = "frmOgrenciCrud";
            this.Load += new System.EventHandler(this.frmOgrenciCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_ogrenciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst_Ogrenciler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txt_ogrencisoyadi;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label3;
    }
}