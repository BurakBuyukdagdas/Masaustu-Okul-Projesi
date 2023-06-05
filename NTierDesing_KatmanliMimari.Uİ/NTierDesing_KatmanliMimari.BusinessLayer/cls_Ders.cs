using NTierDesing_KatmanliMimari.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesing_KatmanliMimari.BusinessLayer
{
    public class cls_Ders
    {
        public static SqlDataReader dersleri_getir()
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select * from vw_ders_listele", sqlCon);
            sqlCon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            return sdr;

        }


        public static string ders_kaydet(string dersadı,int kredi)
        {
            SqlConnection sqlcon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("sp_ders_kaydet", sqlcon);
            sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@dersadi", dersadı);
            sqlcmd.Parameters.AddWithValue("@kredi", kredi);

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


        public bool ders_guncelle(int dersID, string dersadi,int kredi)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_ders_guncelle", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@dersID", dersID);
            sqlCommand.Parameters.AddWithValue("@dersadi", dersadi);
            sqlCommand.Parameters.AddWithValue("@kredi", kredi);
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


        public bool ders_sil(int dersID)
        {

            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlCommand = new SqlCommand("sp_ders_sil", sqlCon);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@dersID", dersID);
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


        public static int dersIDbul(string dersadı)
        {
            SqlConnection sqlCon = connection.baglanti;
            SqlCommand sqlcmd = new SqlCommand("select dersID from tbl_ders where dersadi = @dersadı", sqlCon);
            sqlcmd.Parameters.AddWithValue("@dersadı", dersadı);
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
