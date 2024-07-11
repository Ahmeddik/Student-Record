using System;
using System.Collections.Generic;
using System.Data;
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



        public bool update(int id)
        {
            try
            {
                string sql = "UPDATE student SET FirstName = +'" + FirstName + "' ,lastName = '" + lastName + "' , Email = '" + Email + "' , Grade = '" + Grade + "' , Section = '" + Section + "' , DateOfBirth = '" + DateOfBirth + "' WHERE StudentID = '" + id + "' ";
                SqlConnection con = new DBConnection().openConection();
                SqlCommand cmmd = new SqlCommand(sql, con);
                int res = cmmd.ExecuteNonQuery();

                if (res > 0)
                {
                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }


        public static bool Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM student WHERE StudentID = '" + id + "' ";
                SqlConnection con = new DBConnection().openConection();
                SqlCommand cmmd = new SqlCommand(sql, con);
                int res = cmmd.ExecuteNonQuery();

                if (res > 0)
                {
                    return true;
                }
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }


        public static DataTable getAll()
        {
            string sql = "SELECT StudentID, FirstName,LastName,Email,Grade,Section,DateOfBirth FROM student";
            SqlConnection con = new DBConnection().openConection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
