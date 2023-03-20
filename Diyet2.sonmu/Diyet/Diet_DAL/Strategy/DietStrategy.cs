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
            Category tahilVeEkmekUrunleri = new Category()
            {
                CategoryName = "TAHIL VE EKMEK URUNLERI"
            };


            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tam Buğday Ekmeği",
                Calories = 63,
                Amount = Amount.Slice,


            });
            context.Categories.Add(tahilVeEkmekUrunleri);
            context.SaveChanges();

            Category SutVeSutUrunleri = new Category()
            {
                CategoryName = "SÜT VE SÜT ÜRÜNLER"
            };



            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Lor Peynir",
                Calories = 0.86,
                Amount = Amount.Gram,


            });
            context.Categories.Add(SutVeSutUrunleri);
            context.SaveChanges();




            Category Meyveler = new Category()
            {
                CategoryName = "MEYVELER"
            };

            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Elma",
                Calories = 95,
                Amount = Amount.Piece,


            });
            context.Categories.Add(Meyveler);



            Category cigSebzeler = new Category()
            {
                CategoryName = "ÇİĞ SEBZELER"
            };


            cigSebzeler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Domates",
                Calories = 22,
                Amount = Amount.Piece,


            });



            cigSebzeler.Nutrients.Add(new Nutrient()

            {
                NutrientName = "Salatalık",
                Calories = 15,
                Amount = Amount.Piece,


            });


            cigSebzeler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Havuç",
                Calories = 25,
                Amount = Amount.Piece,


            });
            context.Categories.Add(cigSebzeler);
            context.SaveChanges();

            Category yagliTohumlarVeAtistirmaliklar = new Category()
            {
                CategoryName = "YAĞLI TOHUMLAR VE ATIŞTIRMALIKLAR"
            };
            context.Categories.Add(yagliTohumlarVeAtistirmaliklar);

            yagliTohumlarVeAtistirmaliklar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Badem ",
                Calories = 7.46,
                Amount = Amount.Gram,


            });
            context.Categories.Add(yagliTohumlarVeAtistirmaliklar);
            context.SaveChanges();

            yagliTohumlarVeAtistirmaliklar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Fındık",
                Calories = 8.8,
                Amount = Amount.Gram,


            });


            Category Yaglar = new Category()
            {
                CategoryName = "YAĞLAR"
            };


            Yaglar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağı",
                Calories = 9.0,
                Amount = Amount.Gram,

            });
            context.Categories.Add(Yaglar);
            context.SaveChanges();


            Yaglar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Terayağ",
                Calories = 7.2,
                Amount = Amount.Gram,

            });



            Category denizUrunleri = new Category()
            {
                CategoryName = "DENİZ ÜRÜNLERİ"
            };

            context.Categories.Add(denizUrunleri);

            denizUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Somon",
                Calories = 1.52,
                Amount = Amount.Gram,

            });

            denizUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Alabalık",
                Calories = 1.68,
                Amount = Amount.Gram,

            });


            Category Corbalar = new Category()
            {
                CategoryName = "ÇORBALAR"
            };

            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Mercimek Çorbası",
                Calories = 0.396,
                Amount = Amount.Milliliter,

            });
            context.Categories.Add(Corbalar);


            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuk Çorbası",
                Calories = 0.224,
                Amount = Amount.Milliliter,

            });



            Category EtUrunleri = new Category()
            {
                CategoryName = "ET ÜRÜNLERİ"
            };


            EtUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Köfte",
                Calories = 1.9,
                Amount = Amount.Gram,

            });

            EtUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Biftek",
                Calories = 2.52,
                Amount = Amount.Gram,

            });
            context.Categories.Add(EtUrunleri);

            Category salatalar = new Category()
            {
                CategoryName = "SALATALAR"
            };

            context.Categories.Add(salatalar);
            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Sade Salata(karışık yeşillik) ",
                Calories = 9,
                Amount = Amount.Bowl,

            });

            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuklu Salata",
                Calories = 225,
                Amount = Amount.Bowl,

            });

            Category sebzeYemekleri = new Category()
            {
                CategoryName = "SEBZE YEMEKLERİ"
            };


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bezelye Yemeği (Etli/Tavuklu/Kıymalı) ",
                Calories = 29.4,
                Amount = Amount.Tablespoon,

            });
            context.Categories.Add(sebzeYemekleri);


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağlı Brokoli ",
                Calories = 1.08,
                Amount = Amount.Tablespoon,

            });

            Category tahil = new Category()
            {
                CategoryName = "TAHIL VE KURUBAKLAGİL YEMEKLERİ"
            };


            tahil.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kuru Fasülye Yemeği ",
                Calories = 33.8,
                Amount = Amount.Tablespoon,

            });
            context.Categories.Add(tahil);

            Nutrient Makarna = new Nutrient()
            {
                NutrientName = "Makarna(Peynirli) ",
                Calories = 29.35,
                Amount = Amount.Tablespoon,

            };
            context.SaveChanges();



            Category haslamaSebze = new Category()
            {
                CategoryName = "BUHARDA VEYA HAŞLAMA OLARAK TÜKETİLECEK SEBZELER"
            };


            haslamaSebze.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Karnabahar ",
                Calories = 29,
                Amount = Amount.Bowl,

            });



            haslamaSebze.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Taze Fasülye ",
                Calories = 44,
                Amount = Amount.Bowl,

            });
            context.Categories.Add(haslamaSebze);
            context.SaveChanges();

            Category kahvaltilik = new Category()
            {
                CategoryName = "KAHVALTILIK"
            };


            kahvaltilik.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Menemen (2 yumurtalı) ",
                Calories = 1.36,
                Amount = Amount.Gram,

            });
            context.Categories.Add(kahvaltilik);
            context.SaveChanges();

            Category KumesHayvanlari = new Category()
            {
                CategoryName = "KÜMES HAYVANLARI"
            };


            KumesHayvanlari.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Hindi(Göğüs)",
                Calories = 1.26,
                Amount = Amount.Gram,

            });



            KumesHayvanlari.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuk(Kanat)",
                Calories = 2.0,
                Amount = Amount.Gram,

            });
            context.Categories.Add(KumesHayvanlari);
            context.SaveChanges();


            Category fastfood = new Category()
            {
                CategoryName = "FASTFOOD",


            };
            context.Categories.Add(fastfood);

            fastfood.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Cheeseburger",
                Calories = 2.63,
                Amount = Amount.Gram,

            });


            fastfood.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Patates Kızartması",
                Calories = 2.54,
                Amount = Amount.Gram,


            });
            context.Categories.Add(fastfood);
            context.SaveChanges();


            Category AlkolluIcecekler = new Category()
            {
                CategoryName = "ALKOLLÜ İÇECEKLER"
            };


            AlkolluIcecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bira",
                Calories = 0.43,
                Amount = Amount.Milliliter,

            });




            AlkolluIcecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Rakı",
                Calories = 2.51,
                Amount = Amount.Milliliter,

            });
            context.Categories.Add(AlkolluIcecekler);
            context.SaveChanges();


            Category Icecekler = new Category()
            {
                CategoryName = "İÇECEKLER"
            };


            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Su",
                Calories = 0,
                Amount = Amount.Milliliter,

            });
            context.Categories.Add(Icecekler);
            context.SaveChanges();






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
