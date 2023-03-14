﻿using Diet_Model.Entity;
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
            HasKey(a => a.ID);
            Property(a => a.MealName).IsRequired();
            Property(a => a.CreateTime).IsRequired();

            //Many-to-Many

            HasMany(a => a.Nutrients).WithMany(a => a.Meals).Map(cs =>
            {
                cs.MapLeftKey("ID");
                cs.MapRightKey("ID");
                cs.ToTable("NutrientsToMeals");
            });
        }
    }
}
