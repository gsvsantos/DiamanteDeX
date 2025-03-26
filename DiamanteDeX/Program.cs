using DiamanteDeX.Entities;
using DiamanteDeX.Entities.Utils;

namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ViewUtils.Header();
                Diamond.QuantityOfX = 11;
                OddOrEven();
                ViewUtils.PaintWriteLine($"\nO número ímpar escolhido é: {Diamond.QuantityOfX}\n", ConsoleColor.Green);
                Diamond.UpperPart();
                Diamond.MiddlePart();


                ViewUtils.PressEnter("CONTINUAR");
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
                    Diamond.QuantityOfX = GetNumber();
                }
                else
                    break;
            } while (true);
        }
        static bool OddOrEvenCheck()
        {
            return Diamond.QuantityOfX % 2 == 0;
        }
    }
}
