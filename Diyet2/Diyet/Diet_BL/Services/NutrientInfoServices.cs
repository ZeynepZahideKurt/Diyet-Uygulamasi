using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
    public class NutrientInfoServices
    {
        NutrientInfoRepository nutrientInfoRepository;

        public NutrientInfoServices()
        {
            nutrientInfoRepository = new NutrientInfoRepository();
        }
        void NutrientInfoId(int nutrientInfoId)
        {
            if (nutrientInfoId < 0) throw new Exception("Parametre degeri uygun degildir");
        }
        public List<NutrientInfo> GetList()
        {
            List<NutrientInfo> NutrientInfos = new List<NutrientInfo>();

            NutrientInfos = nutrientInfoRepository.GetAllNutrientInfos();

            return NutrientInfos;
        }

        public List<NutrientInfo> GetByNutrientId(int nutrientId)
        {
            List<NutrientInfo> NutrientInfos = new List<NutrientInfo>();
            if (nutrientId > 0)
            {
                NutrientInfos = nutrientInfoRepository.GetByNutrienIdTurnList(nutrientId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return NutrientInfos;
        }

        void CheckContentTitle(NutrientInfo nutrientInfo)
        {
            if (string.IsNullOrEmpty(nutrientInfo.Text))
                throw new Exception("Bilgi boş geçilemez");
        }
        public bool Insert(NutrientInfo nutrientInfo)
        {
            CheckContentTitle(nutrientInfo);
            return nutrientInfoRepository.Insert(nutrientInfo);
        }
        public bool Update(NutrientInfo nutrientInfo)
        {
            CheckContentTitle(nutrientInfo);
            return nutrientInfoRepository.Update(nutrientInfo);
        }
        public bool DeletewithId(int nutrientInfoId)
        {

            NutrientInfo n = nutrientInfoRepository.GetByNutrientInfoId(nutrientInfoId);
            return nutrientInfoRepository.Delete(n);
        }
        public bool Delete(NutrientInfo nutrientInfo)
        {

            return nutrientInfoRepository.Delete(nutrientInfo);
        }
    }


}
