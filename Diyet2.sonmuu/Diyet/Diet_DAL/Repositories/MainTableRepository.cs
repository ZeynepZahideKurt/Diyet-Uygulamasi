using Diet_Model.Entity;
using Diet_Model.Enum;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            return dbContext.MainTables.Where(a => a.UserID == userID).ToList();
        }

        public List<MainTable> GetListMainTablesByMealID(int mealID)
        {
            return dbContext.MainTables.Where(a => a.MealID == mealID).ToList();
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
        public void GetCaloriesbyUserID(int userid, Chart c1, DateTime d1, DateTime d2)
        {

            var adminrapor = (from m in dbContext.Meals
                              join mt in dbContext.MainTables on m.ID equals mt.MealID
                              join u in dbContext.Users on mt.UserID equals u.ID
                              join n in dbContext.Nutrients on mt.NutrientID equals n.ID
                              where u.ID == userid && m.CreateTime >= d1 || m.CreateTime <= d2
                              group m by m.CreateTime into g
                              select new
                              {
                                  CreateTime = g.Key.ToString(),
                                  Calories = dbContext.Nutrients.Sum(n => n.Calories),
                              }).ToList();

            c1.DataSource = adminrapor;
            c1.Series["Günlük Kalori"].XValueMember = "CreateTime";
            c1.Series["Günlük Kalori"].YValueMembers = "Calories";
            c1.DataBind();

        }

        public void GetDatebyUserId(int userid, ComboBox comboBox)
        {
            var dates = (from m in dbContext.Meals
                         join mt in dbContext.MainTables on m.ID equals mt.MealID
                         join u in dbContext.Users on mt.UserID equals u.ID
                         where u.ID == userid
                         select new
                         {
                             CreateTime = m.CreateTime,
                         }).Distinct().ToList();

            comboBox.DataSource = dates;
            comboBox.DisplayMember = "CreateTime";

        }

        public MainTable CalculateTotalCal(DateTime d1, int userid)
        {
            var list = dbContext.MainTables.Where(a => a.Meal.CreateTime == d1 && a.User.ID == userid).FirstOrDefault();

            return list;
        }
        public double CalculateTotalCalTurnList(DateTime d1, int userid)
        {
            var list = dbContext.MainTables.Where(a => a.Meal.CreateTime == d1 && a.User.ID == userid).Select(a => new
            {
                a.TotalCalorie,
                
            }).ToList();
            double toplam = 0;
            foreach (var item in list)
            {
                toplam += item.TotalCalorie;
            }
            return toplam;
        }

        public void GetCategorybyUserID(int categoryId, MealName mealName, DateTime baslTrh, DateTime bitisTrh, Chart c1)
        {
            
            var comparisonRapor = (from u in dbContext.Users
                                   join mt in dbContext.MainTables on u.ID equals mt.UserID
                                   join m in dbContext.Meals on mt.MealID equals m.ID
                                   join n in dbContext.Nutrients on mt.NutrientID equals n.ID
                                   join c in dbContext.Categories on n.CategoryID equals c.ID
                                   where c.ID == categoryId && m.MealName == mealName && (m.CreateTime >= baslTrh && m.CreateTime <= bitisTrh)
                                   group u by u.ID into g
                                   select new
                                   {
                                       UserId = g.Key.ToString(),
                                       CategoryAdet = dbContext.Categories.Count(),

                                   }).ToList();
            c1.DataSource = comparisonRapor;
            c1.Series["Series1"].XValueMember = "UserId";
            c1.Series["Series1"].YValueMembers = "CategoryAdet";
            c1.DataBind();
            //return comparisonRapor;



        }
        public void CalculateCalByMealID(DateTime d1, int userid, Chart c1)
        {
            var list = (from mt in dbContext.MainTables
                        where mt.Meal.CreateTime == d1 && mt.User.ID == userid
                        group mt by mt.Meal.MealName into g
                        select new
                        {
                            MealName = g.Key.ToString(),
                            Calories = g.Sum(a => a.TotalCalorie)
                        }).ToList();

            c1.DataSource = list;
            c1.Series["Öğünler"].XValueMember = "MealName";
            c1.Series["Öğünler"].YValueMembers = "Calories";

            c1.DataBind();

        }
    }
    public class ComparisonRapor
    {
        public string UserId { get; set; }
        public int CategoryAdet { get; set; }
    }
}

