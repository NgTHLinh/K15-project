using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
     public class TaiKhoanBUS
    {
        private TaiKhoanDAO userDAO;
        public TaiKhoanBUS()
        {

            userDAO = new TaiKhoanDAO();
        }

        public DataTable GetTK(TaiKhoanEntities user)
        {
            DataTable dt = null;
            
                dt = userDAO.GetTK(user);
           
            return dt;
        }

    }


}
