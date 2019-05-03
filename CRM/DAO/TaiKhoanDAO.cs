using Entities;
using System.Data;

namespace DAO
{
    public class TaiKhoanDAO:DataProvider
    {
        public TaiKhoanDAO():base()
        { }
        public DataTable GetTK(TaiKhoanEntities user)
        {
            string sql = "select * from TaiKhoan where TaiKhoan='" + user.Taikhoan + "' and MatKhau='" + user.Matkhau + "'";

            return getDataTable(sql);
        }
    }
}
