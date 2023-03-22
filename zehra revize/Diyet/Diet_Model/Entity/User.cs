using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*FileStream FsResim=new FileStream("ResimAdresi",FileMode.Open,FileAccess.Read);
BinaryReader BrResim=new BinaryReader(FsResim);
byte[] Resim=BrResim.ReadBytes((int)FsResim.Length);
     brResim.Close();
     fsResim.Close();
 */
namespace Diet_Model.Entity
{
    public class User
    {
        public User()
        {
            Notes= new List<Note>();
            MainTables=new List<MainTable>();
        }
        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Height { get; set; }
        public double Kilo { get; set; }
        public string Gender { get; set; }

        public double Age { get; set; }
        public UserType UserType { get; set; } = UserType.Standard;
        

        //public virtual ICollection<HealthyTip> HealthyTips { get; set; }

        //public virtual ICollection<MotivationNote> MotivationNotes { get; set; }

        

        public virtual ICollection<Note> Notes { get; set; }

        public virtual ICollection<MainTable> MainTables { get; set; }


    }
}
