using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    internal class NutrientInfoRepository
    {
        AppDbContext dbContext;
        /*public List<User> GetAllUsers()
        {
            return dbContext.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return dbContext.Users.Where(a => a.ID == userId).FirstOrDefault();
        }
        
         public bool Insert(User user)
        {
            dbContext.Users.Add(user);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(Nutrient nutrient)
        {
            Nutrient updateNutrient = dbContext.Nutrients.Where(a => a.ID == nutrient.ID).FirstOrDefault();
            updateNutrient.NutrientName = nutrient.NutrientName;
            updateNutrient.Calories = nutrient.Calories;
            updateNutrient.Amount = nutrient.Amount;

            updateNutrient.Category = nutrient.Category;
            updateNutrient.CategoryID = nutrient.CategoryID;

            updateNutrient.NutrientInfoID = nutrient.NutrientInfoID;
            updateNutrient.NutrientInfo = nutrient.NutrientInfo;
            updateNutrient.UserToMeals = nutrient.UserToMeals;

            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(Nutrient nutrient)
        {
            Nutrient deleteNutrient = dbContext.Nutrients.Where(a => a.ID == nutrient.ID).FirstOrDefault();
            dbContext.Nutrients.Remove(deleteNutrient);
            return dbContext.SaveChanges() > 0;
        }


         */
    }
}
