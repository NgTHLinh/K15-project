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
        private DateTime ngaythanhtoan;
        public DateTime NgayThanhToan
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
        public ThanhToanEntities(int id, DateTime ntt, int pid, int sd, int sn, int tdv)
        {
            this.id = id;
            this.ngaythanhtoan = ntt;
            this.phongid = pid;
            this.sodien = sd;
            this.sonuoc = sn;
            this.tiendichvu = tdv;
        }
    }
}
