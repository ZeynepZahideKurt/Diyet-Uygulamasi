using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class NutrientInfo:BaseEntityForNotes
    {

        public int NutrientID { get; set; }

        public virtual Nutrient Nutrient { get; set; }
    }
}
