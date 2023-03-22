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
        public Nutrient()
        {
            MainTables = new List<MainTable>();
        }
        public int ID { get; set; }

        public string NutrientName { get; set; }
        public string Description { get; set; }

        public double Calories { get; set; }


        public Amount Amount { get; set; }

        public string PhotoPath { get; set; } = null;  


        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        /*public int NutrientInfoID { get; set; }
        public virtual NutrientInfo NutrientInfo { get; set; }*/

        public virtual ICollection<MainTable> MainTables { get; set; }

    }
}
