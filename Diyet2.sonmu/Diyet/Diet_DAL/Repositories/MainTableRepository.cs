using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class MainTableRepository
    {
        AppDbContext dbContext;
        public MainTableRepository()
        {
            dbContext = new AppDbContext();
        }
        public bool Insert(MainTable mainTable)
        {
            dbContext.MainTables.Add(mainTable);
            return dbContext.SaveChanges() > 0;
        }

        public List<MainTable> GetListMainTablesByID(int mainTableid)
        {
            return dbContext.MainTables.Where(a => a.ID == mainTableid).ToList();
        }

        public List<MainTable> GetAllMainTables()
        {
            return dbContext.MainTables.OrderBy(a => a.ID).ToList();
        }

        public MainTable GetMainTableById(int mainTableId)
        {
            return dbContext.MainTables.Where(a => a.ID == mainTableId).FirstOrDefault();
        }

        public List<MainTable> GetListMainTablesByUserID(int userID)
        {
            return dbContext.MainTables.Where(a => a.UserID==userID).ToList();
        }

        public List<MainTable> GetListMainTablesByMealID(int mealID)
        {
            return dbContext.MainTables.Where(a => a.MealID== mealID).ToList();
        }

        public List<MainTable> GetListMainTablesByNutrientID(int nutrientID)
        {
            return dbContext.MainTables.Where(a => a.NutrientID == nutrientID).ToList();
        }

        public MainTable GetMainTablesByUserID(int userID)
        {
            return dbContext.MainTables.Where(a => a.UserID == userID).FirstOrDefault();
        }

        public MainTable GetMainTablesByMealID(int mealID)
        {
            return dbContext.MainTables.Where(a => a.MealID == mealID).FirstOrDefault();
        }

        public MainTable GetMainTablesByNutrientID(int nutrientID)
        {
            return dbContext.MainTables.Where(a => a.NutrientID == nutrientID).FirstOrDefault();
        }
    }
}
