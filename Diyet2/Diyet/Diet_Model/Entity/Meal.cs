using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class Meal
    {
        public Meal()
        {
            Nutrients = new List<Nutrient>();
        }
        public int ID { get; set; }
        public MealName MealName { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Nutrient> Nutrients { get; set; }
    }
}
