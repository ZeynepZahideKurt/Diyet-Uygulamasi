using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class HealthyTipRepository
    {

        AppDbContext dbContext;
        public HealthyTipRepository()
        {
            dbContext = new AppDbContext();
        }
            public List<HealthyTip> GetAllHealthyTip()
            {
                return dbContext.HealthyTips.ToList();
            }

            public HealthyTip GetHealthyTipById(int healthytipID)
            {
                return dbContext.HealthyTips.Where(a => a.ID == healthytipID).FirstOrDefault();
            }

            public bool Insert(HealthyTip healthyTip)
            {
                dbContext.HealthyTips.Add(healthyTip);
                return dbContext.SaveChanges() > 0;
            }

            public bool Update(HealthyTip healthyTip)
            {
                HealthyTip updateHealthyTip = dbContext.HealthyTips.Where(a => a.ID == healthyTip.ID).FirstOrDefault();
                return dbContext.SaveChanges() > 0;
            }

            public bool Delete(HealthyTip healthyTip)
            {
                HealthyTip deleteHealthyTip = dbContext.HealthyTips.Where(a => a.ID == healthyTip.ID).FirstOrDefault();
                dbContext.HealthyTips.Remove(healthyTip);
                return dbContext.SaveChanges() > 0;
            }




        }
}
