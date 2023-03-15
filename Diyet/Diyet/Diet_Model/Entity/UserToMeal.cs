using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class UserToMeal

    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }

    }
}
