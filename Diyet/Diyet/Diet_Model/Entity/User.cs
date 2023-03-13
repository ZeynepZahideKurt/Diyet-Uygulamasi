using Diet_Model.Enum;
using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Size { get; set; }
        public int kilo { get; set; }
        public string Gender { get; set; }
        public FileStream MyProperty { get; set; }

        public UserType UserType { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public virtual ICollection<HealthyTip> HealthyTips { get; set; }

        public virtual ICollection<MotivationNote> MotivationNotes { get; set; }

        public virtual ICollection<NutrientInfo> NutrientInfos { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
