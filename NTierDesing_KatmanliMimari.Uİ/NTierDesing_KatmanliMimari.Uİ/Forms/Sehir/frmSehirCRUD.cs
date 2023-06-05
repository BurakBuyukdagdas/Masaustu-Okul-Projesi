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
using NTierDesing_KatmanliMimari.Uİ.Forms.Ogrenci;
using NTierDesing_KatmanliMimari.TypeLayer;

namespace NTierDesing_KatmanliMimari.Uİ.Forms.Sehir
{
    public partial class frmSehirCRUD : Form
    {
        public frmSehirCRUD()
        {
            InitializeComponent();
        }

        private void frmSehirCRUD_Load(object sender, EventArgs e)
        {
            //btn_kaydet.Enabled = false; //görünür tıklanamaz
            listviewDoldur();
            btn_kaydet.Visible=false; //görünmez
        }



        void listviewDoldur()
        {

            lst_sehirler.Items.Clear();

            SqlDataReader sdr = Cls_Sehir.sehirleri_getir();

            while (sdr.Read())
            {
                ListViewItem lvi=new ListViewItem();
                lvi.Text = sdr[0].ToString();   
                lvi.SubItems.Add(sdr[1].ToString());        
                lst_sehirler.Items.Add(lvi);
            }
        }



        private void txt_sehiradi_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(txt_sehiradi.Text);
            if (txt_sehiradi.Text.Length>0)
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
            string sonuc = Cls_Sehir.sehir_kaydet(txt_sehiradi.Text);
            if (sonuc == "başarılı")
            {
                txt_sehiradi.Text = "";
                listviewDoldur();
                //MessageBox.Show("Şehir Başarıyla Kaydedildi.");
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "insert", true));
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "insert", false));

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (listviewID>0)
            {
                //Güncelle burada
                Cls_Sehir cs = new Cls_Sehir();
                bool sonuc = cs.sehir_guncelle(listviewID,txt_sehiradi.Text);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "update", true));
                    txt_sehiradi.Text = "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "update", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Şehir"));
            }
        }


        int listviewID = 0; 


        private void lst_sehirler_Click(object sender, EventArgs e)
        {
            listviewID = Convert.ToInt32(lst_sehirler.FocusedItem.SubItems[0].Text);
            txt_sehiradi.Text = lst_sehirler.FocusedItem.SubItems[1].Text;
        }

        private void btn_silme_Click(object sender, EventArgs e)
        {

            if (listviewID > 0)
            {
                //Güncelle burada
                Cls_Sehir cs = new Cls_Sehir();
                bool sonuc = cs.sehir_sil(listviewID);
                if (sonuc == true)
                {
                    listviewDoldur();
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "delete", true));
                    txt_sehiradi.Text = "";

                }
                else
                {
                    MessageBox.Show(cls_ortak_mesajlar.ortak_CRUD_mesajlari("Şehir", "delete", false));
                }
            }
            else
            {
                MessageBox.Show(cls_ortak_mesajlar.ortak_liste_seçim_mesajlari("Şehir"));
            }
        }

        






    }
}
