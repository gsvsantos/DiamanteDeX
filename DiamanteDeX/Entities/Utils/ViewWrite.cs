namespace DiamanteDeX.Entities.Utils
{
    public class ViewWrite
    {
        public static void Header()
        {
            Console.Clear();
            ViewColors.PaintWriteLine("/=-=-=-=-=-=-=-=-=-=-=-=\\");
            ViewColors.PaintWriteLine("      Diamante de X", ConsoleColor.Cyan);
            ViewColors.PaintWriteLine("\\=-=-=-=-=-=-=-=-=-=-=-=/");
        }
        public static void NumberChose()
        {
            ViewColors.PaintWriteLine($"\nO número escolhido é: {Diamond.QuantityOfX}\n", ConsoleColor.Green);
        }
    }
}