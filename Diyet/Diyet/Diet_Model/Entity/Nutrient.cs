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
        public int NutrientID { get; set; }

        public string NutrientName { get; set; }


        public int Calories { get; set; }


        public Amount Amount { get; set; }


    }
}
