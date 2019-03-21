using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    interface IRepository<T>
    {
        DataTable layDanhSach();
        bool them(T entity);
        bool sua(T entity);
        bool xoa(int ID);
        DataTable tim(int ID);
        DataTable tim(string ten);
    }
}
