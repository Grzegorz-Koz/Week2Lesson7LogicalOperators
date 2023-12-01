
/*
*  Program 2-gi z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*  
*/

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą. Sprawdzę, czy jest ona parzysta.\n");
            Console.WriteLine("Liczba:");
            int intToCheck = AppsBackend.DataGetter.GetIntFromString();

            string isEvenNumber = (intToCheck % 2) == 0 ? "" : "nie ";
            Console.WriteLine($"\nPodana liczba ({intToCheck}) {isEvenNumber}jest parzysta.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}