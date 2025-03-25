using DiamanteDeX.Entities.Utils;

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
                number = GetNumber();
                OddOrEven();
                Console.Write($"\nO número ímpar escolhido é: {number}");
                Console.ReadKey();
            }while (true);
        }
        static int GetNumber()
        {
            int input = Validators.IntVerify("\nPor favor, digite um número inteiro para dar início ao desenho do diamante: ", 0, 50);
            return input;
        }
        static void OddOrEven()
        {
            do
            {
                if (OddOrEvenCheck())
                {
                    Console.WriteLine($"\nEsse número é par! Precisa ser um número ímpar!");
                    number = GetNumber();
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
