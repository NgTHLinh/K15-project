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
            { return TienDichVu; }
            set
            { TienDichVu = value; }
        }
        private string ngaythanhtoan;
        public string NgayThanhToan
        {
            get
            { return NgayThanhToan; }
            set
            { NgayThanhToan = value; }
        }
        private int phongid;
        public int PhongId
        {
            get
            { return PhongId; }
            set
            { PhongId = value; }
        }
        private int sodien;
        public int SoDien
        {
            get
            { return SoDien; }
            set
            { SoDien = value; }
        }
        private int sonuoc;
        public int SoNuoc
        {
            get
            { return SoNuoc; }
            set
            { SoNuoc = value; }
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
