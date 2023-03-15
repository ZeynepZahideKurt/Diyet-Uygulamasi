using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.EntityConfigurations
{
    public class NutrientConfiguration : EntityTypeConfiguration<Nutrient>
    {
        public NutrientConfiguration()
        {
            HasKey(a => a.ID);
            Property(a => a.NutrientName).IsRequired();
            Property(a => a.Amount).IsRequired();
            Property(a => a.Calories).IsRequired();
            Property(a => a.PhotoPath).IsOptional();


            //one to one:burada besin olmadan, besin bilgisi olmuyor
            HasRequired(x => x.NutrientInfo).WithRequiredPrincipal(x => x.Nutrient);
        }
    }
}
