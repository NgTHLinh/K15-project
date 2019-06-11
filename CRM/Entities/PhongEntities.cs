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
        private int idtang;
        public int IdTang
        {
            get
            { return idtang; }
            set
            { idtang = value; }
        }


        private string dientich;
        public string DienTich
        {
            get
            { return dientich; }
            set
            { dientich = value; }
        }


        private string huong;
        public string Huong
        {
            get
            { return huong; }
            set
            { huong = value; }
        }


        private int loaiphongid;
        public int LoaiPhongId
        {
            get
            { return loaiphongid; }
            set
            { loaiphongid = value; }
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


        private string hientrang;
        public string HienTrang
        {
            get
            { return hientrang; }
            set
            { hientrang = value; }
        }


        private int giaca;
        public int GiaCa
        {
            get
            { return giaca; }
            set
            { giaca = value; }
        }


        public PhongEntities()
        {
        }
        public PhongEntities(int id,int idtang, string dientich, string huong, int loaiphong, int sodien, int songuoi, string hientrang, int giaca)
        {
            this.id = id;
            this.idtang = idtang;
            this.dientich = dientich;
            this.huong = huong;
            this.loaiphongid = loaiphong;
            this.sodien = sodien;
            this.sonuoc = songuoi;
            this.hientrang = hientrang;
            this.giaca = giaca;
        }
    }
}
