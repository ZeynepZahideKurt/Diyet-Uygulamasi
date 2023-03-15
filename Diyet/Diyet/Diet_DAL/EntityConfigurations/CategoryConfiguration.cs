using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.EntityConfigurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            //HasKey(a => a.ID);
            Property(a => a.CategoryName).IsRequired();

            //Relation

            //One-to-Many
            HasMany(a => a.Nutrients).WithRequired(a => a.Category).HasForeignKey(a => a.CategoryID);

        }
    }
}
