using Entities;
using System.Data;

namespace DAO
{
    public class QuanLyNhanVienDAO : DataProvider
    {
        public QuanLyNhanVienDAO() : base()
        { }
        public DataTable GetNVDAO(QuanLyNhanVienEntities add)
        {
            string sql = "insert into QuanLyNhanVien /*('ten','gioitinh','thuongtru','tamtru','cmnd','ngaycap','noicap','email','bophan','ngayvao','sdt')*/ values ('" + add.MaNV + "','" + add.Ten + "','" + add.NgaySinh + "','" + add.GioiTinh + "','" + add.ThuongTru + "','" + add.TamTru + "','" + add.Cmnd + "','" + add.NgayCap + "','" + add.NoiCap + "','" + add.Email + "','" + add.BoPhan + "','" + add.NgayVao + "','" + add.SDT + "')";

            return getDataTable(sql);
        }

        public DataTable GetThemNVDAO(QuanLyNhanVienEntities add)
        {
            string sql = "insert into QuanLyNhanVien /*('ten','ngaysinh','gioitinh','thuongtru','tamtru','cmnd','ngaycap','noicap','email','bophan','ngayvao','sdt')*/ values ('" + add.MaNV + "','" + add.Ten + "','" + add.NgaySinh + "','" + add.GioiTinh + "','" + add.ThuongTru + "','" + add.TamTru + "','" + add.Cmnd + "','" + add.NgayCap + "','" + add.NoiCap + "','" + add.Email + "','" + add.BoPhan + "','" + add.NgayVao + "','" + add.SDT + "')";

            return getDataTable(sql);
        }

        public DataTable GetUpdateNVDAO(string a,string b,bool c,string d,string ee, int f, string g, string h, string i, string j , string k, int l, int m)
        {
            string sql = "update QuanLyNhanVien set Ten='" + a + "',NgaySinh='"+b+"',GioiTinh='"+c+"',ThuongTru='"+d+"',TamTru='"+ee+"',Cmnd='"+f+"',NgayCap='"+g+"',Noicap='"+h+"',Email='"+i+"',BoPhan='"+j+"',NgayVao='"+k+"',Sdt='"+l+"' where MaNV= "+m;
            return getDataTable(sql);
        }
    }
}
