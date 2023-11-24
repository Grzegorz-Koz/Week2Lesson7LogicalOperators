
/*
 *  Program 6-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 *  W tym ćwiczeniu zmieniłem wszystko co w pierwotnej wersji.
 *  
 */

using System.Runtime.CompilerServices;

namespace App6
{
    internal class Program
    {           
        private enum GrowthCategory
        {
            Nie_ma_takiej_kategorii = 0,
            Niski,
            Średni,
            Wysoki
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz, jaki masz wzrost (liczbę całkowitą):");
            int growth = AppsBackend.DataGetter.GetIntFromString();

            GrowthCategory growthCategory = growth switch
            {
                > 0 and <= 140 => GrowthCategory.Niski,
                > 140 and <= 175 => GrowthCategory.Średni,
                > 175 and <= 200 => GrowthCategory.Wysoki,
                _ => GrowthCategory.Nie_ma_takiej_kategorii
            };
            String yourCategory = AppsBackend.DataGetter.SetSpacesInEnum(growthCategory);
            Console.WriteLine($"\nTwoja kategoria wzrostu, to: \'{yourCategory}\'.");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}