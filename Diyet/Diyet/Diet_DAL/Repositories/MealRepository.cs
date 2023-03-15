using Diet_Model.Entity;
using System;
using System.Collections.Generic;
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

        /*
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
        }*/
    }
}
