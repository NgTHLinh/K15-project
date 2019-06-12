using Entities;
using System.Data;

namespace DAO
{
    public class TimKiemNhanVienDAO:DataProvider
    {
        public TimKiemNhanVienDAO():base()
        { }
        public DataTable GetTKNV (QuanLyNhanVienEntities manv)
        {
            string sql = "select * from QuanLyNhanVien where MaNV='" + manv.MaNV + "'";

            return getDataTable(sql);            
        }
    }
}
