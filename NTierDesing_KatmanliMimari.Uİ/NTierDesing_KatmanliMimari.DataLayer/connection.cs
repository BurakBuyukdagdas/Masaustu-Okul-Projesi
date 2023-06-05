using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierDesing_KatmanliMimari.DataLayer
{
    public class connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlcon = new SqlConnection("Server=DESKTOP-CRGOIFC;Database=okulDB;Trusted_Connection=true;");
            return sqlcon;
            }
        }


    }
}
