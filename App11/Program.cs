
/*
*  Program 11-ty z ćwiczeń, z tygodnia "TYDZIEŃ 2" z lekcji "LEKCJA 7 – Operatory Logiczne"
*  
*/

namespace App11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade (1-6):");
            int grade = int.Parse(Console.ReadLine());
            string yourgGade;
            switch (grade)
            {
                case 1:
                    yourgGade = "Niedostateczny";
                    break;
                case 2:
                    yourgGade = "Dopuszczający";
                    break;
                case 3:
                    yourgGade = "Dostateczny";
                    break;
                case 4:
                    yourgGade = "Dobry";
                    break;
                case 5:
                    yourgGade = "Bardzo dobry";
                    break;
                case 6:
                    yourgGade = "Celujący";
                    break;
                default:
                    yourgGade = "Nie ma takiej oceny!";
                    break;

            }
            Console.WriteLine($"Your grade is: {yourgGade}");
        }
    }
}