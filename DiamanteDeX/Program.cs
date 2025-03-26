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
                Diamond.QuantityOfX = ViewUtils.GetNumber();
                Validators.OddOrEven();
                ViewUtils.PaintWriteLine($"\nO número ímpar escolhido é: {Diamond.QuantityOfX}\n", ConsoleColor.Green);

                Diamond.Draw();

                ViewUtils.PressEnter("USAR-NOVAMENTE");
            }while (true);
        }
    }
}
