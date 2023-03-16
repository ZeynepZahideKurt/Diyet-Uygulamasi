using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
   
    public class HealthyTipServices
    {
        HealthyTipRepository healthyTipRepository;
        public HealthyTipServices()
        {
            healthyTipRepository = new HealthyTipRepository();
        }

        public List<HealthyTip> GetList()
        {
            List<HealthyTip> Nutrients = new List<HealthyTip>();

            Nutrients = healthyTipRepository.GetAllHealthyTip();

            return Nutrients;
        }
      
        public bool Insert(HealthyTip healthyTip)
        {
            return healthyTipRepository.Insert(healthyTip);
        }
        public bool Update(HealthyTip healthyTip)
        {
            return healthyTipRepository.Update(healthyTip);
        }
        public bool DeleteWithId(int healthyTipId)
        {

            HealthyTip n = healthyTipRepository.GetHealthyTipById(healthyTipId);
            return healthyTipRepository.Delete(n);
        }
        public bool Delete(HealthyTip healthyTip)
        {

            return healthyTipRepository.Delete(healthyTip);
        }
        public HealthyTip GetHealthyTipById(int healthytipID)
        {
            return healthyTipRepository.GetHealthyTipById(healthytipID);
        }
    }
}
