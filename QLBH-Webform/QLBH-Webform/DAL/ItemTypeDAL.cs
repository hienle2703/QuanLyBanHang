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
    public class ItemTypeDAL:DataProvider
    {
        public DataTable LoadIemType()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select tenloai from loaitb", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        public DataTable GetItemFromItemType(string tenloai)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select matb, ten, gia, soluong from thietbi, loaitb where loaitb.maloai = thietbi.maloai and tenloai = '"+tenloai+"';", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
        
    }
}
