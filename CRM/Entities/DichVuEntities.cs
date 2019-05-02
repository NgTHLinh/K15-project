using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    class DichVuEntities
    {

        private int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        private string loai;
        public string Loaidichvu
        {
            get
            {
                return loai;
            }

            set
            {
                loai = value;
            }
        }


        private string ten;
        public string Tendichvu
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

       
        private string Chitiet;
        public string Chitietdichvu
        {
            get
            {
                return Chitiet;
            }

            set
            {
                Chitiet = value;
            }
        }








    }
}
