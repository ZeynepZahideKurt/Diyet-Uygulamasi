using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class NutrientInfo:BaseEntityForNotes
    {
        public virtual ICollection<User> Users { get; set; }

        public virtual Nutrient Nutrient { get; set; }
    }
}
