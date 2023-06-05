namespace NTierDesing_KatmanliMimari.Uİ.Forms.Sehir
{
    partial class frmSehirCRUD
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
            this.txt_sehiradi = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_silme = new System.Windows.Forms.Button();
            this.lst_sehirler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞEHİR CRUD FORMU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞEHİR ADI";
            // 
            // txt_sehiradi
            // 
            this.txt_sehiradi.Location = new System.Drawing.Point(174, 68);
            this.txt_sehiradi.Name = "txt_sehiradi";
            this.txt_sehiradi.Size = new System.Drawing.Size(248, 20);
            this.txt_sehiradi.TabIndex = 3;
            this.txt_sehiradi.TextChanged += new System.EventHandler(this.txt_sehiradi_TextChanged);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Yellow;
            this.btn_kaydet.Location = new System.Drawing.Point(69, 131);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(175, 62);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guncelle.Location = new System.Drawing.Point(69, 199);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(175, 60);
            this.btn_guncelle.TabIndex = 5;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_silme
            // 
            this.btn_silme.BackColor = System.Drawing.Color.Red;
            this.btn_silme.Location = new System.Drawing.Point(69, 265);
            this.btn_silme.Name = "btn_silme";
            this.btn_silme.Size = new System.Drawing.Size(175, 57);
            this.btn_silme.TabIndex = 6;
            this.btn_silme.Text = "SİL";
            this.btn_silme.UseVisualStyleBackColor = false;
            this.btn_silme.Click += new System.EventHandler(this.btn_silme_Click);
            // 
            // lst_sehirler
            // 
            this.lst_sehirler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lst_sehirler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_sehirler.FullRowSelect = true;
            this.lst_sehirler.GridLines = true;
            this.lst_sehirler.HideSelection = false;
            this.lst_sehirler.Location = new System.Drawing.Point(339, 131);
            this.lst_sehirler.Name = "lst_sehirler";
            this.lst_sehirler.Size = new System.Drawing.Size(363, 191);
            this.lst_sehirler.TabIndex = 7;
            this.lst_sehirler.UseCompatibleStateImageBehavior = false;
            this.lst_sehirler.View = System.Windows.Forms.View.Details;
            this.lst_sehirler.Click += new System.EventHandler(this.lst_sehirler_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SEHİRİD";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ŞEHİRADI";
            this.columnHeader2.Width = 299;
            // 
            // frmSehirCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_sehirler);
            this.Controls.Add(this.btn_silme);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sehiradi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSehirCRUD";
            this.Text = "frmSehirCRUD";
            this.Load += new System.EventHandler(this.frmSehirCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sehiradi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_silme;
        private System.Windows.Forms.ListView lst_sehirler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}