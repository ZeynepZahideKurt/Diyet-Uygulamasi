using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class Meal
    {
        public int ID { get; set; }
        public string MealName { get; set; }
    
        public virtual IList<UserToMeal> UserToMeal { get; set; }
        
        

    }
}
