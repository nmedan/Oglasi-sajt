using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oglasi.Models;
namespace Oglasi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Kategorije.Count() == 0)
            {
                var Kategorije = new Kategorije[]
                {
                     new Kategorije {NazivKategorije= "Automobili, vozila"},
                     new Kategorije {NazivKategorije="Domaćinstvo" },
                     new Kategorije {NazivKategorije="Građevinarstvo"},
                     new Kategorije {NazivKategorije="Industrija i zanatstvo"},
                     new Kategorije {NazivKategorije="Kolekcionarstvo"},
                     new Kategorije {NazivKategorije="Kućni ljubimci"},
                     new Kategorije {NazivKategorije="Nekretnine"},
                     new Kategorije {NazivKategorije="Obaveštenja"},
                     new Kategorije {NazivKategorije="Odeća, obuća, nakit"},
                     new Kategorije {NazivKategorije="Poljoprivreda"},
                     new Kategorije {NazivKategorije="Poslovi"},
                     new Kategorije {NazivKategorije="Računari" },
                     new Kategorije {NazivKategorije="Razno"},
                     new Kategorije {NazivKategorije="Sport"},
                     new Kategorije {NazivKategorije="Tehnika"},
                     new Kategorije {NazivKategorije="Turizam i ugostiteljstvo"},
                     new Kategorije {NazivKategorije="Usluge"},
                };
                foreach (Kategorije k in Kategorije)
                {
                    context.Kategorije.Add(k);
                }
                context.SaveChanges();
            }

            if (context.Potkategorije.Count() == 0)
            {
                var Potkategorije = new Potkategorije[]
                {
                     new Potkategorije {NazivPotkategorije = "Auto delovi i oprema", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Automobili", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Bicikli", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Čamci i drugi plovni objekti", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Havarisana vozila", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Kamioni i autobusi", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Motocikli", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Prikolice", KategorijeId=3002},
                     new Potkategorije {NazivPotkategorije = "Aparati za domaćinstvo", KategorijeId=3003},
                     new Potkategorije {NazivPotkategorije = "Nameštaj", KategorijeId=3003},
                     new Potkategorije {NazivPotkategorije = "Usluge u domaćinstvu", KategorijeId=3003},
                     new Potkategorije {NazivPotkategorije = "Elektro materijal", KategorijeId=3004},
                     new Potkategorije {NazivPotkategorije = "Građevinske mašine", KategorijeId=3004},
                     new Potkategorije {NazivPotkategorije = "Građevinski materijal", KategorijeId=3004},
                     new Potkategorije {NazivPotkategorije = "Keramika, sanitarija", KategorijeId=3004},
                     new Potkategorije {NazivPotkategorije = "Usluge u građevinarstvu", KategorijeId=3004},
                     new Potkategorije {NazivPotkategorije = "Birotehnička oprema", KategorijeId=3005},
                     new Potkategorije {NazivPotkategorije = "Goriva i maziva", KategorijeId=3005},
                     new Potkategorije {NazivPotkategorije = "Mašine i alati", KategorijeId=3005},
                     new Potkategorije {NazivPotkategorije = "Zaštitna oprema i uređaju", KategorijeId=3005},
                };
                foreach (Potkategorije p in Potkategorije)
                {
                    context.Potkategorije.Add(p);
                }
                context.SaveChanges();
            }



            if (context.Gradovi.Count() == 0)
            {
                var Gradovi = new Gradovi[]
                {
                         new Models.Gradovi {ImeGrada="Beograd"},
                         new Models.Gradovi {ImeGrada="Novi Sad"},
                         new Models.Gradovi {ImeGrada="Niš"},
                };
                foreach (Gradovi g in Gradovi)
                {
                    context.Gradovi.Add(g);
                }
                context.SaveChanges();
            }

            if (context.OglasiPotkategorije.Count() == 0)
            {
                var OglasiPotkategorije = new OglasiPotkategorije[]
                   {
                         new Models.OglasiPotkategorije {OglasiId=34, PotkategorijeId=50},
                         new Models.OglasiPotkategorije {OglasiId=36, PotkategorijeId=45},
                         new Models.OglasiPotkategorije {OglasiId=35, PotkategorijeId=47},
                         new Models.OglasiPotkategorije {OglasiId=36, PotkategorijeId=48},
                         new Models.OglasiPotkategorije {OglasiId=37, PotkategorijeId=54},
                         new Models.OglasiPotkategorije {OglasiId=38, PotkategorijeId=54},
                         new Models.OglasiPotkategorije {OglasiId=35, PotkategorijeId=54},
                         new Models.OglasiPotkategorije {OglasiId=36, PotkategorijeId=54},
                         new Models.OglasiPotkategorije {OglasiId=36, PotkategorijeId=52},
                         new Models.OglasiPotkategorije {OglasiId=34, PotkategorijeId=54},

                   };
                foreach (OglasiPotkategorije og in OglasiPotkategorije)
                {

                    context.OglasiPotkategorije.Add(og);
                }
                context.SaveChanges();
            }

            if (context.Oglasi.Count() == 0)
            {
                var Oglasi = new Models.Oglasi[]
                {
                new  Models.Oglasi {Naslov="Oglas1", DatumObjave=new DateTime(2018, 03, 22).Date,
                    DatumIsteka =new DateTime(2018, 04, 27), GradoviId=2, Cena=3000, TekstOglasa="Oglas1"},
                new  Models.Oglasi {Naslov="Oglas2", DatumObjave=new DateTime(2018, 03, 21).Date,
                    DatumIsteka =new DateTime(2018, 04, 25), GradoviId=1, Cena=3000, TekstOglasa="Oglas2"},
                new  Models.Oglasi {Naslov="Oglas3", DatumObjave=new DateTime(2018, 03, 20).Date,
                    DatumIsteka =new DateTime(2018, 04, 27), GradoviId=3, Cena=3000, TekstOglasa="Oglas3"},
                new  Models.Oglasi {Naslov="Oglas4", DatumObjave=new DateTime(2018, 03, 28).Date,
                    DatumIsteka =new DateTime(2018, 04, 27), GradoviId=2, Cena=3000, TekstOglasa="Oglas4"},
                new  Models.Oglasi {Naslov="Oglas5", DatumObjave=new DateTime(2018, 03, 15).Date,
                    DatumIsteka =new DateTime(2018, 04, 27), GradoviId=2, Cena=3000, TekstOglasa="Oglas5"},
                 new  Models.Oglasi {Naslov="Oglas6", DatumObjave=new DateTime(2018, 03, 24).Date,
                    DatumIsteka =new DateTime(2018, 04, 27), GradoviId=2, Cena=3000, TekstOglasa="Oglas6"}
                };

                foreach (Models.Oglasi o in Oglasi)
                {
                    context.Oglasi.Add(o);
                }
                context.SaveChanges();
            }
        }
    }
}
