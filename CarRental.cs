using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class CarRental
    {
        public Program program = new Program();
        public CarRental()
        {
            /*WygenerujSamochody();*/
            WygenerujOfertyStartowe();          
        }

        public List<Oferta> OfertyStartowe { get; set; }
        public List<Samochod> BazaSamochodow { get; set; }
        public Samochod Samochod { get; set; }
        public List<Samochod> Samochody { get;  set; }

        public void WygenerujOfertyStartowe()
        {
            OfertyStartowe = new List<Oferta>();
            List<int> numerki = Losowacz.WygenerujListeLiczbLosowych(3, 20);
            Samochod sam1 = Samochody[numerki[0] - 1];
            Samochod sam2 = Samochody[numerki[1] - 1];
            Samochod sam3 = Samochody[numerki[2] - 1];

            Oferta o1 = new Oferta();
            o1.Id = 1;
            o1.Samochod = sam1;
            o1.Samochod.Cena = ((o1.Samochod.Cena) * 0.8m);
            OfertyStartowe.Add(o1);

            Oferta o2 = new Oferta();
            o2.Id = 2;
            o2.Samochod = sam2;
            o2.Samochod.Cena = ((o2.Samochod.Cena) * 0.8m);
            OfertyStartowe.Add(o2);

            Oferta o3 = new Oferta();
            o3.Id = 3;
            o3.Samochod = sam3;
            o3.Samochod.Cena = ((o3.Samochod.Cena) * 0.8m);
            OfertyStartowe.Add(o3);

        }

        /*public void WygenerujSamochody()
        {
            Samochody = new List<Samochod>();

            Samochod sam1 = new Samochod();
            sam1.Id = 1;
            sam1.Marka = "Dodge";
            sam1.Model = "Challenger R/T - 1970";
            sam1.KlasaSamochodu = "Premium";
            sam1.RodzajNapedu = "Benzyna";
            sam1.Cena = 1320;
            Samochody.Add(sam1);

            Samochod sam2 = new Samochod();
            sam2.Id = 2;
            sam2.Marka = "Chevrolet";
            sam2.Model = "Camaro - 1969";
            sam2.KlasaSamochodu = "Premium";
            sam2.RodzajNapedu = "Benzyna";
            sam2.Cena = 1500;
            Samochody.Add(sam2);

            Samochod sam3 = new Samochod();
            sam3.Id = 3;
            sam3.Marka = "Fiat";
            sam3.Model = "130 Coupe - 1974";
            sam3.KlasaSamochodu = "Premium";
            sam3.RodzajNapedu = "Benzyna";
            sam3.Cena = 300;
            Samochody.Add(sam3);

            Samochod sam4 = new Samochod();
            sam4.Id = 4;
            sam4.Marka = "BMW";
            sam4.Model = "2800 E3 - 1970";
            sam4.KlasaSamochodu = "Premium";
            sam4.RodzajNapedu = "Benzyna";
            sam4.Cena = 425;
            Samochody.Add(sam4);

            Samochod sam5 = new Samochod();
            sam5.Id = 5;
            sam5.Marka = "Porshe";
            sam5.Model = "911 Carrera 977 - 2005";
            sam5.KlasaSamochodu = "Premium";
            sam5.RodzajNapedu = "Benzyna";
            sam5.Cena = 1400;
            Samochody.Add(sam5);

            Samochod sam6 = new Samochod();
            sam6.Id = 6;
            sam6.Marka = "Volkswagen";
            sam6.Model = "Garbus - 1966";
            sam6.KlasaSamochodu = "Mini";
            sam6.RodzajNapedu = "Benzyna";
            sam6.Cena = 250;
            Samochody.Add(sam6);

            Samochod sam7 = new Samochod();
            sam7.Id = 7;
            sam7.Marka = "Fiat";
            sam7.Model = "126 Silver - 1979";
            sam7.KlasaSamochodu = "Mini";
            sam7.RodzajNapedu = "Benzyna";
            sam7.Cena = 180;
            Samochody.Add(sam7);

            Samochod sam8 = new Samochod();
            sam8.Id = 8;
            sam8.Marka = "Mercedes";
            sam8.Model = "280 SE 4.5 W108 - 1973";
            sam8.KlasaSamochodu = "Premium";
            sam8.RodzajNapedu = "Benzyna";
            sam8.Cena = 480;
            Samochody.Add(sam8);

            Samochod sam9 = new Samochod();
            sam9.Id = 9;
            sam9.Marka = "Volvo";
            sam9.Model = "PV544 Sport - 1961";
            sam9.KlasaSamochodu = "Premium";
            sam9.RodzajNapedu = "Benzyna";
            sam9.Cena = 195;
            Samochody.Add(sam9);

            Samochod sam10 = new Samochod();
            sam10.Id = 10;
            sam10.Marka = "Mercedes";
            sam10.Model = "280 SE W108 - 1969";
            sam10.KlasaSamochodu = "Premium";
            sam10.RodzajNapedu = "Benzyna";
            sam10.Cena = 650;
            Samochody.Add(sam10);

            Samochod sam11 = new Samochod();
            sam11.Id = 11;
            sam11.Marka = "Triumph";
            sam11.Model = "Spitfire 1500 - 1975";
            sam11.KlasaSamochodu = "Compact";
            sam11.RodzajNapedu = "Benzyna";
            sam11.Cena = 1500;
            Samochody.Add(sam11);

            Samochod sam12 = new Samochod();
            sam12.Id = 12;
            sam12.Marka = "Alfa Romeo";
            sam12.Model = "Nestor - 2010";
            sam12.KlasaSamochodu = "Premium";
            sam12.RodzajNapedu = "Benzyna";
            sam12.Cena = 750;
            Samochody.Add(sam12);

            Samochod sam13 = new Samochod();
            sam13.Id = 13;
            sam13.Marka = "Dodge";
            sam13.Model = "Charger - 1973";
            sam13.KlasaSamochodu = "Premium";
            sam13.RodzajNapedu = "Benzyna";
            sam13.Cena = 1865;
            Samochody.Add(sam13);

            Samochod sam14 = new Samochod();
            sam14.Id = 14;
            sam14.Marka = "Ford";
            sam14.Model = "Mustang - 1969";
            sam14.KlasaSamochodu = "Premium";
            sam14.RodzajNapedu = "Benzyna";
            sam14.Cena = 2350;
            Samochody.Add(sam14);

            Samochod sam15 = new Samochod();
            sam15.Id = 15;
            sam15.Marka = "Cadillac";
            sam15.Model = "DeVille Cabriolet - 1965";
            sam15.KlasaSamochodu = "Premium";
            sam15.RodzajNapedu = "Benzyna";
            sam15.Cena = 3450;
            Samochody.Add(sam15);

            Samochod sam16 = new Samochod();
            sam16.Id = 16;
            sam16.Marka = "Citroën";
            sam16.Model = "Charleston - 1987";
            sam16.KlasaSamochodu = "Premium";
            sam16.RodzajNapedu = "Benzyna";
            sam16.Cena = 1236;
            Samochody.Add(sam16);

            Samochod sam17 = new Samochod();
            sam17.Id = 17;
            sam17.Marka = "Ford";
            sam17.Model = "Mustang - 1967";
            sam17.KlasaSamochodu = "Premium";
            sam17.RodzajNapedu = "Benzyna";
            sam17.Cena = 867;
            Samochody.Add(sam17);

            Samochod sam18 = new Samochod();
            sam18.Id = 18;
            sam18.Marka = "Bentley";
            sam18.Model = "T2 - 1980";
            sam18.KlasaSamochodu = "Premium";
            sam18.RodzajNapedu = "Benzyna";
            sam18.Cena = 3289;
            Samochody.Add(sam18);

            Samochod sam19 = new Samochod();
            sam19.Id = 19;
            sam19.Marka = "Chevrolet";
            sam19.Model = "Corvette - 1982";
            sam19.KlasaSamochodu = "Premium";
            sam19.RodzajNapedu = "Benzyna";
            sam19.Cena = 1010;
            Samochody.Add(sam19);

            Samochod sam20 = new Samochod();
            sam20.Id = 20;
            sam20.Marka = "Volkswagen";
            sam20.Model = "Käfer Herbie - 1969";
            sam20.KlasaSamochodu = "Premium";
            sam20.RodzajNapedu = "mini";
            sam20.Cena = 1884;
            Samochody.Add(sam20);
        }*/
    }
}
