using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class UserRepository
    {
        AppDbContext dbContext;
        public UserRepository()
        {
            dbContext= new AppDbContext();
        }
        public bool Insert(User user)
        {
            dbContext.Users.Add(user);
            return dbContext.SaveChanges() > 0;
        }

        public User CheckLogin(string mail, string password)
        {
            User user = dbContext.Users.Where(a => a.Mail == mail).FirstOrDefault();
            if (user != null )
            {
                if (user.Password != null && password == user.Password)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            return dbContext.Users.OrderBy(a=>a.FirstName).ToList();
        }

        public User GetUserById(int userId)
        {
            return dbContext.Users.Where(a => a.ID == userId).FirstOrDefault();
        }
    }
}
