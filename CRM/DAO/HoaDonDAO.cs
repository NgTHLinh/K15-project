using Entities;
using System.Data;


namespace DAO
{
    public class HoaDonDAO : DataProvider
    {
        public HoaDonDAO() : base()
        { }
        
            public DataTable LuuHoaDon(HoaDonEntities h)
            {
                string sql = "insert into HoaDon ('Phong','Ten','Sdt','NgayVao','NgayTra','SoDien','SoNuoc','SoInternet','TongCong') values ('"+h.Phong+"','"+h.Ten+"','"+h.Sdt+"','"+h.NgayVao+"','"+h.NgayTra+"','"+h.SoDien+"','"+h.SoNuoc+"','"+h.SoInternet+"','"+h.TongCong+"')";
                return getDataTable(sql);
            }
        }
    }

