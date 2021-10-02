using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Account_DAO
    {
        static SqlConnection con;
        public static List<Account_DTO> LayAccount(string username, string pasword)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pasword);
            byte[] hasDate = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach(byte item in hasDate)
            {
                hasPass += item;
            }
            //var list = hasDate.ToString();
            //list.Reverse();
            con = DataProvider.MoKetNoi(); // mở kết nối đến CSDL
            DataTable dt = DataProvider.LayDuLieu("select * from account where username ='" + username + "' and passwork = '" + hasPass + "' and tthai = N'Bật'", con);
            // lấy dữ liệu vào datatable bằng câu truy vấn
            // nếu không thảo điều kiện thì datatable rỗng = 0
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            List<Account_DTO> lst = new List<Account_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // gán các giả trị lấy được vào các trường đã tạo bên DTO
                Account_DTO ac = new Account_DTO();
                ac.Username = dt.Rows[0]["username"].ToString();
                ac.Password = dt.Rows[0]["passwork"].ToString();
                ac.Typeuser = dt.Rows[0]["typeuser"].ToString();
                ac.Tthai = dt.Rows[0]["tthai"].ToString();
                // trả về dữ liệu của Account_DTO nếu không có là rỗng
                lst.Add(ac);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
        public static List<Account_DTO_tmp> GetAccount()
        {
            con = DataProvider.MoKetNoi(); // mở kết nối đến CSDL
            DataTable dt = DataProvider.LayDuLieu("select * from account", con);
            // lấy dữ liệu vào datatable bằng câu truy vấn
            // nếu không thảo điều kiện thì datatable rỗng = 0
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            List<Account_DTO_tmp> lst = new List<Account_DTO_tmp>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                // gán các giả trị lấy được vào các trường đã tạo bên DTO
                Account_DTO_tmp ac = new Account_DTO_tmp();
                ac.Username = dt.Rows[i]["username"].ToString();
                ac.Typeuser = dt.Rows[i]["typeuser"].ToString();
                // trả về dữ liệu của Account_DTO nếu không có là rỗng
                lst.Add(ac);
            }

            con = DataProvider.DongKetNoi();
            return lst;
        }
        public static List<Account_DTO_tmp> GetAccountByUser(string user)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select a.username, a.typeuser from Account a where username = '" + user + "'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<Account_DTO_tmp> lst = new List<Account_DTO_tmp>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Account_DTO_tmp da = new Account_DTO_tmp();
                da.Username = dt.Rows[i]["username"].ToString();
                da.Typeuser = dt.Rows[i]["typeuser"].ToString();
                lst.Add(da);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
        // tiếp theo tạo một hàm để lấy loại tài khaonr
        public static string GetTypeUser(string username, string pasword)
        {
            try
            {
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(pasword);
                byte[] hasDate = new MD5CryptoServiceProvider().ComputeHash(temp);

                string hasPass = "";
                foreach (byte item in hasDate)
                {
                    hasPass += item;
                }
                con = DataProvider.MoKetNoi();
                SqlCommand cm = new SqlCommand("select typeuser from account where username ='" + username + "' and passwork = '" + hasPass + "' ", con);
                string t = cm.ExecuteScalar().ToString(); // lấy dữ liều về, trả về 1 trường dữ liệu
                // lấy ra giá trị của loại tài khoản 
                con = DataProvider.DongKetNoi();
                return t;
            }
            catch (Exception)
            {
                return "";
            }

        }

        public static bool AddAccount(string user, string type)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into Account values('" + user + "', '1962026656160185351301320480154111117132155', '" + type + "')", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool RefreshPass(string user)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Account set passwork = '1962026656160185351301320480154111117132155' where username = '" + user+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool EditPass(string user,string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasDate = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";
            foreach (byte item in hasDate)
            {
                hasPass += item;
            }
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update account set passwork = '" + hasPass + "' where username = '"+user+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool EditNotPass(string user, string useredit, string type)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update account set username = '" + useredit + "', typeuser = '" + type + "' where username = '" + user + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool EditType(string user, string type)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update account set typeuser = '" + type + "' where username = '"+user+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Delete(string user)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete Account where username = '" + user + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Bat(string user)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Account set tthai = N'Bật' where username = '"+user+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Tat(string user)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Account set tthai = N'Tắt' where username = '" + user + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}
