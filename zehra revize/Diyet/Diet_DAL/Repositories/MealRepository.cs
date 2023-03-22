using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class MealRepository
    {
        AppDbContext dbContext;

        public MealRepository()
        {
            dbContext = new AppDbContext();
        }

        public List<Meal> GetAllMeal()
        {
            return dbContext.Meals.ToList();
        }
        public Meal GetMealsById(int mealID)
        {
            return dbContext.Meals.Where(a => a.ID == mealID).FirstOrDefault();
        }
        public List<Meal> GetMealbyUserID(int userid)
        {
            var list = dbContext.Database.SqlQuery<Meal>
                ("SELECT m.CreateTime, SUM(n.Calories) AS Calories FROM dbo.Meals m" +
                "JOIN dbo.UserToMeals um ON m.ID=um.MealID" +
                "JOIN dbo.Users u ON u.ID=um.UserID" +
                "JOIN dbo.NutrientsToMeals nm ON nm.MealID=m.ID" +
                "JOIN dbo.Nutrients n ON n.ID=nm.NutrientID WHERE u.ID=@UserID" +
                "GROUP BY m.CreateTime"
                , new SqlParameter("@UserID", userid));
            return list.ToList();

        }

        public List<Meal> GetMealByIdTurnList(int mealID)
        {
            return dbContext.Meals.Where(a => a.ID == mealID).ToList();
        }

        public bool Insert(Meal meal)
        {
            dbContext.Meals.Add(meal);
            return dbContext.SaveChanges() > 0;
        }
        
        public bool Update(Meal meal)
        {
            Meal updateoMeal = dbContext.Meals.Where(a => a.ID == meal.ID).FirstOrDefault();
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(Meal meal)
        {
            Meal deleteMeal = dbContext.Meals.Where(a => a.ID == meal.ID).FirstOrDefault();
            dbContext.Meals.Remove(deleteMeal);
            return dbContext.SaveChanges() > 0;
        }
    }
}
