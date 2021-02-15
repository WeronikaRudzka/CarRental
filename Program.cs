using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
    public class Program
    {

        static void Main(string[] args)
        {
            CarRental carRental = new CarRental();
            Samochod samochod = new Samochod();
            DateTime data = DateTime.UtcNow.ToLocalTime(); 

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("   Witamy w wypożyczalni samochodów");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" ");


            /*WyswietlOferte(carRental.WylosujOferte();



            string WyswietlOferte(Oferta oferta)
            {
                Console.WriteLine($"Oferta1 {oferta.Oferty}");
                Console.WriteLine(oferta.Samochody);
                Console.WriteLine();
            }*/



            //oferty startowe            


            Console.Write("Podaj klasę pojazdu: " + samochod.KlasaSamochodu );
            Console.WriteLine(samochod.KlasaSamochodu);
            Console.Write("\n\n ");
            string klasa = Console.ReadLine();

            Console.Write("\nPodaj markę pojazdu (mercedes, fiat, dodge, chevrolet, volkswagen, porshe, bmw, ford:");           
            Console.Write("\n\n "); 
            string marka = Console.ReadLine();

            Console.Write("\nPodaj rodzaj napędu (benzyna, gaz, diesel:");           
            Console.Write("\n\n ");
            string naped = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("   Witamy w wypożyczalni samochodów");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Na ile dni chcesz wypożyczyć samochód?");
            double czaswypozyczenia;
            Console.Write("\n\n ");
            czaswypozyczenia = Console.Read();
            




            /* if (odpowiedzUzytkownika ==*/


            //podsumowanie
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("   Witamy w wypożyczalni samochodów");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" ");

            Console.WriteLine(marka);
            Console.WriteLine("\nKlasa: "+ klasa);
            Console.WriteLine("\nTyp napędu: " + naped);
            Console.WriteLine("\nData wynajmu: " + data );
            Console.WriteLine("\nData zwrotu: " + data.AddDays(czaswypozyczenia));

                       


            Console.ReadKey();
        }

       
    }           


           
}





    
 


