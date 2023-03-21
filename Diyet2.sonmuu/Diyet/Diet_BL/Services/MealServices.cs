using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
    public class MealServices
    {
        MealRepository mealRepository;
        public MealServices()
        {
            mealRepository = new MealRepository();
        }

        public List<Meal> GetMealbyUserIDwithTime(int id,DateTime d1,DateTime d2)
        {
            
             return mealRepository.GetMealbyUserID(id).Where(a=>a.CreateTime>=d1 && a.CreateTime<=d2).ToList();

        }

        //public List<(string, double)> GetMealCaloriesByUserId(User user) 

        //{ var meals = dbContext.Meals.Where(m => m.Users.Any(u => u.ID == user.ID)).Select(m => new { MealName = m.MealName, Calories = m.Nutrients.Sum(n => n.Calories) });
        //    return meals.Select(m => (m.MealName, m.Calories)).ToList();
        //}
        void NutrienId(int MealId)
        {
            if (MealId < 0) throw new Exception("Parametre degeri uygun degildir");
        }

        public Meal GetByMealId(int MealId)
        {
            Meal Meals = new Meal();
            if (MealId > 0)
            {
                Meals = mealRepository.GetMealsById(MealId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return Meals;
        }

        public List<Meal> GetByMealIdTurnList(int MealId)
        {
            List<Meal> Meals = new List<Meal>();
            if (MealId > 0)
            {
                Meals = mealRepository.GetMealByIdTurnList(MealId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return Meals;
        }

        public List<Meal> GetList()
        {
            List<Meal> Meals = new List<Meal>();

            Meals = mealRepository.GetAllMeal();

            return Meals;
        }
        public bool Insert(Meal Meal)
        {
            return mealRepository.Insert(Meal);
        }
      
        public bool Update(Meal Meal)
        {
            return mealRepository.Update(Meal);
        }
        public bool DeleteWithId(int MealId)
        {

            Meal n = mealRepository.GetMealsById(MealId);
            return mealRepository.Delete(n);
        }
        public bool Delete(Meal Meal)
        {

            return mealRepository.Delete(Meal);
        }


    }
}
