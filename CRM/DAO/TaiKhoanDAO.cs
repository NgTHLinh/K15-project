using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class TaiKhoanDAO:DataProvider
    {
        public TaiKhoanDAO():base()
        { }
        public DataTable getTK(TaiKhoangEntities user)
        {
            string sql = "select * from TaiKhoan where TaiKhoan='" + user.Taikhoan + "' and MatKhau='" + user.Matkhau + "'";

            return getDataTable(sql);
        }
    }
}
