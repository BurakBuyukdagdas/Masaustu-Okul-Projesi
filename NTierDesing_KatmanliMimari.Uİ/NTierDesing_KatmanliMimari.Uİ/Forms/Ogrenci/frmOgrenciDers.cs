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
    public partial class frmOgrenciDers : Form
    {
        public frmOgrenciDers()
        {
            InitializeComponent();
        }

        private void frmOgrenciDers_Load(object sender, EventArgs e)
        {
            ogrenci_doldur();
            ders_doldur();
            listviewDoldur();
        }


        void listviewDoldur()
        {

            lst_ogrenci_ders.Items.Clear();

            SqlDataReader sdr = Cls_Ogrenci.ogrencileri_dersleri_getir();

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr[0].ToString();
                lvi.SubItems.Add(sdr[1].ToString());
                lvi.SubItems.Add(sdr[2].ToString());
                lvi.SubItems.Add(sdr[3].ToString());
                lst_ogrenci_ders.Items.Add(lvi);
            }
        }


        void ogrenci_doldur()
        {

            cmb_ogrenci.Items.Clear();

            SqlDataReader sdr = Cls_Ogrenci.ogrencileri_getir();

            while (sdr.Read())
            {
                cmb_ogrenci.Items.Add(sdr[1].ToString());
            }
        }


        void ders_doldur()
        {

            cmb_ders.Items.Clear();

            SqlDataReader sdr = cls_Ders.dersleri_getir();

            while (sdr.Read())

            {

                cmb_ders.Items.Add(sdr[1].ToString());
            }

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string ogrenciadı = cmb_ogrenci.SelectedItem.ToString();
            int ogrenciID = Cls_Ogrenci.ogrenciIDbul(ogrenciadı);

            string dersadı = cmb_ders.SelectedItem.ToString();
            int dersID = cls_Ders.dersIDbul(dersadı);


            string sonuc = Cls_Ogrenci.ogrenci_ders_kaydet(ogrenciID,dersID,txt_notu.Text);
            if (sonuc == "başarılı")
            {
                txt_notu.Text = "";
                listviewDoldur();
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "insert", true));
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "insert", false));
            }
        }

        private void cmb_ders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                //Güncelle burada
                Cls_Ogrenci cs = new Cls_Ogrenci();


                string ogrenciadi = cmb_ogrenci.SelectedItem.ToString();
                int ogrenciID = Cls_Ogrenci.ogrenciIDbul(ogrenciadi);


                string dersadi = cmb_ders.SelectedItem.ToString();
                int dersID = cls_Ders.dersIDbul(dersadi);



                bool sonuc = Cls_Ogrenci.ogrenci_ders_guncelle(ogrenciID,dersID,txt_notu.Text,listviewID);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "update", true));
                    txt_notu.Text = "";
                }
                else
                {
                    MessageBox.Show("başarısız");
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "update", false));
            }
        }

        int listviewID = 0;

        private void lst_ogrenci_ders_Click(object sender, EventArgs e)
        {
            listviewID = Convert.ToInt32(lst_ogrenci_ders.FocusedItem.SubItems[0].Text);
            cmb_ogrenci.Text = lst_ogrenci_ders.FocusedItem.SubItems[1].Text;
            cmb_ders.Text = lst_ogrenci_ders.FocusedItem.SubItems[2].Text;
            txt_notu.Text = lst_ogrenci_ders.FocusedItem.SubItems[3].Text;
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {
            if (listviewID > 0)
            {
                //statik hali
                //bool sonuc = Cls_Ogrenci.ogrenci_ders_guncelle(ogrenciID,dersID,txt_notu.Text,listviewID);
                //bool cevap = Cls_Ogrenci.ogrenci_ders_sil(listviewID)



                Cls_Ogrenci cs = new Cls_Ogrenci();
                bool sonuc = cs.ogrenci_ders_sil(listviewID);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "delete", true));
                    txt_notu.Text = "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Öğrenci", "delete", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Öğrenci"));
            }
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            lst_ogrenci_ders.Items.Clear();
            SqlDataReader sdr = Cls_Ogrenci.ogrenci_arama_getir(txt_ara.Text);

            while (sdr.Read())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sdr[0].ToString();
                lvi.SubItems.Add(sdr[1].ToString());
                lvi.SubItems.Add(sdr[2].ToString());
                lvi.SubItems.Add(sdr[3].ToString());
                lst_ogrenci_ders.Items.Add(lvi);
            }



        }




    }
}
