
/*
 *  Program 12-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App12
{
    internal class Program
    {
        private enum WeekDay
        {
            Poniedziałek = 1,
            Wtorek,
            Środa,
            Czwartek,
            Piątek,
            Sobota,
            Niedziela
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz numer dnia tygodnia (1-7):");
            int dayNumber = AppsBackend.DataGetter.GetIntFromString(1, 7);
            Console.WriteLine($"\nWybrałeś taki dzień tygodnia: {(WeekDay)dayNumber}");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}