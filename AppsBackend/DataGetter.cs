using System.Diagnostics;

namespace AppsBackend
{
    public static class DataGetter
    {
        public static int GetIntFromString()
        {
            int integerFromString;
            while (!int.TryParse(Console.ReadLine(), out integerFromString))
            {
                Console.WriteLine("Wpisz liczbę całkowitą:");
            }
            return integerFromString;
        }

        public static decimal GetDecimalFromString()
        {
            decimal decimalFromString;
            while (!decimal.TryParse(Console.ReadLine(), out decimalFromString))
            {
                Console.WriteLine("Wpisana liczba nie jest dziesiętna. Spróbuj jeszcze raz:");
            }
            return decimalFromString;
        }

        public static int GetIntFromString(int lowerLimit, int upperLimit)
        {
            int integerFromStringData = GetIntFromString();
            while (!IsIntInRange(integerFromStringData, lowerLimit, upperLimit))
            {
                Console.WriteLine($"Wpisz liczbę całkowitą z zakresu: {lowerLimit} - {upperLimit}");
                integerFromStringData = GetIntFromString();
            }
            return integerFromStringData;
        }

        public static int GetGreaterIntFromString(int lowerLimit)
        {
            int integerFromStringData = GetIntFromString();
            while (!IsIntGreater(integerFromStringData, lowerLimit))
            {
                Console.WriteLine($"Wpisz liczbę całkowitą większą bądź równą {lowerLimit}.");
                integerFromStringData = GetIntFromString();
            }
            return integerFromStringData;
        }

        public static int GetLessIntFromString(int upperLimit)
        {
            int integerFromStringData = GetIntFromString();
            while (!IsIntLess(integerFromStringData, upperLimit))
            {
                Console.WriteLine($"Wpisz liczbę całkowitą mniejszą bądź równą {upperLimit}.");
                integerFromStringData = GetIntFromString();
            }
            return integerFromStringData;
        }

        public static bool IsIntInRange(int inputInteger, int lowerLimit, int upperLimit)
        {            
            return (inputInteger >= lowerLimit && inputInteger <= upperLimit);
        }

        public static bool IsIntGreater(int inputInteger, int lowerLimit)
        {
            return (inputInteger >= lowerLimit);
        }

        public static bool IsIntLess(int inputInteger, int upperLimit)
        {
            return (inputInteger <= upperLimit);
        }

        public static string SetSpacesInEnum(Enum enumValue)
        {
            return enumValue.ToString().Replace("_", " ");
        }
    }
    
}