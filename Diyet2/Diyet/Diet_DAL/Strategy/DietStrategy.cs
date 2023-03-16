using Diet_Model.Entity;
using Diet_Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Strategy
{
    public class DietStrategy : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            #region MyRegion
           

            //Meal oglen = new Meal()
            //{
            //    MealName = "Öğlen"
            //};

            //Meal Aksam = new Meal()
            //{
            //    MealName = "Akşam"
            //};

            //Meal araOgun = new Meal()
            //{
            //    MealName = "Ara Öğun"
            //};
            //context.Meals.Add(araOgun);
            //context.Meals.Add(sabah);
            //context.Meals.Add(oglen);
            //context.Meals.Add(Aksam);
            #endregion



            Category tahilVeEkmekUrunleri = new Category()
            {
                CategoryName = "TAHIL VE EKMEK URUNLERI"
            };

            #region MyRegion
            //context.Categories.Add(tahilVeEkmekUrunleri);


            //Nutrient tamBugdayEkmegi = new Nutrient()
            //{
            //    NutrientName = "Tam Buğday Ekmeği",
            //    Calories = 63,
            //    Amount = Amount.Slice,
            //    CategoryID = tahilVeEkmekUrunleri.ID

            //};

            //context.Nutrients.Add(tamBugdayEkmegi);

            #endregion

            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tam Buğday Ekmeği",
                Calories = 63,
                Amount = Amount.Slice,
                

            });
            context.Categories.Add(tahilVeEkmekUrunleri);
            context.SaveChanges();


            /*Category SutVeSutUrunleri = new Category()
            {
                CategoryName = "SÜT VE SÜT ÜRÜNLER"
            };

            context.Categories.Add(SutVeSutUrunleri);

            Nutrient lorPeynir = new Nutrient()
            {
                NutrientName = "Lor Peynir",
                Calories = 0.86,
                Amount = Amount.Gram,
                CategoryID = SutVeSutUrunleri.ID

            };
            context.Nutrients.Add(lorPeynir);




            Category Meyveler = new Category()
            {
                CategoryName = "Meyveler"
            };

            context.Categories.Add(Meyveler);

            Nutrient Elma = new Nutrient()
            {
                NutrientName = "Elma",
                Calories = 95,
                Amount = Amount.Piece,
                CategoryID = Meyveler.ID

            };
            context.Nutrients.Add(Elma);



            Category cigSebzeler = new Category()
            {
                CategoryName = "ÇİĞ SEBZELER"
            };
            context.Categories.Add(cigSebzeler);

            Nutrient Domates = new Nutrient()
            {
                NutrientName = "Domates",
                Calories = 22,
                Amount = Amount.Piece,
                CategoryID = cigSebzeler.ID

            };
            context.Nutrients.Add(Domates);


            Nutrient Salatalık = new Nutrient()
            {
                NutrientName = "Salatalık",
                Calories = 15,
                Amount = Amount.Piece,
                CategoryID = cigSebzeler.ID

            };
            context.Nutrients.Add(Salatalık);

            Nutrient Havuc = new Nutrient()
            {
                NutrientName = "Havuç",
                Calories = 25,
                Amount = Amount.Piece,
                CategoryID = cigSebzeler.ID

            };
            context.Nutrients.Add(Havuc);

            Category yagliTohumlarVeAtistirmaliklar = new Category()
            {
                CategoryName = "YAĞLI TOHUMLAR VE ATIŞTIRMALIKLAR"
            };
            context.Categories.Add(yagliTohumlarVeAtistirmaliklar);

            Nutrient Badem = new Nutrient()
            {
                NutrientName = "Badem ",
                Calories = 7.46,
                Amount = Amount.Piece,
                CategoryID = yagliTohumlarVeAtistirmaliklar.ID

            };
            context.Nutrients.Add(Badem);


            Nutrient Findik = new Nutrient()
            {
                NutrientName = "Fındık",
                Calories = 8.8,
                Amount = Amount.Piece,
                CategoryID = yagliTohumlarVeAtistirmaliklar.ID

            };
            context.Nutrients.Add(Findik);


            Category Yaglar = new Category()
            {
                CategoryName = "YAĞLAR"
            };
            context.Categories.Add(Yaglar);

            Nutrient Zeytinyagi = new Nutrient()
            {
                NutrientName = "Zeytinyağı",
                Calories = 9.0,
                Amount = Amount.Gram,
                CategoryID = Yaglar.ID
            };
            context.Nutrients.Add(Zeytinyagi);

            Nutrient Terayag = new Nutrient()

            {
                NutrientName = "Terayağ",
                Calories = 7.2,
                Amount = Amount.Gram,
                CategoryID = Yaglar.ID
            };

            context.Nutrients.Add(Terayag);

            Category denizUrunleri = new Category()
            {
                CategoryName = "DENİZ ÜRÜNLERİ"
            };

            context.Categories.Add(denizUrunleri);

            Nutrient somon = new Nutrient()
            {
                NutrientName = "Somon",
                Calories = 1.52,
                Amount = Amount.Gram,
                CategoryID = denizUrunleri.ID
            };
            context.Nutrients.Add(somon);


            Nutrient alabalik = new Nutrient()
            {
                NutrientName = "Alabalık",
                Calories = 1.68,
                Amount = Amount.Gram,
                CategoryID = denizUrunleri.ID
            };
            context.Nutrients.Add(alabalik);


            Category Corbalar = new Category()
            {
                CategoryName = "ÇORBALAR"
            };
            context.Categories.Add(Corbalar);

            Nutrient mercimekCorbasi = new Nutrient()
            {
                NutrientName = "Mercimek Çorbası",
                Calories = 0.396,
                Amount = Amount.Milliliter,
                CategoryID = Corbalar.ID
            };
            context.Nutrients.Add(mercimekCorbasi); 

            Nutrient tavukCorbasi = new Nutrient()
            {
                NutrientName = "Tavuk Çorbası",
                Calories = 0.224,
                Amount = Amount.Milliliter,
                CategoryID = Corbalar.ID
            };
            context.Nutrients.Add(tavukCorbasi);


            Category EtUrunleri = new Category()
            {
                CategoryName = "ET ÜRÜNLERİ"
            };
            context.Categories.Add(EtUrunleri); 

            Nutrient Kofte = new Nutrient()
            {
                NutrientName = "Köfte",
                Calories = 1.9,
                Amount = Amount.Gram,
                CategoryID = EtUrunleri.ID
            };
            context.Nutrients.Add(Kofte); 
            

            Nutrient Biftek = new Nutrient()
            {
                NutrientName = "Biftek",
                Calories = 2.52,
                Amount = Amount.Gram,
                CategoryID = EtUrunleri.ID
            };
            context.Nutrients.Add(Biftek);

            Category salatalar = new Category()
            {
                CategoryName = "SALATALAR"
            };
            context.Categories.Add(salatalar); 
            
            Nutrient sadeSalata = new Nutrient()
            {
                NutrientName = "Sade Salata(karışık yeşillik) ",
                Calories = 9,
                Amount = Amount.Bowl,
                CategoryID = salatalar.ID
            };
            context.Nutrients.Add(sadeSalata); 
            
            Nutrient tavukluSalata = new Nutrient()
            {
                NutrientName = "Tavuklu Salata",
                Calories = 225,
                Amount = Amount.Bowl,
                CategoryID = salatalar.ID
            };
            context.Nutrients.Add(tavukluSalata);

            Category sebzeYemekleri = new Category()
            {
                CategoryName = "SEBZE YEMEKLERİ"
            };
            context.Categories.Add(sebzeYemekleri);

            Nutrient bezelyeYemegi = new Nutrient()
            {
                NutrientName = "Bezelye Yemeği (Etli/Tavuklu/Kıymalı) ",
                Calories = 29.4,
                Amount = Amount.Tablespoon,
                CategoryID = sebzeYemekleri.ID
            };
            context.Nutrients.Add(bezelyeYemegi);


            Nutrient brokoli = new Nutrient()
            {
                NutrientName = "Zeytinyağlı Brokoli ",
                Calories = 1.08,
                Amount = Amount.Tablespoon,
                CategoryID = sebzeYemekleri.ID
            };
            context.Nutrients.Add(brokoli);


            Category tahil = new Category()
            {
                CategoryName = "TAHIL VE KURUBAKLAGİL YEMEKLERİ"
            };
            context.Categories.Add(tahil);

            Nutrient KuruFasulyeYemegi = new Nutrient()
            {
                NutrientName = "Kuru Fasülye Yemeği ",
                Calories = 33.8,
                Amount = Amount.Tablespoon,
                CategoryID = tahil.ID
            };
            context.Nutrients.Add(KuruFasulyeYemegi);


             Nutrient Makarna = new Nutrient()
            {
                NutrientName = "Makarna(Peynirli) ",
                Calories = 29.35,
                Amount = Amount.Tablespoon,
                CategoryID = tahil.ID
            };
            context.Nutrients.Add(Makarna);


            Category haslamaSebze = new Category()
            {
                CategoryName = "BUHARDA VEYA HAŞLAMA OLARAK TÜKETİLECEK SEBZELER"
            };
            context.Categories.Add(haslamaSebze);

            Nutrient Karnabahar = new Nutrient()
            {
                NutrientName = "Karnabahar ",
                Calories = 29,
                Amount = Amount.Bowl,
                CategoryID = haslamaSebze.ID
            };
            context.Nutrients.Add(Karnabahar);
            
            
            Nutrient TazeFasulye = new Nutrient()
            {
                NutrientName = "Taze Fasülye ",
                Calories = 44,
                Amount = Amount.Bowl,
                CategoryID = haslamaSebze.ID
            };
            context.Nutrients.Add(TazeFasulye);
            
            
            Category kahvaltilik = new Category()
            {
                CategoryName = "KAHVALTILIK"
            };
            context.Categories.Add(kahvaltilik);

            Nutrient Menemen = new Nutrient()
            {
                NutrientName = "Menemen (2 yumurtalı) ",
                Calories = 1.36,
                Amount = Amount.Gram,
                CategoryID = kahvaltilik.ID
            };
            context.Nutrients.Add(Menemen);


            Category KumesHayvanlari = new Category()
            {
                CategoryName = "KÜMES HAYVANLARI"
            };
            context.Categories.Add(KumesHayvanlari); 

            Nutrient HindiGogus = new Nutrient()
            {
                NutrientName = "Hindi(Göğüs)",
                Calories = 1.26,
                Amount = Amount.Gram,
                CategoryID = KumesHayvanlari.ID
            };
            context.Nutrients.Add(HindiGogus);


           Nutrient TavukKanat = new Nutrient()
            {
                NutrientName = "Tavuk(Kanat)",
                Calories = 2.0,
                Amount = Amount.Gram,
                CategoryID = KumesHayvanlari.ID
            }; 
            context.Nutrients.Add(TavukKanat);


            Category fastfood = new Category()
            {
                CategoryName = "FASTFOOD",
                
                
            };
            context.Categories.Add(fastfood); 
            
            Nutrient cheeseburger = new Nutrient()
            {
                NutrientName = "Cheeseburger",
                Calories = 2.63,
                Amount = Amount.Gram,
                CategoryID = fastfood.ID
            };
            context.Nutrients.Add(cheeseburger); 
            
            Nutrient patatesKızartması = new Nutrient()
            {
                NutrientName = "Patates Kızartması",
                Calories = 2.54,
                Amount = Amount.Gram,
                CategoryID = fastfood.ID,
                
            };
            context.Nutrients.Add(patatesKızartması);


            Category AlkolluIcecekler = new Category()
            {
                CategoryName = "ALKOLLÜ İÇECEKLER"
            };
            context.Categories.Add(AlkolluIcecekler); 
            
            Nutrient Bira = new Nutrient()
            {
                NutrientName = "Bira",
                Calories = 0.43,
                Amount = Amount.Milliliter,
                CategoryID = AlkolluIcecekler.ID
            };
            context.Nutrients.Add(Bira); 
               
            
            Nutrient Raki = new Nutrient()
            {
                NutrientName = "Rakı",
                Calories = 2.51,
                Amount = Amount.Milliliter,
               CategoryID = AlkolluIcecekler.ID
            };
            context.Nutrients.Add(Raki);

            Category Icecekler = new Category()
            {
                CategoryName = "İÇECEKLER"
            };
            context.Categories.Add(Icecekler);

            Nutrient Su = new Nutrient()
            {
                NutrientName = "Su",
                Calories = 0,
                Amount = Amount.Milliliter,
                CategoryID = Icecekler.ID
            };
            context.Nutrients.Add(Su);
            Nutrient Yumurta = new Nutrient()
            {
                NutrientName = "Yumurta (Haşlanmış)",
                Calories = 70,
                Amount = Amount.Piece,
                CategoryID = kahvaltilik.ID
            };
            context.Nutrients.Add(Yumurta);*/

            MotivationNote not1 = new MotivationNote()
            {
                Text = "Ana ve ara öğünleri mutlaka atlamadan yapmaya devam edin."
            };
            context.MotivationNotes.Add(not1);

            MotivationNote not2 = new MotivationNote()
            {
                Text = " Günlük sıvı alımını asla azaltmayın ve kendinize koyduğunuz hedefin altına hiç düşmeyin."
            };
            context.MotivationNotes.Add(not2);

            /*NutrientInfo patatesKizartmasiBilgilendirmesi = new NutrientInfo()
            {
                Text = "Patates kızartması, fazlasıyla yağ çektiğinden dolayı sağlık açısından sakıncalıdır. 1 orta boy patates kızartmasında 250 kalori bulunmaktadır. Bu kaloriyi yakmak için bireyin 2 saat tempolu bir şekilde yürümesi gerekir.",
                NutrientID= patatesKızartması.ID,
                
            };
            context.NutrientInfos.Add(patatesKizartmasiBilgilendirmesi);

            NutrientInfo elmaBilgisi = new NutrientInfo()
            {
                Text = "Yeşil elmanın glisemik indexi kırmızı elmaya göre daha düşüktür. Günde 1 adet elma yemeniz önerilir.",
                NutrientID = Elma.ID,

            };
            context.NutrientInfos.Add(elmaBilgisi);

            NutrientInfo bademBilgi = new NutrientInfo()
            {
                Text = "Kabuklu yemişlerin en fazla posa içeren besinlerinden bir tanesi olan bademi çiğ tüketmek oldukça faydalıdır. Badem, E vitamini, kalsiyum, fosfor, demir ve magnezyum bakımından oldukça zengindir.",
                NutrientID = Badem.ID,

            };
            context.NutrientInfos.Add(bademBilgi);*/


            HealthyTip alkolbilgisi = new HealthyTip()
            {
                Text = "Alkol, lipit metabolizmasında kötü kolesterol olarak bilinen LDL oranını artırır. Buna karşılık bazı klinik bulgulara göre, alkollü içkilerin bazı türleri kalp krizi riskini düşürürken, aşırısı kansere ve karaciğerde siroza yol açmaktadır."

            };
            context.HealthyTips.Add(alkolbilgisi);

            HealthyTip sutbilgisi = new HealthyTip()
            {
                Text = "Günlük süt tüketin çünkü…Sütün önemi büyüktür. Süt, mikroorganizmaların üremesi için çok iyi bir ortam oluşturması nedeniyle çok kolay bozulur. Bu nedenle sağlıklı beslenme için mümkünse sütü günlük tüketin. Temiz olmayan sütle başta tüberküloz, bruselloz ve kuduz olmak üzere birçok hastalık bulaşabilir. Sağlıklı beslenmek için sütü çiğ değil, kaynatarak tüketin."

            };
            context.HealthyTips.Add(sutbilgisi);

            HealthyTip diyetPosasiBilgisi = new HealthyTip()
            {
                Text = "Diyet posası, bitkisel yiyeceklerin yapısında bulunan suda çözünen ve çözünmeyen şekillerde gruplandırılan, insan sindirim sistemi tarafından sindirilemeyen veya kısmen sindirilen besin bileşikleridir. Yapılan çeşitli araştırmalar diyet lif tüketiminin obezite üzerine olumlu etkilerini göstermiştirGenel olarak diyet lif açısından zengin gıdaları şu şekilde toplayabiliriz;\r\n a) Tahıl ürünlerinden; kepekli (kepeğin %90’ı liftir) ekmekler, krakerler, mısır gevreği gibi kahvaltılık tahıllar, bulgur, çavdar, yulaf, arpa, kahverengi (kabuklu) pirinç.\r\n b) Meyvelerden; elma, armut, çilekgiller, turunçgiller, incir, kayısı, erik, kuru meyveler.\r\n c) Sebzelerden; brokoli, lahana, havuç, mısır, bezelye, patates, kabak, patlıcan, bamya.d) Çerezlerden; fındık, fıstık, badem, leblebi, çekirdekler, patlamış mısır."

            };
            context.HealthyTips.Add(diyetPosasiBilgisi);



            User admin = new User()
            {

                FirstName = "admin",
                LastName = "admin",
                Mail = "admin@gmail.com",
                Kilo = 1,
                Height = 1,
                Password = "admin",
                UserType = UserType.Admin,
                Gender = "a",

            };
            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
