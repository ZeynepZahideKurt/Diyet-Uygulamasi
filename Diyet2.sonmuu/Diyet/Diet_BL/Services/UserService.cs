using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.Entity;

namespace Diet_BL.Services
{
    public class UserService
    {
        UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(User user)
        {
            if (string.IsNullOrEmpty(user.Mail) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Ad, Soyad, mail ve şifre boş geçilemez");
            }
            return userRepository.Insert(user);
        }
        public User CheckLogin(string mail, string password)
        {
            if (string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(password))
            { throw new Exception("Mail veya şifre boş olamaz");}
            return userRepository.CheckLogin(mail, password);
        }

        public void CheckUserId(User user)
        {
            if (user.ID < 0)
            {
                throw new Exception("Kullanıcı id gecersiz");
            }
        }

        public User GetUsersByID(int userid)
        {
            return userRepository.GetUserById(userid);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }
        public List<User> GetListUsersByID(int userid)
        {
            return userRepository.GetListUsersByID(userid);
        }
        public bool UpdatePasswordByUserId(User user)
        {
            return userRepository.UpdatePasswordByUserId(user);
        }
    }
}
