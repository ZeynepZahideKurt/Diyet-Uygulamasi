using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Personel
    {
		private int personelID;

		public int PersonelID
        {
			get { return personelID; }
			set {
				if (value.ToString().Length == 5) personelID = value;
				else throw new Exception("Personel id 5 basamaklı olmalıdır...");
			
			}
		}
		public string Ad { get; set; }
		public string SoyAd { get; set; }

		private DateTime dogumTarihi;

		public DateTime DogumTarihi
        {
			get { return dogumTarihi; }
			set {
				if (value.AddYears(18) < DateTime.Now) dogumTarihi = value;
                else throw new Exception("Personel 18 yasindan büyük olmalıdır...");
            }
		}
		public string Telefon { get; set; }
		private string email;

		public string Email
		{
			get { return email; }
			set {
				if (value.EndsWith("@bilgeadam.com")) email = value;
				else throw new Exception("Şirket emaili giriniz...");
            }
		}

		public string Adress { get; set; }
		public DateTime IseGirisTarihi { get; set; }
		public Unvan Unvan { get; set; }
		public Cinsiyet Cinsiyet { get; set; }

		public string PersonelResmiPath { get; set; }
	}
}
