using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class Category
    {
        public Category()
        {
            Nutrients = new List<Nutrient>();
        }
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Nutrient> Nutrients { get; set; }

    }
}
