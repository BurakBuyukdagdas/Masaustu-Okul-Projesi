using NTierDesing_KatmanliMimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NTierDesing_KatmanliMimari.BusinessLayer
{
    public class Cls_Ogrenci
    {



        public static string ogrenci_kaydet(string ogrenciadi,string ogrencisoyadi,int sehirID,string telefon)
        {
            SqlConnection sqlcon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("sp_ogrenci_kaydet", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ogrenciadi", ogrenciadi);
            sqlcmd.Parameters.AddWithValue("@ogrencisoyadi", ogrencisoyadi);
            sqlcmd.Parameters.AddWithValue("@sehirID", sehirID);
            sqlcmd.Parameters.AddWithValue("@telefon", telefon);
            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return "başarılı";
            }
            catch (Exception)
            {
                return "başarısız";
            }
        }

        public static SqlDataReader ogrencileri_getir()
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select * from vw_ogrenci_listele", sqlCon);
            sqlCon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            return sdr;

        }

        public bool ogrenci_güncelle(int OgrenciID, string OgrenciAdi,string OgrenciSoyadi, int SehirİD, string Telefon)
        {
           
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_ogrenci_guncelle", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@OgrenciID", OgrenciID);
            sqlCommand.Parameters.AddWithValue("@OgrenciAdi", OgrenciAdi);
            sqlCommand.Parameters.AddWithValue("@OgrenciSoyadi", OgrenciSoyadi);
            sqlCommand.Parameters.AddWithValue("@SehirİD", SehirİD);
            sqlCommand.Parameters.AddWithValue("@Telefon", Telefon);
            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }






        public bool ogrenci_sil(int @OgrenciID)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_ogrenci_sil", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@OgrenciID", OgrenciID);
            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static int ogrenciIDbul(string ogrenciadı)
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select OgrenciID from tbl_Ogrenci where OgrenciAdi = @ogrenciadı", sqlCon);
            sqlcmd.Parameters.AddWithValue("@ogrenciadı", ogrenciadı);
            sqlCon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();

            int id = 0;

            while (sdr.Read())
            {
                id = Convert.ToInt32(sdr[0]);
            }

            return id;

        }


        

             public static string ogrenci_ders_kaydet(int ogrenciID, int dersID,string notu)
        {
            SqlConnection sqlcon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("sp_ogrenci_ders_kaydet", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
            sqlcmd.Parameters.AddWithValue("@dersID", dersID);
            sqlcmd.Parameters.AddWithValue("@notu", notu);
            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return "başarılı";
            }
            catch (Exception)
            {
                return "başarısız";
            }
        }



        public static SqlDataReader ogrencileri_dersleri_getir()
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select * from vw_ogrenci_ders_listele", sqlCon);
            sqlCon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            return sdr;

        }



        public static bool ogrenci_ders_guncelle(int ogrenciID, int dersID, string notu,int odID)
        {
            SqlConnection sqlcon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("sp_ogrenci_ders_guncelle", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
            sqlcmd.Parameters.AddWithValue("@dersID", dersID);
            sqlcmd.Parameters.AddWithValue("@notu", notu);
            sqlcmd.Parameters.AddWithValue("@odID", odID);
            try
            {
                sqlcon.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public  bool ogrenci_ders_sil(int @odID)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_ogrenci_ders_sil", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@odID", @odID);
            try
            {
                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                sqlCon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static SqlDataReader ogrenci_arama_getir(string arama)
        {
            SqlConnection sqlcon= connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select od.odID,o.OgrenciAdi,d.dersadi,od.notu from tbl_Ogrenci_Ders as od inner join tbl_Ogrenci as o on od.ogrenciID=o.OgrenciID inner join tbl_Ders as d on od.dersID = d.dersID where o.OgrenciAdi like '"+arama+"%'     ", sqlcon);

            sqlcon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            return sdr;

        }







    }

}
