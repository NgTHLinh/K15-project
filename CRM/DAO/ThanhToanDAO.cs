using Entities;
using System.Data;

namespace DAO
{
    public class ThanhToanDAO : DataProvider
    {
        public ThanhToanDAO() : base()
        { }
        public DataTable GetThanhToan(ThanhToanEntities tt)
        {
            string sql = "select * from ThanhToan";
            return getDataTable(sql);
        }
    }
}
