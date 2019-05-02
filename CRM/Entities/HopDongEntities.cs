using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class HopDongEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string cmnd;
        public string Cmnd
        {
            get
            { return cmnd; }
            set
            { cmnd = value; }
        }
        private int phongid;
        public int PhongID
        {
            get
            { return phongid; }
            set
            { phongid = value; }
        }

        private DateTime ngaybatdau;
        public DateTime Ngaybatdau
        {
            get
            { return ngaybatdau; }
            set
            { ngaybatdau = value; }
        }

        private DateTime ngayketthuc;
        public DateTime Ngayketthuc
        {
            get
            { return ngayketthuc; }
            set
            { ngayketthuc = value; }
        }

        private int songuoio;
        public int Songuoio
        {
            get
            { return songuoio; }
            set
            { songuoio = value; }
        }

        private int tiencoc;
        public int Tiencoc
        {
            get
            { return tiencoc; }
            set
            { tiencoc = value; }
        }

        private int chietkhau;
        public int Chietkhau
        {
            get
            { return chietkhau; }
            set
            { chietkhau = value; }
        }

        private int tienhopdong;
        public int Tienhopdong
        {
            get
            { return tienhopdong; }
            set
            { tienhopdong = value; }
        }

        private int tiendien;
        public int Tiendien
        {
            get
            { return tiendien; }
            set
            { tiendien = value; }
        }

        private int tiennuoc;
        public int Tiennuoc
        {
            get
            { return tiennuoc; }
            set
            { tiennuoc = value; }
        }

        private string lietkedichvu;
        public string Lietkedichvu
        {
            get
            { return lietkedichvu; }
            set
            { lietkedichvu = value; }
        }

        public HopDongEntities()
        { }
        public HopDongEntities(int id, string cmnd, int phongid, DateTime ntt, DateTime nkt, int sno, int tcoc, int chietkhau, int tienhopdong, int tiendien, int tiennuoc, string lietkedichvu)
        {
            this.id = id;
            this.cmnd = cmnd;
            this.phongid = phongid;
            this.ngaybatdau = ntt;
            this.ngayketthuc = nkt;
            this.songuoio = sno;
            this.tiencoc = tcoc;
            this.chietkhau = chietkhau;
            this.tienhopdong = tienhopdong;
            this.tiendien = tiendien;
            this.tiennuoc = tiennuoc;
            this.lietkedichvu = lietkedichvu;

        }
    }
}
