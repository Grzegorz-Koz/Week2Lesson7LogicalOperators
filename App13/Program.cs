
/*
 *  Program 13-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
 *  
 */

namespace App13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mathOperations =
            {
                "Dodawanie",
                "Odejmowanie",
                "Mnożenie",
                "Dzielenie"
            };
            Console.WriteLine("Podaj numer operacji, która będzie wykonana na dwóch liczbach.");
            for (int i = 0; i < mathOperations.Length; i++)
            {
                Console.WriteLine(i+1 + " - " + mathOperations[i]);
            }
            Console.WriteLine("Numer operacji:");
            int operationNumber = AppsBackend.DataGetter.GetIntFromString(1, 4);
           
            Console.WriteLine();

            Console.WriteLine($"Wybrałeś: {mathOperations[operationNumber - 1]}\n");
            Console.WriteLine("Podaj pierwszą liczbę:");
            decimal firstNumber = AppsBackend.DataGetter.GetDecimalFromString();
            
            Console.WriteLine("Podaj drugą liczbę:");
            decimal secondNumber = AppsBackend.DataGetter.GetDecimalFromString();
            if (operationNumber == 4)
            {
                while (secondNumber == 0)
                {
                    Console.WriteLine("Dzielnik nie może być równy 0. Spróbuj jeszcze raz:");
                    secondNumber = AppsBackend.DataGetter.GetDecimalFromString();
                }
            }

            decimal resultOfOperation = operationNumber switch
            {
                1 => firstNumber + secondNumber,
                2 => firstNumber - secondNumber,
                3 => firstNumber * secondNumber,
                4 => firstNumber / secondNumber,
            };
            Console.WriteLine($"\nWynik działania: {resultOfOperation}");

            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}