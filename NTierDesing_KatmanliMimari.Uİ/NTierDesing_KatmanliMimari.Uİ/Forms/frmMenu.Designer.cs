namespace NTierDesing_KatmanliMimari.Uİ.Forms
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şEHİRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şEHİRCRUDFORMUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERSCRUDFORMUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciCrudFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrencininAldığıDerslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şEHİRToolStripMenuItem,
            this.dERSToolStripMenuItem,
            this.öĞRENCİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şEHİRToolStripMenuItem
            // 
            this.şEHİRToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.şEHİRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şEHİRCRUDFORMUToolStripMenuItem});
            this.şEHİRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.şEHİRToolStripMenuItem.Name = "şEHİRToolStripMenuItem";
            this.şEHİRToolStripMenuItem.Size = new System.Drawing.Size(99, 41);
            this.şEHİRToolStripMenuItem.Text = "ŞEHİR";
            // 
            // şEHİRCRUDFORMUToolStripMenuItem
            // 
            this.şEHİRCRUDFORMUToolStripMenuItem.Name = "şEHİRCRUDFORMUToolStripMenuItem";
            this.şEHİRCRUDFORMUToolStripMenuItem.Size = new System.Drawing.Size(341, 42);
            this.şEHİRCRUDFORMUToolStripMenuItem.Text = "ŞEHİR CRUD FORMU";
            this.şEHİRCRUDFORMUToolStripMenuItem.Click += new System.EventHandler(this.şEHİRCRUDFORMUToolStripMenuItem_Click);
            // 
            // dERSToolStripMenuItem
            // 
            this.dERSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dERSCRUDFORMUToolStripMenuItem});
            this.dERSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.dERSToolStripMenuItem.Name = "dERSToolStripMenuItem";
            this.dERSToolStripMenuItem.Size = new System.Drawing.Size(92, 41);
            this.dERSToolStripMenuItem.Text = "DERS";
            // 
            // dERSCRUDFORMUToolStripMenuItem
            // 
            this.dERSCRUDFORMUToolStripMenuItem.Name = "dERSCRUDFORMUToolStripMenuItem";
            this.dERSCRUDFORMUToolStripMenuItem.Size = new System.Drawing.Size(334, 42);
            this.dERSCRUDFORMUToolStripMenuItem.Text = "DERS CRUD FORMU";
            this.dERSCRUDFORMUToolStripMenuItem.Click += new System.EventHandler(this.dERSCRUDFORMUToolStripMenuItem_Click);
            // 
            // öĞRENCİToolStripMenuItem
            // 
            this.öĞRENCİToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.öĞRENCİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciCrudFormuToolStripMenuItem,
            this.öğrencininAldığıDerslerToolStripMenuItem});
            this.öĞRENCİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            this.öĞRENCİToolStripMenuItem.Size = new System.Drawing.Size(142, 41);
            this.öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            // 
            // öğrenciCrudFormuToolStripMenuItem
            // 
            this.öğrenciCrudFormuToolStripMenuItem.Name = "öğrenciCrudFormuToolStripMenuItem";
            this.öğrenciCrudFormuToolStripMenuItem.Size = new System.Drawing.Size(391, 42);
            this.öğrenciCrudFormuToolStripMenuItem.Text = "Öğrenci Crud Formu";
            this.öğrenciCrudFormuToolStripMenuItem.Click += new System.EventHandler(this.öğrenciCrudFormuToolStripMenuItem_Click);
            // 
            // öğrencininAldığıDerslerToolStripMenuItem
            // 
            this.öğrencininAldığıDerslerToolStripMenuItem.Name = "öğrencininAldığıDerslerToolStripMenuItem";
            this.öğrencininAldığıDerslerToolStripMenuItem.Size = new System.Drawing.Size(391, 42);
            this.öğrencininAldığıDerslerToolStripMenuItem.Text = "Öğrencinin Aldığı Dersler";
            this.öğrencininAldığıDerslerToolStripMenuItem.Click += new System.EventHandler(this.öğrencininAldığıDerslerToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şEHİRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şEHİRCRUDFORMUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERSCRUDFORMUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciCrudFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrencininAldığıDerslerToolStripMenuItem;
    }
}