using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Account_BUS
    {
        public static List<Account_DTO> LayAccount(string username, string password)
        {
            return Account_DAO.LayAccount(username, password); // trả về dữ liệu của tài khoản của username và password
        }
        public static string GetTypeAccont(string username, string password)
        {
            return Account_DAO.GetTypeUser(username, password); // trả về dữ liệu của loại tài khoản của username và password
        }
        public static List<Account_DTO_tmp> GetAccount()
        {
            return Account_DAO.GetAccount();
        }
        public static List<Account_DTO_tmp> GetbyUser(string user)
        {
            return Account_DAO.GetAccountByUser(user);
        }
        public static bool Add(string user, string type)
        {
            return Account_DAO.AddAccount(user, type);
        }
        public static bool Refresh(string user)
        {
            return Account_DAO.RefreshPass(user);
        }
        public static bool EditPass(string user ,string pass) ////
        {
            return Account_DAO.EditPass( user, pass);
        }
        public static bool EditType(string user, string type) // ///
        {
            return Account_DAO.EditType(user, type);
        }
        public static bool Delete(string user)
        {
            return Account_DAO.Delete(user);
        }
        public static bool EditNotPass(string user, string useredit, string type)
        {
            return Account_DAO.EditNotPass(user, useredit, type);
        }
        public static bool Bat(string user)
        {
            return Account_DAO.Bat(user);
        }
        public static bool Tat(string user)
        {
            return Account_DAO.Tat(user);
        }
    }
}
