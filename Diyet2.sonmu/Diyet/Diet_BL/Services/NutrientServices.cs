﻿using Diet_DAL.Repositories;
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
    public class NutrientServices
    {
        NutrientRepository nutrientRepository;
        public NutrientServices()
        {
            nutrientRepository = new NutrientRepository();
        }
        void NutrienId(int nutrientId)
        {
            if (nutrientId < 0) throw new Exception("Parametre degeri uygun degildir");
        }

        public Nutrient GetByNutrientId(int nutrientId)
        {
            Nutrient Nutrients = new Nutrient();
            if (nutrientId > 0)
            {
                Nutrients = nutrientRepository.GetNutrientById(nutrientId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return Nutrients;
        }

        public List<Nutrient> GetByNutrientIdTurnList(int nutrientId)
        {
            List<Nutrient> Nutrients = new List<Nutrient>();
            if (nutrientId > 0)
            {
                Nutrients = nutrientRepository.GetNutrientByIdTurnList(nutrientId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return Nutrients;
        }


        public List<Nutrient> GetCaloribyUserID(int userid, DateTime dt)
        {
            return nutrientRepository.GetCaloribyUserID(userid,dt);

        }
        public List<Nutrient> GetNutrientsbyMealID(int mealid)
        {
            return nutrientRepository.GetNutrientsbyMealID(mealid);

        }
        public List<Nutrient> GetNutrientsbyCategoryID(int CatID)
        {

            return nutrientRepository.GetNutrientsbyCategoryID(CatID);
        }

        public double GetCalorieByNutrientID(int NutrientID)
        {
          return nutrientRepository.GetCalorieByNutrientID(NutrientID);
        }

        public List<Nutrient> GetList()
        {
            List<Nutrient> Nutrients = new List<Nutrient>();

            Nutrients = nutrientRepository.GetAllNutrients();

            return Nutrients;
        }
        public bool Insert(Nutrient nutrient)
        {
            return nutrientRepository.Insert(nutrient);
        }
        public bool Update(Nutrient nutrient)
        {
            return nutrientRepository.Update(nutrient);
        }
        public bool DeleteWithId(int nutrientId)
        {

            Nutrient n = nutrientRepository.GetNutrientById(nutrientId);
            return nutrientRepository.Delete(n);
        }
        public bool Delete(Nutrient nutrient)
        {

            return nutrientRepository.Delete(nutrient);
        }
    }
}

