using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Records
{
    internal class DBConnection
    {
        private string connString;
        private SqlConnection conn;
        public SqlConnection openConection()
        {
            try {
                connString = "Data Source=ASEDDIK;Initial Catalog=student;Integrated Security=True;Encrypt=False";
                conn = new SqlConnection(connString);
                conn.Open();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conn;
        }

    }
}
