
/*
 *  Program 9-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzisiejszą temperaturę:");
            int temperature = AppsBackend.DataGetter.GetIntFromString();
            string temperatureInfo = temperature switch
            {
                < 0 => "Bardzo zimno.",
                >=0 and <10 => "Zimno.",
                >= 10 and < 20 => "Chłodno.",
                >= 20 and < 30 => "W sam raz.",
                >= 30 and < 40 => "Zaczyna być słabo, bo gorąco.",
                _ => "A weź, wyprowadzam się na Alaskę"
            };
            Console.WriteLine($"\n\'Pogodynka\' mówi: {temperatureInfo}");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}