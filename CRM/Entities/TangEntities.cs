using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class TangEntities
    {
        private int id;
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        private string ten;
        public string Tên
        {
            get
            { return ten; }
            set
            { ten = value; }
        }

        public TangEntities(int id, string ten)
        {
            this.id = id;
            this.ten = ten;
        }
    }
}
