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

        public List<User> GetListUsersByID(int userid)
        {
            return dbContext.Users.Where(a => a.ID == userid).ToList();
        }

        public List<User> GetAllUsers()
        {
            return dbContext.Users.OrderBy(a=>a.FirstName).ToList();
        }

        public User GetUserById(int userId)
        {
            return dbContext.Users.Where(a => a.ID == userId).FirstOrDefault();
        }

        public bool UpdatePasswordByUserId(User user)
        {
            User updateuser = dbContext.Users.Where(a => a.ID == user.ID).FirstOrDefault();
            updateuser.Password = user.Password;
            return dbContext.SaveChanges() > 0;
        }
        #region MyRegion
        /* AppDbContext dbContext;


         public UserToMealRepository()
         {
             dbContext = new AppDbContext();
         }


         public List<UserToMeal> GetAllUserToMeal()
         {
             return dbContext.UserToMeals.ToList();
         }
         public UserToMeal GetUserToMealsById(int userTomealID)
         {
             return dbContext.UserToMeals.Where(a => a.ID == userTomealID).FirstOrDefault();
         }

         public List<UserToMeal> GetUserToMealsByUserId(User user)
         {
             var list = dbContext.UserToMeals.Where(a => a.UserID == user.ID).ToList();
             return list;
         }

         public List<UserToMeal> GetUserToMealsByUserId(Meal meal)
         {
             var list = dbContext.UserToMeals.Where(a => a.MealID == meal.ID).ToList();
             return list;
         }

         public bool Insert(UserToMeal userToMeal)
         {
             dbContext.UserToMeals.Add(userToMeal);
             return dbContext.SaveChanges() > 0;
         }

         public bool Update(UserToMeal userToMeal)
         {
             UserToMeal updateuserToMeal = dbContext.UserToMeals.Where(a => a.ID == userToMeal.ID).FirstOrDefault();
             return dbContext.SaveChanges() > 0;
         }

         public bool Delete(UserToMeal userToMeal)
         {
             UserToMeal deleteuserToMeal = dbContext.UserToMeals.Where(a => a.ID == userToMeal.ID).FirstOrDefault();
             dbContext.UserToMeals.Remove(deleteuserToMeal);
             return dbContext.SaveChanges() > 0;
         }*/
        #endregion
    }
}
