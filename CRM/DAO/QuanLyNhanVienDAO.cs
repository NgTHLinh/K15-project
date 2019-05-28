using Entities;
using System.Data;

namespace DAO
{
    public class QuanLyNhanVienDAO : DataProvider
    {
        public QuanLyNhanVienDAO():base()
        { }
        public DataTable GetNV(QuanLyNhanVienEntities add)
        {
            string sql = "insert into QuanLyNhanVien /*('ten','gioitinh','thuongtru','tamtru','cmnd','ngaycap','noicap','email','bophan','ngayvao','sdt')*/ values ('" +add.MaNV +"','" + add.Ten + "','" + add.GioiTinh + "','" + add.ThuongTru + "','" + add.TamTru + "','" + add.CMND + "','" + add.NgayCap + "','" + add.NoiCap + "','" + add.Email + "','" + add.BoPhan + "','" + add.NgayVao + "','" + add.SDT + "')";

            return getDataTable(sql);
        }
    }
}
