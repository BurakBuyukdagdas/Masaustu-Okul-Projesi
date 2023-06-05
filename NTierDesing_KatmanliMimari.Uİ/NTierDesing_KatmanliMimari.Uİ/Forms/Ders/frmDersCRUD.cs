using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTierDesing_KatmanliMimari.BusinessLayer;
using NTierDesing_KatmanliMimari.DataLayer;
using NTierDesing_KatmanliMimari.TypeLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NTierDesing_KatmanliMimari.Uİ.Forms.Ders
{
    public partial class frmDersCRUD : Form
    {
        public frmDersCRUD()
        {
            InitializeComponent();
        }

        private void frmDersCRUD_Load(object sender, EventArgs e)
        {
            listviewDoldur();
            btn_kaydet.Visible = false;
        }


        void listviewDoldur()
        {

            lst_dersler.Items.Clear();

            SqlDataReader sdr = cls_Ders.dersleri_getir();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr[0].ToString();
                lvi.SubItems.Add(sdr[1].ToString());
                lvi.SubItems.Add(sdr[2].ToString());
                lst_dersler.Items.Add(lvi);
            }
        }

        private void txt_dersadi_TextChanged(object sender, EventArgs e)
        {
            if (txt_dersadi.Text.Length > 0)
            {
                btn_kaydet.Visible = true;
            }
            else
            {
                btn_kaydet.Visible = false;
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string sonuc = cls_Ders.ders_kaydet(txt_dersadi.Text,Convert.ToInt32(txt_kredi.Text));
            if (sonuc == "başarılı")
            {
                txt_dersadi.Text = txt_kredi.Text= "";
                listviewDoldur();
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "insert", true));
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "insert", false));
            }
        }

        int listviewID = 0;

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                //Güncelle burada
                cls_Ders cs = new cls_Ders();
                bool sonuc = cs.ders_guncelle(listviewID, txt_dersadi.Text,Convert.ToInt32(txt_kredi.Text));
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "update", true));
                    txt_dersadi.Text = txt_kredi.Text= "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "update", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Ders"));
            }
        }

        private void lst_dersler_Click(object sender, EventArgs e)
        {

            listviewID = Convert.ToInt32(lst_dersler.FocusedItem.SubItems[0].Text);
            txt_dersadi.Text = lst_dersler.FocusedItem.SubItems[1].Text;
            txt_kredi.Text = lst_dersler.FocusedItem.SubItems[2].Text;
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_silme_Click_1(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                //Güncelle burada
                cls_Ders cs = new cls_Ders();
                bool sonuc = cs.ders_sil(listviewID);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "delete", true));
                    txt_dersadi.Text = txt_kredi.Text = "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Ders", "update", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Ders"));
            }
        }

        private void txt_dersadi_TextChanged_1(object sender, EventArgs e)
        {
            //textbox ın f4 ile events lere gittik ordan textchanged i patlattık. Textbox a her karekter girildiğinde buraya gelir.


            // MessageBox.Show(txt_sehiradi.Text);
            if (txt_dersadi.Text.Length > 0)
            {
                btn_kaydet.Visible = true;
            }
            else
            {
                btn_kaydet.Visible = false;
            }
        }




    }
}
