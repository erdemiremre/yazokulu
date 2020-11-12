using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=EMRE;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
