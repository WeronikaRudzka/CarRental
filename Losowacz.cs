using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     public class Losowacz    
    {                
            private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
            
            public static List<int> WygenerujListeLiczbLosowych(int ileLiczb, int maksymalnaWartosc)
            {
                var wynik = new List<int>();
                while (wynik.Count() < ileLiczb)
                {
                    int los = WygenerujLiczbeLosowa(maksymalnaWartosc);
                    if (!wynik.Contains(los))
                    {
                        wynik.Add(los);
                    }
                }
                return wynik;
            }                   
            public static int WygenerujLiczbeLosowa(int maksymalnaWartosc)
            {
                byte[] randomNumber = new byte[1];
                _generator.GetBytes(randomNumber);
                double asciiValueOfRandomChar = Convert.ToDouble(randomNumber[0]);
                double multiplier = Math.Max(0, (asciiValueOfRandomChar / 255d) - 0.00000000001d);
                double randomVAlueInRange = Math.Floor(multiplier * maksymalnaWartosc);
                return (int)(1 + randomVAlueInRange);
            }
     }
}
