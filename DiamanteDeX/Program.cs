using System.Text.Json.Serialization.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamanteDeX
{
    internal class Program
    {
        public static int number;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Projeto - Diamante de X\n");
                number = GetNumber("\nPor favor, digite um número inteiro para dar início ao desenho do diamante: ");
                OddOrEven();
                Console.WriteLine($"\nO número ímpar escolhido é: {number}");
                Console.ReadKey();
            }while (true);
        }
        static int GetNumber(string prompt)
        {
            Console.Write(prompt);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        static void OddOrEven()
        {
            do
            {
                if (OddOrEvenCheck())
                {
                    Console.WriteLine($"\nEsse número é par!");
                    number = GetNumber("\nPor favor, digite um número ímpar: ");
                }
                else
                    break;
            } while (true);
        }
        static bool OddOrEvenCheck()
        {
            return number % 2 == 0;
        }
    }
}
