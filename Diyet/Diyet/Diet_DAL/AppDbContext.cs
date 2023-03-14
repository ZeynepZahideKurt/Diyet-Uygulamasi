using Diet_DAL.EntityConfigurations;
using Diet_DAL.Strategy;
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
            Database.SetInitializer(new DietStrategy());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HealthyTip> HealthyTips { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MotivationNote> MotivationNotes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientInfo> NutrientInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new HealthyTipConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new MotivationNoteConfiguration());
            modelBuilder.Configurations.Add(new NoteConfiguration());
            modelBuilder.Configurations.Add(new NutrientConfiguration());
            modelBuilder.Configurations.Add(new NutrientInfoConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
