using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class Oferta
    {
        
        public int Id { get; set; }
        public Samochod Samochod { get; set; }
        public List<Samochod> Samochody { get; set; }
        public List<Oferta> Oferty { get; set; }


    }
}
