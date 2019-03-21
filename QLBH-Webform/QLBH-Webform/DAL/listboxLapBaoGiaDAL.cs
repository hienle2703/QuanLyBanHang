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
    public class listboxLapBaoGiaDAL:DataProvider
    {
        public DataTable DataGridLoad()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select matb, ten as 'Ten thiet bi', tenloai as 'Ten loai', gia as 'Gia', soluong as 'So luong', thongtinct as 'Thong tin chi tiet' from thietbi, loaitb where loaitb.maloai = thietbi.maloai", connection);
            DataTable result = new DataTable();
            da.Fill(result);
            return result;
        }
    }
}
