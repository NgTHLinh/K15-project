﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class HopDongPhatEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private int hopdongid;
        public int Hopdongid
        {
            get
            { return hopdongid; }
            set
            { hopdongid = value; }
        }

        private string tenloaiphat;
        public string Tenloaiphat
        {
            get
            { return tenloaiphat; }
            set
            { tenloaiphat = value; }
        }

        private int thanhtien;
        public int Thanhtien
        {
            get
            { return thanhtien; }
            set
            { thanhtien = value; }
        }

        public HopDongPhatEntities()
        { }
        public HopDongPhatEntities(int id, int hdid, string tlp, int tt)
        {
            this.id = id;
            this.hopdongid = hdid;
            this.tenloaiphat = tlp;
            this.thanhtien = tt;

        }
    }
}
