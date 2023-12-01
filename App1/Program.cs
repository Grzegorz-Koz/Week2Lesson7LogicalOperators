/*
*  Program 1-szy z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*/

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby całkowite. Sprawdzę, czy są one równe.\n");
            Console.WriteLine("Liczba 1:");
            int firstInt = AppsBackend.DataGetter.GetIntFromString();
            Console.WriteLine("Liczba 2:");
            int secondInt = AppsBackend.DataGetter.GetIntFromString();
            string isEqual = firstInt == secondInt ? "" : "nie ";
            Console.WriteLine($"\nPodane liczby ({firstInt}, {secondInt}) {isEqual}są równe.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}