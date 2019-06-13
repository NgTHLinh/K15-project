using Entities;
using System.Data;

namespace DAO
{
    public class ThongTinNhanVienDAO : DataProvider
    {
        public ThongTinNhanVienDAO() : base()
        { }
        public DataTable GetNV ()
        {
            string sql = "select * from QuanLyNhanVien";
            return getDataTable(sql);
        }
    }
}
