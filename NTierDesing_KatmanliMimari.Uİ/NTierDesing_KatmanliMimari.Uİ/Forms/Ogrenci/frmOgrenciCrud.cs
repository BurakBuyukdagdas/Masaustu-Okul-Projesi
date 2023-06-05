using NTierDesing_KatmanliMimari.BusinessLayer;
using NTierDesing_KatmanliMimari.TypeLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace NTierDesing_KatmanliMimari.Uİ.Forms.Ogrenci
{
    public partial class frmOgrenciCrud : Form
    {
        public frmOgrenciCrud()
        {
            InitializeComponent();
        }

        private void frmOgrenciCrud_Load(object sender, EventArgs e)
        {
            sehirleri_doldur();
            listviewDoldur();
        }

        void listviewDoldur()
        {

            lst_Ogrenciler .Items.Clear();

            SqlDataReader sdr = Cls_Ogrenci.ogrencileri_getir();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr[0].ToString();
                lvi.SubItems.Add(sdr[1].ToString());
                lvi.SubItems.Add(sdr[2].ToString());
                lvi.SubItems.Add(sdr[3].ToString());
                lvi.SubItems.Add(sdr[4].ToString());
                lst_Ogrenciler.Items.Add(lvi);
            }
        }


        void sehirleri_doldur()
        {

            cmb_sehir.Items.Clear();

            SqlDataReader sdr = Cls_Sehir.sehirleri_getir();

            while (sdr.Read())
            {
                cmb_sehir.Items.Add(sdr[1].ToString());
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string sehiradi= cmb_sehir.SelectedItem.ToString();
           int sehirID = Cls_Sehir.sehirIDbul(sehiradi);


            string sonuc = Cls_Ogrenci.ogrenci_kaydet(txt_ogrenciadi.Text,txt_ogrencisoyadi.Text, sehirID, txt_telefon.Text);
            if (sonuc == "başarılı")
            {
                txt_ogrenciadi.Text = txt_ogrencisoyadi.Text = txt_telefon.Text = "";
                listviewDoldur();
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "insert", true));
            }
            else
            {

                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "insert", false));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            if (listviewID > 0)
            {
                //Güncelle burada
                Cls_Ogrenci cs = new Cls_Ogrenci();


                string sehiradi = cmb_sehir.SelectedItem.ToString();
                int sehirID = Cls_Sehir.sehirIDbul(sehiradi);

                bool sonuc = cs.ogrenci_güncelle(listviewID, txt_ogrenciadi.Text,txt_ogrencisoyadi.Text,sehirID,txt_telefon.Text);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "update", true));
                    txt_ogrenciadi.Text = txt_ogrencisoyadi.Text=txt_telefon.Text= "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "update", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Ogrenci"));
            }
        }



        int listviewID = 0;


        private void listView1_Click(object sender, EventArgs e)
        {
            listviewID = Convert.ToInt32(lst_Ogrenciler.FocusedItem.SubItems[0].Text);
            txt_ogrenciadi.Text = lst_Ogrenciler.FocusedItem.SubItems[1].Text;
            lbl5.Text = lst_Ogrenciler.FocusedItem.SubItems[2].Text;
            cmb_sehir.Text = lst_Ogrenciler.FocusedItem.SubItems[3].Text;
            txt_telefon.Text = lst_Ogrenciler.FocusedItem.SubItems[4].Text;


        }

        private void btn_silme_Click(object sender, EventArgs e)
        {

            if (listviewID > 0)
            {
                //Güncelle burada
                Cls_Ogrenci cs = new Cls_Ogrenci();
                bool sonuc = cs.ogrenci_sil(listviewID);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "delete", true));
                    txt_ogrenciadi.Text = txt_ogrencisoyadi.Text = txt_telefon.Text = "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "delete", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Ogrenci"));
            }
        }






    }
}
