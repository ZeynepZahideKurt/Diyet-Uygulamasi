using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.ID);
            Property(a => a.FirstName).IsRequired().HasMaxLength(200);
            Property(a => a.LastName).IsRequired().HasMaxLength(200);
            Property(a => a.Size).IsRequired();
            Property(a => a.Kilo).IsRequired();
            Property(a => a.Gender).IsRequired();
            Property(a => a.UserType).IsRequired();
            HasIndex(a => a.Mail).IsUnique();


            //One-to-Many
            HasMany(a => a.Notes).WithRequired(a => a.User).HasForeignKey(a => a.UserID);

            //Many-to-many

            HasMany(a => a.Meals).WithMany(a => a.Users).Map(cs =>
            {
                cs.MapLeftKey("MealID");
                cs.MapRightKey("ID");
                cs.ToTable("UserToMeal");
            });

            HasMany(a => a.HealthyTips).WithMany(a => a.Users).Map(cs =>
            {
                cs.MapLeftKey("ID");
                cs.MapRightKey("ID");
                cs.ToTable("UserToHealthyTip");
            });

            HasMany(a => a.MotivationNotes).WithMany(a => a.Users).Map(cs =>
            {
                cs.MapLeftKey("ID");
                cs.MapRightKey("ID");
                cs.ToTable("UserToMotivationNote");
            });

            HasMany(a => a.NutrientInfos).WithMany(a => a.Users).Map(cs =>
            {
                cs.MapLeftKey("ID");
                cs.MapRightKey("ID");
                cs.ToTable("UserToNutrientInfo");
            });
        }
    }
}
