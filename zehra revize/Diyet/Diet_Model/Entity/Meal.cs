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
            MainTables = new List<MainTable>();
            //Users= new List<User>();
        }
        public int ID { get; set; }
        public MealName MealName { get; set; }

        public DateTime CreateTime { get; set; }

       

        public virtual ICollection<MainTable> MainTables { get; set; }
    }
}
