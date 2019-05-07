using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PhongEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }


        private string dientich;
        public string DienTich
        {
            get
            { return DienTich; }
            set
            { DienTich = value; }
        }


        private string huong;
        public string Huong
        {
            get
            { return Huong; }
            set
            { Huong = value; }
        }


        private int loaiphongid;
        public int LoaiPhongId
        {
            get
            { return LoaiPhongId; }
            set
            { LoaiPhongId = value; }
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


        private string hientrang;
        public string HienTrang
        {
            get
            { return HienTrang; }
            set
            { HienTrang = value; }
        }


        private int giaca;
        public int GiaCa
        {
            get
            { return GiaCa; }
            set
            { GiaCa = value; }
        }


        public PhongEntities()
        {
        }
        public PhongEntities(int id, string dt, string h, int lp, int sd, int sn, string ht, int gc)
        {
            this.id = id;
            this.dientich = dt;
            this.huong = h;
            this.loaiphongid = lp;
            this.sodien = sd;
            this.sonuoc = sn;
            this.hientrang = ht;
            this.giaca = gc;
        }
    }
}
