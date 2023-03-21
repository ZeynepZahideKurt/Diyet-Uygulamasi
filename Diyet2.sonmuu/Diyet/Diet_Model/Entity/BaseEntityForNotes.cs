using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public abstract class BaseEntityForNotes
    {
        public int ID { get; set; }

        public string Text { get; set; }

    }
}
