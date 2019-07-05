using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class HoaDonEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string phong;
        public string Phong
        {
            get
            { return phong; }
            set
            { phong = value; }
        }
        private string ten;
        public string Ten
        {
            get
            { return ten; }
            set
            { ten = value; }
        }
        private string sdt;
        public string Sdt
        {
            get
            { return sdt; }
            set
            { sdt = value; }
        }

        private string ngayvao;
        public string NgayVao
        {
            get
            { return ngayvao; }
            set
            { ngayvao = value; }
        }
        private string ngaytra;
        public string NgayTra
        {
            get
            { return ngaytra; }
            set
            { ngaytra = value; }
        }
        private string sodien;
        public string SoDien
        {
            get
            { return sodien; }
            set
            { sodien = value; }
        }
        private string sonuoc;
        public string SoNuoc
        {
            get
            { return sonuoc; }
            set
            { sonuoc = value; }
        }
        private string sointernet;
        public string SoInternet
        {
            get
            { return sointernet; }
            set
            { sointernet = value; }
        }
        private string tongcong;
        public string TongCong
        {
            get
            { return tongcong; }
            set
            { tongcong = value; }
        }

        public HoaDonEntities() { }
        public HoaDonEntities(int id, string phong, string ten, string sdt, string ngayvao, string ngaytra, string sodien, string sonuoc, string sointernet,string tongcong)
        {
            this.id = id;
            this.phong = phong;
            this.ten = ten;
            this.sdt = sdt;
            this.ngayvao = ngayvao;
            this.ngaytra = ngaytra;
            this.sodien = sodien;
            this.sonuoc = sonuoc;
            this.sointernet = sointernet;
            this.tongcong = tongcong;
        }
    }
}
