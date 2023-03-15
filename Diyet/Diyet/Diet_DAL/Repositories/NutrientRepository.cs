using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    internal class NutrientRepository
    {
        AppDbContext dbContext;
        public NutrientRepository()
        {
            dbContext= new AppDbContext();
        }
        //public List<Nutrient> GetByUserToMealId(int userToMealId)
        //{
        //    var list=(from u in dbContext.Nutrients
        //              join m in dbContext.UserToMeals on u.ID equals m)
            
        //}

        public Nutrient GetNutrientById(int nutrientId)
        {
            return dbContext.Nutrients.Where(a => a.ID == nutrientId).FirstOrDefault();
        }

        public bool Insert(Nutrient nutrient)
        {
            dbContext.Nutrients.Add(nutrient);
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

        public List<Nutrient> GetAllNutrients()
        {
            return dbContext.Nutrients.OrderBy(a=>a.NutrientName).ToList();
        }
        public bool Delete(Nutrient nutrient)
        {
            Nutrient deleteNutrient = dbContext.Nutrients.Where(a => a.ID == nutrient.ID).FirstOrDefault();
            dbContext.Nutrients.Remove(deleteNutrient);
            return dbContext.SaveChanges() > 0;
        }

    }
}
