using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diet_DAL.Repositories
{
    public class NutrientRepository
    {
        AppDbContext dbContext;
        public NutrientRepository()
        {
            dbContext= new AppDbContext();
        }

        public Nutrient GetNutrientByName(string name)
        {
            return dbContext.Nutrients.Where(a => a.NutrientName.ToLower() == name).FirstOrDefault();
        }
        public List<Nutrient> Search(string name)
        {
            var result = (from d in dbContext.Nutrients where d.NutrientName.Contains(name) select d).ToList();
            return result;
        }
        //public List<Nutrient> GetById(Meal meal)
        //{
        //    var nutrientlist = (from b in dbContext.Meals
        //                        join u in dbContext.Users on b.Users equals u.
        //                        select b).ToList();
        //    return nutrientlist;

        //}
        /*public List<Nutrient> GetCaloribyUserID(int userid, DateTime dt)
        {
            var list = dbContext.Database.SqlQuery<Nutrient>
                ("SELECT m.MealName, SUM(n.Calories) AS Calories FROM dbo.Nutrients n" +
                "JOIN dbo.NutrientsToMeals nm ON nm.NutrientID=n.ID" +
                "JOIN dbo.Meals m ON m.ID=nm.MealID" +
                "JOIN dbo.UserToMeals um ON um.MealID=m.ID" +
                "JOIN dbo.Users u ON u.ID=um.UserID" +
                "Where u.ID=@UserID and m.CreateTime=@Time" + "GROUP BY m.MealName"
                , new SqlParameter("@UserID", userid), new SqlParameter("@Time",dt));
            return list.ToList();

        }*/
        /*public List<Nutrient> GetNutrientsbyMealID(int mealid)
        {
            var list = dbContext.Database.SqlQuery<Nutrient>
                ("SELECT n.NutrientName FROM dbo.Nutrients n" +
                "JOIN dbo.NutrientsToMeals nm ON nm.NutrientID=n.ID" +
                "JOIN dbo.Meals m ON m.ID=nm.MealID" +
                "Where m.ID=@mealID"
                , new SqlParameter("@mealID", mealid));
            return list.ToList();

        }*/

        public List<Nutrient> GetNutrientsbyCategoryID(int CatID)
        {
            var list = dbContext.Nutrients.Where(a => a.CategoryID == CatID).OrderBy(a=>a.NutrientName).ToList();
            return list.ToList();
        }
        
        public double GetCalorieByNutrientID(int NutrientID)
        {
            var calorie = (from n in dbContext.Nutrients
                           where n.ID == NutrientID
                           select new
                           {
                               n.Calories

                           }).ToList();
            return calorie[0].Calories;
        }

        public Nutrient GetNutrientById(int nutrientId)
        {
            return dbContext.Nutrients.Where(a => a.ID == nutrientId).FirstOrDefault();
        }
       /*public List<Nutrient> Search(string s)
        {
            return dbContext.Nutrients.ContainsAsync(s);
        }*/
        
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
            updateNutrient.Description = nutrient.Description;

            /*updateNutrient.NutrientInfoID = nutrient.NutrientInfoID;
            updateNutrient.NutrientInfo = nutrient.NutrientInfo;*/
            //updateNutrient.UserToMeals = nutrient.UserToMeals;
            updateNutrient.PhotoPath= nutrient.PhotoPath;

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
        public List<Nutrient> GetNutrientByIdTurnList(int nutrientId)
        {
            return dbContext.Nutrients.Where(a => a.ID == nutrientId).ToList();

        }

        public string GetTheMostSelectedNutrient(int userid)
        {
            var list = (from n in dbContext.Nutrients
                        join mt in dbContext.MainTables on n.ID equals mt.NutrientID
                        where mt.UserID == userid
                        group n by n.NutrientName into g
                        select new
                        {
                            NutrientName = g.Key,
                            Amount = g.Count(),
                        }).ToList().OrderByDescending(a => a.Amount);


            string themostselected = list.First().NutrientName;

            return themostselected;
        }

        public void GetVariertyReport(int userid, Chart c1, int nutrientid)
        {
            var list = (from mt in dbContext.MainTables
                        join m in dbContext.Meals on mt.MealID equals m.ID
                        where mt.UserID == userid && mt.NutrientID == nutrientid
                        group mt by mt.Meal.MealName into g
                        select new
                        {
                            MealName = g.Key.ToString(),
                            Amount = g.Count(),
                        }).ToList();

            c1.DataSource = list;
            c1.Series["Tercih Edilme Adedi"].XValueMember = "MealName";
            c1.Series["Tercih Edilme Adedi"].YValueMembers = "Amount";
            c1.DataBind();



        }
        public void GetNutrientListByUserid(int userid, ComboBox cmb)
        {
            var list = (from n in dbContext.Nutrients
                        join mt in dbContext.MainTables on n.ID equals mt.NutrientID
                        join u in dbContext.Users on mt.UserID equals u.ID
                        where mt.UserID == userid
                        select new
                        {
                            NutrientName = n.NutrientName,
                            ID = n.ID,

                        }).Distinct().ToList();

            cmb.DataSource = list;
            cmb.DisplayMember = "NutrientName";
            cmb.ValueMember = "ID";

        }
    }
}
