using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    class DataProvider
    {
        SQLiteConnection con;//Dùng để kết nối vào cơ sở dữ liệu
        SQLiteDataAdapter da;//Là đối tượng trung gian lấy dữ liệu FIll vào trong các đối tương Data
        DataSet ds;//Kho chứa dữ liệu tạm thời để xử lý
        DataTable dt;
        SQLiteCommand cmd;
        //khởi tạo kết nối 
        public void conncet()
        {
            string str = System.IO.Directory.GetCurrentDirectory().ToString() + @"\ScannerData.db";
            //MessageBox.Show(str);
            if (con == null)
                con = new SQLiteConnection(@"Data Source = " + str);
            // Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = rfid - data; Integrated Security = True; Pooling = False //|DataDirectory|\
            if (con.State == ConnectionState.Closed)
                con.Open();
            /* if (con.State == ConnectionState.Open)
             {
                 string sql = "SELECT * FROM Account";
                 da = new SqlDataAdapter(sql, con);
                 dt = new DataTable();
                 da.Fill(dt);
                 MessageBox.Show(dt.Rows.Count.ToString());
                 disconnect();
             }
             else
                 Console.WriteLine("that bai");*/
        }
        //đóng kết nối
        public void disconnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
                con.Close();
        }
        //Hàm lấy dữ liệu (get data) trong Class kết nối
        public DataSet getDataSet(string sql)
        {
            conncet();
            da = new SQLiteDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            disconnect();
            return ds;
        }
        public DataTable getDataTable(string sql)
        {
            Console.WriteLine(sql);
            conncet();
            da = new SQLiteDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            disconnect();
            return dt;
        }
        /*Hàm xử lý Thêm xóa sửa trong Class kết nối
các công việc thêm xóa sửa trong database chỉ khác nhau chổ truy vấn SQL nên ta sẽ gom chung nó vào một hàm.*/
        public void ExeCuteNonQuery(string sql)
        {
            conncet();
            cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            disconnect();
        }

    }
}