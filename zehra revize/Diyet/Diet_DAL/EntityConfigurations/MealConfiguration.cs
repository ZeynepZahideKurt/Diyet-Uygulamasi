using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.EntityConfigurations
{
    public class MealConfiguration: EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            //HasKey(a => a.ID);
            Property(a => a.MealName).IsRequired();
            Property(a => a.CreateTime).IsRequired().HasColumnType("Date");


            //many to many
            /*HasMany(a => a.Nutrients).WithMany(a => a.Meals).Map(cs =>
            {
                cs.MapLeftKey("NutrientID");
                cs.MapRightKey("MealID");
                cs.ToTable("NutrientsToMeals");
            });*/

            //many to many
            /*HasMany(a => a.Users).WithMany(a => a.Meals).Map(cs =>
            {
                cs.MapLeftKey("UserID");
                cs.MapRightKey("MealID");
                cs.ToTable("UserToMeals");
            });*/

            HasMany(a => a.MainTables).WithRequired(a => a.Meal).HasForeignKey(a => a.MealID);
        }
    }
}
