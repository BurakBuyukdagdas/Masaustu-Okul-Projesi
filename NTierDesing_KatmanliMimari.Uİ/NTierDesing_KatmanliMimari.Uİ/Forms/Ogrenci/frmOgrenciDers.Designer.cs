namespace NTierDesing_KatmanliMimari.Uİ.Forms.Ogrenci
{
    partial class frmOgrenciDers
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
            this.cmb_ogrenci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ders = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_notu = new System.Windows.Forms.TextBox();
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lst_ogrenci_ders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrencinin Aldığı Dersler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // cmb_ogrenci
            // 
            this.cmb_ogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ogrenci.FormattingEnabled = true;
            this.cmb_ogrenci.Location = new System.Drawing.Point(211, 141);
            this.cmb_ogrenci.Name = "cmb_ogrenci";
            this.cmb_ogrenci.Size = new System.Drawing.Size(185, 28);
            this.cmb_ogrenci.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders : ";
            // 
            // cmb_ders
            // 
            this.cmb_ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ders.FormattingEnabled = true;
            this.cmb_ders.Location = new System.Drawing.Point(211, 195);
            this.cmb_ders.Name = "cmb_ders";
            this.cmb_ders.Size = new System.Drawing.Size(185, 28);
            this.cmb_ders.TabIndex = 4;
            this.cmb_ders.SelectedIndexChanged += new System.EventHandler(this.cmb_ders_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Notu :";
            // 
            // txt_notu
            // 
            this.txt_notu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_notu.Location = new System.Drawing.Point(211, 251);
            this.txt_notu.Name = "txt_notu";
            this.txt_notu.Size = new System.Drawing.Size(185, 27);
            this.txt_notu.TabIndex = 6;
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.Red;
            this.btn_silme.Location = new System.Drawing.Point(25, 456);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(149, 51);
            this.btn_silme.TabIndex = 16;
            this.btn_silme.Text = "SİL";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Location = new System.Drawing.Point(25, 384);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(149, 54);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Yellow;
            this.btn_kaydet.Location = new System.Drawing.Point(25, 307);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(149, 56);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lst_ogrenci_ders
            // 
            this.lst_ogrenci_ders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lst_ogrenci_ders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lst_ogrenci_ders.FullRowSelect = true;
            this.lst_ogrenci_ders.GridLines = true;
            this.lst_ogrenci_ders.HideSelection = false;
            this.lst_ogrenci_ders.Location = new System.Drawing.Point(402, 141);
            this.lst_ogrenci_ders.Name = "lst_ogrenci_ders";
            this.lst_ogrenci_ders.Size = new System.Drawing.Size(572, 366);
            this.lst_ogrenci_ders.TabIndex = 17;
            this.lst_ogrenci_ders.UseCompatibleStateImageBehavior = false;
            this.lst_ogrenci_ders.View = System.Windows.Forms.View.Details;
            this.lst_ogrenci_ders.Click += new System.EventHandler(this.lst_ogrenci_ders_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğrenci ID";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Adı";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ders Adı";
            this.columnHeader3.Width = 253;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(425, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ara :";
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(521, 96);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(185, 27);
            this.txt_ara.TabIndex = 19;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // frmOgrenciDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(986, 532);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_ogrenci_ders);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_notu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_ogrenci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciDers";
            this.Text = "frmOgrenciDers";
            this.Load += new System.EventHandler(this.frmOgrenciDers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_ogrenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_notu;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListView lst_ogrenci_ders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}