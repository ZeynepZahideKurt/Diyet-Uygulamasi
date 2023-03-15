using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class Nutrient
    {
        public int ID { get; set; }

        public string NutrientName { get; set; }


        public double Calories { get; set; }


        public Amount Amount { get; set; }

        public string PhotoPath { get; set; } = null;  

        public virtual ICollection<Meal> Meals { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int NutrientInfoID { get; set; }
        public virtual NutrientInfo NutrientInfo { get; set; }

    }
}
