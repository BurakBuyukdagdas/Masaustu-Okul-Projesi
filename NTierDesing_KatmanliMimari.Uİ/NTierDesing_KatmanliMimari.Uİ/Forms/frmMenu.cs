using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierDesing_KatmanliMimari.Uİ.Forms.Sehir;
using NTierDesing_KatmanliMimari.Uİ.Forms.Ders;
using NTierDesing_KatmanliMimari.Uİ.Forms.Ogrenci;


namespace NTierDesing_KatmanliMimari.Uİ.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void şEHİRCRUDFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehirCRUD f = new frmSehirCRUD();    
            f.ShowDialog(); 
        }

        private void dERSCRUDFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDersCRUD d = new frmDersCRUD();
            d.ShowDialog();
        }

        private void öğrenciCrudFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciCrud o = new frmOgrenciCrud();
                o.ShowDialog();

        }

        private void öğrencininAldığıDerslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciDers f = new frmOgrenciDers();
                f.ShowDialog();

        }


    }
}
