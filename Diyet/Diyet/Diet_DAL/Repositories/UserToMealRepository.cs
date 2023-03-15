using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    internal class UserToMealRepository
    {

        AppDbContext dbContext;
       

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
        }
    }
}
