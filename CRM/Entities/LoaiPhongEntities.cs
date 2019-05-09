using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class LoaiPhongEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string hinhanh;
        public string Hinhanh
        {
            get
            { return hinhanh; }
            set
            { hinhanh = value; }
        }

        private string chitiet;
        public string Chitiet
        {
            get
            { return chitiet; }
            set
            { chitiet = value; }
        }

        public LoaiPhongEntities()
        { }
        public LoaiPhongEntities(int id, string hinhanh, string chitiet)
        {
            this.id = id;
            this.hinhanh = hinhanh;
            this.chitiet = chitiet;
        }
    }
}
