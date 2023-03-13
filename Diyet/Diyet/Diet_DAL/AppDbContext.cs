using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("")
        {
            //Database.SetInitializer(new NoteStrategy());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HealthyTip> HealthyTips { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MotivationNote> MotivationNotes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientInfo> nutrientInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Configurations.Add(new NoteConfiguration());
            //modelBuilder.Configurations.Add(new PasswordConfiguration());
            //modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
