using System;

namespace Visitekaartje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je voornaam?");
            string Voornaam;
            Voornaam = Console.ReadLine();
            Console.WriteLine("Wat is je achternaam?");
            string Achternaam;
            Achternaam = Console.ReadLine();
            Console.WriteLine("In welke straat woon je?");
            string Straat;
            Straat = Console.ReadLine();
            Console.WriteLine("Wat is je huisnummer?");
            string Nummer;
            Nummer = Console.ReadLine();
            Console.WriteLine("In welke gemeente woon je?");
            string Stad;
            Stad = Console.ReadLine();

            Console.WriteLine("Wat is je postcode?");
            string Postcode;
            Postcode = Console.ReadLine();
            string Naam = Voornaam + (" ") + Achternaam;
            string Adres = Straat + (" ")+ Nummer + (",") + Stad;

            Console.WriteLine("Postcode: " + Postcode);
            Console.WriteLine("Naam: " + Naam);
            Console.WriteLine("Adres: " + Adres);





        }   }

}
