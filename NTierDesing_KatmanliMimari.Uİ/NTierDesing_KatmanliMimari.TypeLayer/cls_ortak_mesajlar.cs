using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesing_KatmanliMimari.TypeLayer
{
    public class cls_ortak_mesajlar
    {

        public static string ortak_CRUD_mesajlari(string tabloadi,string CRUD,bool basarilimi)
        {
            if (basarilimi==true)
            {
                if (CRUD=="insert")
                {
                    return tabloadi + " tablosuna başarıyla kaydedildi...";
                }
                else if (CRUD=="update")
                {
                    return tabloadi + " tablosunda başarıyla güncellendi.";
                }
                else if (CRUD == "delete")
                {
                    return tabloadi + " tablosundan başarıyla silindi.";
                }
                else
                {
                    return tabloadi + " yanlış parametre";
                }


            }
            else
            {
                if (CRUD == "insert")
                {
                    return "HATA " + tabloadi + " tablosuna kaydedilemedi.";
                }
                else if (CRUD == "update")
                {
                    return "HATA " + tabloadi + " tablosu güncellenedi.";
                }
                else if (CRUD == "delete")
                {
                    return "HATA " + tabloadi + " tablosundan silinemedi.";
                }
                else
                {
                    return "HATA " + tabloadi + " yanlış parametre";
                }
            }
           


        }

        public static string ortak_liste_seçim_mesajlari(string tabloadi)
        {
            return "Listeden " + tabloadi + " seçmediniz.";

        }

    }
}
