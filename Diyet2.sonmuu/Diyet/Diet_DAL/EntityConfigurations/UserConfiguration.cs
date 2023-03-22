using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {

            
            Property(a => a.FirstName).IsRequired().HasMaxLength(200);
            Property(a => a.LastName).IsRequired().HasMaxLength(200);
            Property(a => a.Height).IsRequired();
            Property(a => a.Kilo).IsRequired();
            Property(a => a.Gender).IsRequired();
            Property(a => a.Age).IsRequired();
            Property(a => a.UserType).IsRequired();
            HasIndex(a => a.Mail).IsUnique();
            Property(a => a.Mail).HasMaxLength(100);
            

            //One-to-Many
            HasMany(a => a.Notes).WithRequired(a => a.User).HasForeignKey(a => a.UserID);

            HasMany(a => a.MainTables).WithRequired(a => a.User).HasForeignKey(a => a.UserID);

           
            //Many-to-many

            //HasMany(a => a.MotivationNotes).WithMany(a => a.Users).Map(cs =>
            //{
            //    cs.MapLeftKey("ID");
            //    cs.MapRightKey("ID");
            //    cs.ToTable("UserToMotivationNote");
            //});


        }
    }
}
