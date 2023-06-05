namespace NTierDesing_KatmanliMimari.Uİ.Forms.Ders
{
    partial class frmDersCRUD
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
            this.lst_dersler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_silme = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kredi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dersadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lst_dersler
            // 
            this.lst_dersler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lst_dersler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lst_dersler.FullRowSelect = true;
            this.lst_dersler.GridLines = true;
            this.lst_dersler.HideSelection = false;
            this.lst_dersler.Location = new System.Drawing.Point(259, 229);
            this.lst_dersler.Name = "lst_dersler";
            this.lst_dersler.Size = new System.Drawing.Size(424, 191);
            this.lst_dersler.TabIndex = 14;
            this.lst_dersler.UseCompatibleStateImageBehavior = false;
            this.lst_dersler.View = System.Windows.Forms.View.Details;
            this.lst_dersler.Click += new System.EventHandler(this.lst_dersler_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DERSID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DERSADİ";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KREDİ";
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.Red;
            this.btn_silme.Location = new System.Drawing.Point(33, 363);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(175, 57);
            this.btn_silme.TabIndex = 13;
            this.btn_silme.Text = "SİL";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click_1);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Location = new System.Drawing.Point(33, 297);
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
            this.btn_kaydet.Location = new System.Drawing.Point(33, 229);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(175, 62);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DERS ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "DERS CRUD FORMU";
            // 
            // txt_kredi
            // 
            this.txt_kredi.Location = new System.Drawing.Point(200, 119);
            this.txt_kredi.MaxLength = 50;
            this.txt_kredi.Name = "txt_kredi";
            this.txt_kredi.Size = new System.Drawing.Size(248, 20);
            this.txt_kredi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kredi notu";
            // 
            // txt_dersadi
            // 
            this.txt_dersadi.Location = new System.Drawing.Point(200, 77);
            this.txt_dersadi.Name = "txt_dersadi";
            this.txt_dersadi.Size = new System.Drawing.Size(248, 20);
            this.txt_dersadi.TabIndex = 17;
            this.txt_dersadi.TextChanged += new System.EventHandler(this.txt_dersadi_TextChanged_1);
            // 
            // frmDersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.txt_dersadi);
            this.Controls.Add(this.txt_kredi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_dersler);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDersCRUD";
            this.Text = "frmDersCRUD";
            this.Load += new System.EventHandler(this.frmDersCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_dersler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txt_kredi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dersadi;
    }
}