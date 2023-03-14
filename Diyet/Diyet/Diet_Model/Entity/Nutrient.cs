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


        public int Calories { get; set; }


        public Amount Amount { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
