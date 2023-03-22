using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_Model.Entity
{
    public class Note
    {
        public int ID { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
