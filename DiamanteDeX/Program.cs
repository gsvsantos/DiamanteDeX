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
                ViewUtils.Header();
                number = GetNumber();
                OddOrEven();
                ViewUtils.PaintWrite($"\nO número ímpar escolhido é: {number}", ConsoleColor.Green);
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
                    ViewUtils.PaintWriteLine($"\nEsse número é par! Precisa ser um número ímpar!", ConsoleColor.Red);
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
