using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ThanhToanEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        private int tiendichvu;
        public int TienDichVu
        {
            get
            { return tiendichvu; }
            set
            { tiendichvu = value; }
        }
        private string ngaythanhtoan;
        public string NgayThanhToan
        {
            get
            { return ngaythanhtoan; }
            set
            { ngaythanhtoan = value; }
        }
        private int phongid;
        public int PhongId
        {
            get
            { return phongid; }
            set
            { phongid = value; }
        }
        private int sodien;
        public int SoDien
        {
            get
            { return sodien; }
            set
            { sodien = value; }
        }
        private int sonuoc;
        public int SoNuoc
        {
            get
            { return sonuoc; }
            set
            { sonuoc = value; }
        }
        public ThanhToanEntities()
        {
        }
        public ThanhToanEntities(int id, string ngaythanhtoan, int phongid, int sodien, int sonuoc, int tiendichvu)
        {
            this.id = id;
            this.ngaythanhtoan = ngaythanhtoan;
            this.phongid = phongid;
            this.sodien = sodien;
            this.sonuoc = sonuoc;
            this.tiendichvu = tiendichvu;
        }
    }
}
