using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class DBConnect
    {
        protected MySqlConnection connection = new MySqlConnection( "datasource=127.0.0.1;port=3306;username=root;password=;database=quanlybanhang");
   
        /*
        try
        {

            connection.Open();
            Console.WriteLine("Ket noi thanh cong");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ket noi that bai:" + ex.Message + ".");
        }
        finally
        {
            connection.Close();
            connection.Dispose();
        }
        */
        
        
    }
}

