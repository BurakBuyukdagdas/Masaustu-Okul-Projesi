using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierDesing_KatmanliMimari.DataLayer;

namespace NTierDesing_KatmanliMimari.BusinessLayer
{
    public class Cls_Sehir
    {

        //metod yazma sırası 
        // 1- public = erişim belirleyicisi ( Her yerden erişilebilir)
        //2- Stadik yada değil kararı verilir
        //3- Geriye dönüş tipi- geriye bir şey dönüyorsa return mecburi , Geriye döndürmüyorsa void
        //4- Metod adı
        //5- Eğer metod parametre alıyorsa parantez içinde parametreler yazılır.

        public static string sehir_kaydet(string sehiradi)
        {
            SqlConnection sqlcon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("sp_sehir_kaydet",sqlcon);
            sqlcmd.CommandType=System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@SehirAdi", sehiradi);

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



        public static SqlDataReader sehirleri_getir()
        {
            SqlConnection sqlCon=connection.baglanti;
            SqlCommand sqlcmd=new SqlCommand("select * from vw_sehir_listele", sqlCon);
            sqlCon.Open();
            SqlDataReader sdr=sqlcmd.ExecuteReader();
            return sdr;

        }




        public bool sehir_guncelle(int SehirID, string SehirAdi)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_sehir_guncelle",sqlCon);
            sqlCommand.CommandType=System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SehirAdi", SehirAdi);
            sqlCommand.Parameters.AddWithValue("@SehirİD", SehirID);
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


        public bool sehir_sil(int SehirID)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_sehir_sil", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SehirİD", SehirID);
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

        public static int sehirIDbul(string sehiradi)
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select SehirİD from tbl_Sehir where SehirAdi = @sehiradi", sqlCon);
            sqlcmd.Parameters.AddWithValue("@sehiradi", sehiradi);
            sqlCon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();

            int id = 0;

            while (sdr.Read())
            {
                id = Convert.ToInt32(sdr[0]);
            }

            return id;

        }



    }
}
