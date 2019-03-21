using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    
    public class TemporaryItemTableDAL:DataProvider
    {
        static public int tempSL = -1;
        public DataTable CreateTemporaryItemTable()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("CREATE TABLE ComboItem " +
                "SELECT matb,ten,gia,soluong from thietbi LIMIT 0;", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        public DataTable DropTemporaryItemTable()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DROP TABLE ComboItem", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        public DataTable AddItemToTemporaryTable(int matb, string ten, int gia, int soluong)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO ComboItem(matb,ten,gia,soluong) VALUES('"+matb+"','"+ten+"','"+gia+"','"+soluong+"');", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT COUNT(*) as 'soluong' from ComboItem where matb ='"+matb+"'", connection);
            DataTable result2 = new DataTable();
            da2.Fill(result2);
            tempSL = int.Parse(result2.Rows[0]["soluong"].ToString());
            return result;
        }
        public DataTable GetItemFromTemporaryTable()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT matb,ten,gia, COUNT(*) as 'soluong' from ComboItem GROUP BY matb", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            //tempSL = int.Parse(result.Rows[0]["soluong"].ToString());
            return result;
        }
        public int CheckTemporaryTableExistence()
        {
            string connStr = @"datasource=127.0.0.1;port=3306;username=root;password=;database=quanlybanhang";
            string cmdStr = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'quanlybanhang' AND table_name = 'quanlybanhang'";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    if (count == 0)
                    {
                        return 0;
                    }
                    else if (count == 1)
                    {
                        return 1;
                    }
                    
                }
                return 2;
            }
        }
        public int CountRowsOfComboItem()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT COUNT(*) FROM ComboItem", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return int.Parse(result.Rows[0][0].ToString());
        }
        public void DeleteCheckedData(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM ComboItem WHERE matb = '"+id+"';", connection);
            DataTable result = new DataTable();
            da.Fill(result);
        }
    }
}
