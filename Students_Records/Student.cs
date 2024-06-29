using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Records
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Grade { get; set; }
        public string Section { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfJoin { get; set; }

        public bool insert()
        {
            try
            {
                string sql = "INSERT INTO student(FirstName,lastName,Email,Grade,Section,DateOfBirth,DateOfJoin) VALUES (+'"+ FirstName + "','" + lastName + "','" + Email + "','" + Grade + "','" + Section + "','" + DateOfBirth + "','" +  DateOfJoin +"')";
                SqlConnection con = new DBConnection().openConection();
                SqlCommand cmmd = new SqlCommand(sql, con);
                int res = cmmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return true;
                }
                return true;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }
    }
}
