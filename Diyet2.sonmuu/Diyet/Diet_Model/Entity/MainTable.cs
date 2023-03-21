using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class MainTable
    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int NutrientID { get; set; }
        public virtual Nutrient Nutrient { get; set; }

        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public Double TotalCalorie { get; set; } = 0;
        
        public Double Amt { get; set; }
    }
}
