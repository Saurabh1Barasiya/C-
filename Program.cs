using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Connect_using_reader_01
{
    class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader srdr;
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection("server=DESKTOP-3BLA6L2\\SQLEXPRESS;database=day16Db;trusted_connection=true");
                cmd = new SqlCommand("select * from Emps", con);
                con.Open();
                srdr = cmd.ExecuteReader();
                while (srdr.Read())
                {
                    Console.WriteLine($"ID : {srdr["Eid"]}");
                    Console.WriteLine($"Ename : {srdr["Ename"]}");
                    Console.WriteLine($"Esalary : {srdr["Esalary"]}");
                    Console.WriteLine($"EDOJ : {srdr["EDOJ"]}");
                }
            }
            catch (Exception e) { Console.WriteLine($"{e.Message}"); }

            finally
            {
                Console.WriteLine("Sucess");
                Console.ReadKey();
            }
        }
    }
}














