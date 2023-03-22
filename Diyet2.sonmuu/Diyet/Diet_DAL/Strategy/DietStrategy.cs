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



            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Çavdar Ekmeği",
                Calories = 65,
                Amount = Amount.Slice,


            });


            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Beyaz Ekmek",
                Calories = 72,
                Amount = Amount.Slice,


            });


            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Simit",
                Calories = 434,
                Amount = Amount.Piece,


            });




            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yulaf Ezmesi",
                Calories = 37,
                Amount = Amount.Gram,
                Description = "Yulaf ezmesi genel olarak besin değeri yüksek ve düşük kalorili olduğu için kişilerin kilo vermesine ya da sağlıklı oldukları kilolarını korumasına yardımcı olmaktadır.",


            });



            tahilVeEkmekUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Patates",
                Calories = 77,
                Amount = Amount.Piece,


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


            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "İnek Sütü",
                Calories = 0.55,
                Amount = Amount.Milliliter,


            });


            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Beyaz Peynir",
                Calories = 2.0,
                Amount = Amount.Gram,


            });



            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kaşar Peyniri",
                Calories = 2.51,
                Amount = Amount.Gram,


            });


            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kefir",
                Calories = 0.6,
                Amount = Amount.Milliliter,
                Description = "Triptofan aminoasidi ve B vitamini içeriğiyle sinirleri yatıştırıcı ve depresyonu azaltıcı etkisi olan kefir, gevşeme ve uyku verici özelliğiyle de gece rahat uyumaya yardımcı oluyor.",


            });


            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yoğurt",
                Calories = 0.87,
                Amount = Amount.Milliliter,


            });


            SutVeSutUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Ayran",
                Calories = 0.38,
                Amount = Amount.Milliliter,


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
                Description = "Yeşil elmanın glisemik indexi kırmızı elmaya göre daha düşüktür. Günde 1 adet elma yemeniz önerilir.",


            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Armut",
                Calories = 101,
                Amount = Amount.Piece,

            });

            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Portakal",
                Calories = 62,
                Amount = Amount.Piece,

            });

            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Ayva",
                Calories = 57,
                Amount = Amount.Piece,

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kiraz",
                Calories = 87,
                Amount = Amount.Bowl,

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kavun",
                Calories = 54,
                Amount = Amount.Bowl,

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kiraz",
                Calories = 46,
                Amount = Amount.Bowl,

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Muz",
                Calories = 105,
                Amount = Amount.Bowl,
                Description = "Muz zengin potasyum içeriğiyle elektrolit dengesinin korunmasını sağlar. Aynı zamanda içeriğindeki potasyum, magnezyum ve kalsiyum mineralleri sayesinde kas kramplarının ve ağrılarının azalmasına yardımcı olur. Yağ ve kolesterol içeriği olmayan muzun enerji değeri yüksektir.",

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yeşil Erik",
                Calories = 76,
                Amount = Amount.Bowl,

            });



            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Üzüm",
                Calories = 104,
                Amount = Amount.Bowl,

            });


            Meyveler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Çilek",
                Calories = 46,
                Amount = Amount.Bowl,

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
                Description = "Bağışıklığı destekleyerek, kanser riskini azaltır ve yaraların iyileşmesinde etkili olur. Besleyici ve lezzetli olan havuç, beta karoten, lif, K1 vitamini, antioksidan ve potasyum içermektedir.",


            });



            cigSebzeler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Roka",
                Calories = 5,
                Amount = Amount.Bowl,


            });

            cigSebzeler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Soğan",
                Calories = 44,
                Amount = Amount.Piece,


            });

            cigSebzeler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kabak",
                Calories = 33,
                Amount = Amount.Piece,
                Description = "kabaktaki düşük sodyum ve yüksek potasyum, kan basıncını dengeler ve yüksek tansiyonu düşürmeye yardımcı olur. Ayrıca içerdiği pektin gibi lifler de kolesterol seviyelerini düşürür.",


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
                Description = "Kabuklu yemişlerin en fazla posa içeren besinlerinden bir tanesi olan bademi çiğ tüketmek oldukça faydalıdır. Badem, E vitamini, kalsiyum, fosfor, demir ve magnezyum bakımından oldukça zengindir."


            });


            yagliTohumlarVeAtistirmaliklar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Fındık",
                Calories = 8.8,
                Amount = Amount.Gram,


            });

            yagliTohumlarVeAtistirmaliklar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Ceviz",
                Calories = 52,
                Amount = Amount.Piece,


            });


            yagliTohumlarVeAtistirmaliklar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Galeta",
                Calories = 32,
                Amount = Amount.Piece,


            });

            context.Categories.Add(yagliTohumlarVeAtistirmaliklar);
            context.SaveChanges();

            Category Yaglar = new Category()
            {
                CategoryName = "YAĞLAR"
            };


            Yaglar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağı",
                Calories = 9.0,
                Amount = Amount.Gram,
                Description = "Zeytinyağının tüketimi, daha güçlü bir kemik yapısının oluşmasını ve kolesterol seviyesinin dengelenmesinde önemli bir rol oynar.",

            });
            


            Yaglar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Terayağ",
                Calories = 7.2,
                Amount = Amount.Gram,

            });

            Yaglar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytin",
                Calories = 9.0,
                Amount = Amount.Piece,

            });

            context.Categories.Add(Yaglar);
            context.SaveChanges();


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
                Description = "Düzenli olarak tüketildiğinde, pankreas, kolon ağzı ve mide kanserlerinin önüne geçmektedir. Kolorektal kanser riskini de düşüren somon balığının düzenli olarak tüketilmesi önerilir. B12 vitamini açısından zengin özelliği sayesinde, hafızayı güçlendirmenin dışında sinir sisteminin çalışmasını da olumlu etkiler.",

            });


            denizUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Levrek",
                Calories = 1.23,
                Amount = Amount.Gram,

            });


            denizUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Mezgit",
                Calories = 1.16,
                Amount = Amount.Gram,

            });

            denizUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Alabalık",
                Calories = 1.68,
                Amount = Amount.Gram,

            });

            context.Categories.Add(denizUrunleri);



            Category Corbalar = new Category()
            {
                CategoryName = "ÇORBALAR"
            };

            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Mercimek Çorbası",
                Calories = 0.396,
                Amount = Amount.Milliliter,
                Description = "Mercimek, cildi korur, kemikleri güçlendirmeye yardımcı olur. İçerisindeki protein sayesinde iştahınızı yönetir ve tok hissetmenizi sağlar. Böylelikle kilo vermek isteyen kişiler için de tercih edilebilir bir besin olarak yer alır. Glütensiz bir besin olan mercimek, çölyak hastaları ve glütensiz beslenmeyi tercih edenler için güzel bir seçenek halindedir.",

            });
            context.Categories.Add(Corbalar);


            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuk Çorbası",
                Calories = 0.224,
                Amount = Amount.Milliliter,

            });

            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tarhana Çorbası ",
                Calories = 0.81,
                Amount = Amount.Milliliter,

            });


            Corbalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yayla Çorbası",
                Calories = 0.65,
                Amount = Amount.Milliliter,

            });

            context.Categories.Add(Corbalar);

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


            EtUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Dana Kuşbaşı",
                Calories = 2.1,
                Amount = Amount.Gram,

            });



            EtUrunleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Sucuk",
                Calories = 3.32,
                Amount = Amount.Gram,
                Description = "İçerisindeki rafine tuz ve katı yağlar sebebiyle obezite, yüksek tansiyon, kalp ve damar hastalıkları risklerinide tetiklediği açıklanmıştır.",

            });



            context.Categories.Add(EtUrunleri);



            Category salatalar = new Category()
            {
                CategoryName = "SALATALAR"
            };


            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Sade Salata",
                Calories = 9,
                Amount = Amount.Bowl,

            });

            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuklu Salata",
                Calories = 225,
                Amount = Amount.Bowl,

            });


            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Ton Balıklı Salata",
                Calories = 270,
                Amount = Amount.Bowl,

            });


            salatalar.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kısır",
                Calories = 1.8,
                Amount = Amount.Gram,

            });

            context.Categories.Add(salatalar);


            Category sebzeYemekleri = new Category()
            {
                CategoryName = "SEBZE YEMEKLERİ"
            };


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bezelye Yemeği",
                Calories = 29.4,
                Amount = Amount.Tablespoon,

            });
            context.Categories.Add(sebzeYemekleri);


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağlı Brokoli ",
                Calories = 16,
                Amount = Amount.Tablespoon,
                Description = "İçerdiği antioksidanlar ile hücre hasarını engellemeye yardımcı olan brokoli, inflamasyonu önleyerek tüm vücudu koruma altına alır.",

            });


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bamya Yemeği",
                Calories = 23,
                Amount = Amount.Tablespoon,

            });


            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağlı Yaprak Sarma",
                Calories = 36,
                Amount = Amount.Piece,

            });




            sebzeYemekleri.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Zeytinyağlı Taze Fasülye",
                Calories = 30,
                Amount = Amount.Tablespoon,

            });


            context.Categories.Add(sebzeYemekleri);



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


            Nutrient Makarna = new Nutrient()
            {
                NutrientName = "Makarna(Peynirli) ",
                Calories = 29.35,
                Amount = Amount.Tablespoon,

            };

            tahil.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Nohut Yemeği ",
                Calories = 33.6,
                Amount = Amount.Tablespoon,

            });



            tahil.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bulgur Pilavı",
                Calories = 26.6,
                Amount = Amount.Tablespoon,

            });


            tahil.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Pirinç Pilavı",
                Calories = 25.0,
                Amount = Amount.Tablespoon,
                Description = "Pirinç yağla tüketildiği zaman enerjiye dönüşeceğinden kilo aldırır. Fazla tüketildiği zaman tip 2 diyabete sebep olur. Kan şekerini yükselterek seker hastalığı oluşmasına zemin hazırlar.",

            });


            tahil.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Mercimek Yemeği",
                Calories = 33.3,
                Amount = Amount.Tablespoon,

            });

            context.Categories.Add(tahil);
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


            haslamaSebze.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yeşil Kabak",
                Calories = 15,
                Amount = Amount.Piece,

            });

            context.Categories.Add(haslamaSebze);
            context.SaveChanges();

            Category kahvaltilik = new Category()
            {
                CategoryName = "KAHVALTILIK"
            };


            kahvaltilik.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Menemen",
                Calories = 1.36,
                Amount = Amount.Gram,

            });


            kahvaltilik.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Yumurta(Haşlanmış)",
                Calories = 45.0,
                Amount = Amount.Piece,

            });



            kahvaltilik.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Kaşarlı Omlet ",
                Calories = 2.0,
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


            KumesHayvanlari.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuk(Göğüs)",
                Calories = 1.52,
                Amount = Amount.Gram,

            });



            KumesHayvanlari.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuk(But)",
                Calories = 2.2,
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
                Description = "Patates kızartması, fazlasıyla yağ çektiğinden dolayı sağlık açısından sakıncalıdır. 1 orta boy patates kızartmasında 250 kalori bulunmaktadır. Bu kaloriyi yakmak için bireyin 2 saat tempolu bir şekilde yürümesi gerekir.",


            });



            fastfood.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Hamburger",
                Calories = 2.54,
                Amount = Amount.Gram,

            });


            fastfood.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tavuklu Sandviç",
                Calories = 2.41,
                Amount = Amount.Gram,

            });


            fastfood.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Soğan Halkaları",
                Calories = 4.11,
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
                Description = "Serbest oksijen radikali oluşumu, inflamasyonu hızlandırarak kalp damar hastalıkları, kanserler, diyabet ve dejeneratif hastalıkların oluşumuna neden olur. ",

            });




            AlkolluIcecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Rakı",
                Calories = 2.51,
                Amount = Amount.Milliliter,

            });


            AlkolluIcecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Şarap",
                Calories = 0.83,
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



            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Cola",
                Calories = 0.42,
                Amount = Amount.Milliliter,

            });

            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Limonata",
                Calories = 0.42,
                Amount = Amount.Milliliter,

            });


            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Çay",
                Calories = 0.1,
                Amount = Amount.Milliliter,

            });


            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Latte Macchiato",
                Calories = 0.57,
                Amount = Amount.Milliliter,

            });


            Icecekler.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Türk Kahvesi(sade)",
                Calories = 0.02,
                Amount = Amount.Milliliter,
                Description = "Araştırmalar düzenli olarak tüketilen Türk kahvesinin, damarların iç yüzeylerindeki hücrelerin yapılarını korumaya destek olarak kalp rahatsızlığına yakalanma riskini düşürebildiğini ortaya koyuyor.",

            });

            context.Categories.Add(Icecekler);
            context.SaveChanges();


            Category AburCubur = new Category()
            {
                CategoryName = "ABUR CUBUR"
            };


            AburCubur.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Jelibon",
                Calories = 3.54,
                Amount = Amount.Gram,

            });

            AburCubur.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Patlamış Mısır",
                Calories = 5.82,
                Amount = Amount.Gram,
                Description = "Patlamış mısır kalorisi yüksek bir atıştırmalıktır.Tuz ve yağ oranı yüksek tutulduğunda sağlıksız olacaktır",

            });



            AburCubur.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Bitter Çikolata",
                Calories = 5.86,
                Amount = Amount.Gram,

            });


            AburCubur.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Fıstıklı Bar",
                Calories = 5.33,
                Amount = Amount.Gram,

            });

            context.Categories.Add(AburCubur);
            context.SaveChanges();

            Category Tatli = new Category()
            {
                CategoryName = "TATLILAR"
            };

            Tatli.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Waffle",
                Calories = 2.72,
                Amount = Amount.Gram,

            });


            Tatli.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Havuçlu kek",
                Calories = 4.08,
                Amount = Amount.Gram,

            });


            Tatli.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Profiterol",
                Calories = 3.34,
                Amount = Amount.Gram,

            });


            Tatli.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Sütlaç",
                Calories = 1.34,
                Amount = Amount.Gram,

            });


            Tatli.Nutrients.Add(new Nutrient()
            {
                NutrientName = "Tiramisu",
                Calories = 2.83,
                Amount = Amount.Gram,

            });


            context.Categories.Add(Tatli);
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


            MotivationNote not3 = new MotivationNote()
            {
                Text = "Yeşil çay tüketimini özel bir durum söz konusu olmadıkça bırakmayın."
            };
            context.MotivationNotes.Add(not3);

            MotivationNote not4 = new MotivationNote()
            {
                Text = "Haftalık egzersizler planlayın ve düzenli uygulamaya çalışın."
            };
            context.MotivationNotes.Add(not4);


            MotivationNote not5 = new MotivationNote()
            {
                Text = "Gün içinde besin grubu çeşitliliğine özen gösterin."
            };
            context.MotivationNotes.Add(not5);


            MotivationNote not6 = new MotivationNote()
            {
                Text = "Fazla şekerli ve yağlı yiyecek ve içecekleri minimal seviyelerde tüketin.."
            };
            context.MotivationNotes.Add(not6);

            MotivationNote not7 = new MotivationNote()
            {
                Text = "Etiket okumaya özen gösterin, etiket üzerinde özellikle yağ, şeker ve kalori miktarlarına dikkat edin.."
            };
            context.MotivationNotes.Add(not7);


            MotivationNote not8 = new MotivationNote()
            {
                Text = "Çevrenizdeki bireyleri sağlıklı beslenmeye yönlendirin."
            };
            context.MotivationNotes.Add(not8);

            context.SaveChanges();





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
                Text = "Diyet posası, bitkisel yiyeceklerin yapısında bulunan suda çözünen ve çözünmeyen şekillerde gruplandırılan, insan sindirim sistemi tarafından sindirilemeyen veya kısmen sindirilen besin bileşikleridir. Yapılan çeşitli araştırmalar diyet lif tüketiminin obezite üzerine olumlu etkilerini göstermiştirGenel olarak diyet lif açısından zengin gıdaları şu şekilde toplayabiliriz; a) Tahıl ürünlerinden; kepekli (kepeğin %90’ı liftir) ekmekler, krakerler, mısır gevreği gibi kahvaltılık tahıllar, bulgur, çavdar, yulaf, arpa, kahverengi (kabuklu) pirinç. b) Meyvelerden; elma, armut, çilekgiller, turunçgiller, incir, kayısı, erik, kuru meyveler. c) Sebzelerden; brokoli, lahana, havuç, mısır, bezelye, patates, kabak, patlıcan, bamya.d) Çerezlerden; fındık, fıstık, badem, leblebi, çekirdekler, patlamış mısır."

            };
            context.HealthyTips.Add(diyetPosasiBilgisi);


            HealthyTip meyvesebzeBilgisi = new HealthyTip()
            {
                Text = "Sebze ve meyveler, farklı vitamin ve minerallerin vücuda alımı için son derece önemli. Aynı zamanda da güçlü bir antioksidan kaynağı olan bu besinler, bağışıklık sistemini güçlendirerek enfeksiyonlara karşı vücut direncini yükseltmekte ve yaşlanmayı geciktirmekte. Sağlıklı beslenme için sebze ve meyve tüketirken, belli bir renk grubuna odaklanmaktan kaçınmalı, değişik renklerdeki sebze ve meyveleri haftanın değişik günlerinde tüketmelisiniz."

            };
            context.HealthyTips.Add(meyvesebzeBilgisi);


            HealthyTip yagBilgisi = new HealthyTip()
            {
                Text = "Sağlıklı beslenme için vücuda yağ alımı da son derece önemli bir konu. Özellikle de ağır işlerde çalışan ve günlük kalori tüketim miktarı yüksek olan kişiler, gerekli kalorinin en az yüzde 30’unu yağlardan karşılamalı. Yağ tüketiminde her zaman için ilk tercihiniz, doymamış yağlar olmalı. Aynı zamanda da “sağlıklı yağlar” olarak tanımlanan bu yağlar, kötü kolesterolün düşmesine yardımcı olmakta ve kalp damar sağlığını korumakta. Balıklar ve bitkisel yağlar, bu konuda doğru bir tercih olacaktır.Doymuş yağlar ise fazla tüketilmeleri durumunda kalp damar sağlığı başta olmak üzere pek çok sağlık sorununu beraberinde getirmekte. Margarin, bisküvi ve diğer birtakım unlu mamullerde bulunan trans yağlar ise kanser türlerindeki hızlı artışın esas nedenleri arasındadır."

            };
            context.HealthyTips.Add(yagBilgisi);


            HealthyTip kirmiziEtBilgisi = new HealthyTip()
            {
                Text = "Kırmızı et protein, demir, yağ asitleri ve B kompleks vitaminleri açısından oldukça zengin bir besindir. Fakat hayvansal yağlar ve kolesterol miktarı bakımından istenmeyen sonuçlar doğurabildiği için, tüketiminde dikkatli olunması gerek. Eti kasaptan değil de hazır paketler içinde almayı tercih ediyorsanız, yalnızca güvenilir markaları seçmeli ve ambalajında herhangi bir yırtık olmadığından emin olmalı, son kullanma tarihine mutlaka bakmalısınız."

            };
            context.HealthyTips.Add(kirmiziEtBilgisi);



            HealthyTip baklagilBilgisi = new HealthyTip()
            {
                Text = "Bitkisel protein ve demir bakımından zengin bir besin kaynağı olan baklagiller, sağlıklı olmalarının yanı sıra doyuruculuk özelliği yüksek besinlerdir. Daha çok diyet dönemlerinde tercih edilen bu besinler, kan şekerini hızlı yükseltmedikleri için açlık hissini uzun süre engeller ve metabolizmayı düzene sokar. Baklagiller içinde ülkemizde en çok kuru baklagiller tercih ediliyor. "

            };
            context.HealthyTips.Add(baklagilBilgisi);


            HealthyTip tahilBilgisi = new HealthyTip()
            {
                Text = "Tam tahıllı besinler denildiğinde, ülkemizde daha çok ekmek ve türevleri akla geliyor. Ve tabii, en çok israf edilen besinlerin başında da yine ekmek geliyor. Tam tahıllı ekmeklerde, buğdayın tamamı kullanıldığı için mineral ve lif düzeyi oldukça yüksek. Beyaz ekmek ise buğdayın ayrıştırılmasıyla elde edilen undan üretildiği için hem besin değeri, hem de mineral ve lif bakımından daha düşük değerlere sahiptir. "

            };
            context.HealthyTips.Add(tahilBilgisi);






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
