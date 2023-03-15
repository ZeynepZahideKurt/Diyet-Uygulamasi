using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class NutrientInfoRepository
    {
        AppDbContext dbContext;
        public NutrientInfoRepository()
        {
            dbContext= new AppDbContext();
        }
        public List<NutrientInfo> GetAllNutrientInfo()
        {
            return dbContext.NutrientInfos.ToList();
        }

        public NutrientInfo GetNutrientInfoByNutrientId(int nutrientId)
        {
            return dbContext.NutrientInfos.Where(a => a.NutrientID == nutrientId).FirstOrDefault();
        }
        
         public bool Insert(NutrientInfo nutrientInfo)
        {
            dbContext.NutrientInfos.Add(nutrientInfo);
            return dbContext.SaveChanges() > 0;
        }

        public bool Update(NutrientInfo nutrientInfo)
        {
            NutrientInfo updateNutrient = dbContext.NutrientInfos.Where(a => a.ID == nutrientInfo.ID).FirstOrDefault();
            updateNutrient.NutrientID = nutrientInfo.NutrientID;
            

            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(NutrientInfo nutrientInfo)
        {
            NutrientInfo deleteNutrient = dbContext.NutrientInfos.Where(a => a.ID == nutrientInfo.ID).FirstOrDefault();
            dbContext.NutrientInfos.Remove(deleteNutrient);
            return dbContext.SaveChanges() > 0;
        }


         
    }
}
