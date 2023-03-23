using Diet_DAL.Repositories;
using Diet_Model.Entity;
using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Diet_DAL.Repositories.MainTableRepository;

namespace Diet_BL.Services
{
    public class MainTableServices
    {
        MainTableRepository mainTableRepository;
        public MainTableServices()
        {
            mainTableRepository = new MainTableRepository();
        }
        public double GetWater(DateTime d1, int userid)
        {
            return mainTableRepository.GetWater(d1, userid);
        }
        public bool Insert(MainTable mainTable)
        {
            return mainTableRepository.Insert(mainTable);
        }

        public List<MainTable> GetListMainTablesByID(int mainTableid)
        {
            return mainTableRepository.GetListMainTablesByID(mainTableid);
        }

        public List<MainTable> GetAllMainTables()
        {
            return mainTableRepository.GetAllMainTables();
        }

        public MainTable GetMainTableById(int mainTableId)
        {
            return mainTableRepository.GetMainTableById(mainTableId);
        }

        public List<MainTable> GetListMainTablesByUserID(int userID)
        {
            return mainTableRepository.GetListMainTablesByUserID(userID);
        }

        public List<MainTable> GetListMainTablesByMealID(int mealID)
        {
            return mainTableRepository.GetListMainTablesByMealID(mealID);
        }

        public List<MainTable> GetListMainTablesByNutrientID(int nutrientID)
        {
            return mainTableRepository.GetListMainTablesByNutrientID(nutrientID);
        }

        public MainTable GetMainTablesByUserID(int userID)
        {
            return mainTableRepository.GetMainTablesByUserID(userID);
        }

        public MainTable GetMainTablesByMealID(int mealID)
        {
            return mainTableRepository.GetMainTablesByMealID(mealID);
        }

        public MainTable GetMainTablesByNutrientID(int nutrientID)
        {
            return mainTableRepository.GetMainTablesByNutrientID(nutrientID);
        }

        public void GetCaloriesbyUserID(int userid, Chart c1, DateTime d1, DateTime d2)
        {

            mainTableRepository.GetCaloriesbyUserID(userid, c1, d1, d2);

        }
        public void GetRaport(int categoryId, MealName mealName, DateTime d1, DateTime d2, Chart c1)
        {
            mainTableRepository.GetCategorybyUserID(categoryId, mealName, d1, d2, c1);
        }

        public void GetDatebyUserId(int userid, ComboBox comboBox)
        {
            mainTableRepository.GetDatebyUserId(userid, comboBox);
        }
        public MainTable CalculateTotalCal(DateTime d1, int userid)
        {
           return mainTableRepository.CalculateTotalCal(d1, userid);
        }
        public double CalculateTotalCalTurnList(DateTime d1, int userid)
        {
            return mainTableRepository.CalculateTotalCalTurnList(d1, userid);
        }
        public void CalculateCalByMealID(DateTime d1, int userid, Chart c1)
        {
            mainTableRepository.CalculateCalByMealID(d1, userid, c1);
        }
    }
}
