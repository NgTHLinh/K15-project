using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{

    public class DichVuEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        private string tendichvu;
        public string Tendichvu
        {
            get
            { return tendichvu; }
            set
            { tendichvu = value; }
        }
        private string chitietdichvu;
        public string Chitietdichvu
        {
            get
            { return chitietdichvu; }
            set
            { chitietdichvu = value; }
        }

        private int soluong;
        public int Soluong
        {
            get
            { return soluong; }
            set
            { soluong = value; }
        }

        private int thanhtien;
        public int Thanhtien
        {
            get
            { return thanhtien; }
            set
            { thanhtien = value; }
        }

        public DichVuEntities()
        { }
        public DichVuEntities(int id, string tendichvu, string chitietdichvu, int soluong, int thanhtien)
        {
            this.id = id;
            this.tendichvu = tendichvu;
            this.chitietdichvu = chitietdichvu;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }

    }
}
