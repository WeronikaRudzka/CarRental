using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class Samochod
    {
        public Samochod()
        {
            Oferty = new List<Oferta>();
        }

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KlasaSamochodu { get; set; }
        public string RodzajNapedu { get; set; }
        public decimal Cena { get; set; }

        public List<Samochod> Samochody { get; set; }

        public List<Oferta> Oferty { get; set; }


    }
}
