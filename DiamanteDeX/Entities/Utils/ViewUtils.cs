namespace DiamanteDeX.Entities.Utils
{
    public class ViewUtils
    {
        public static void PaintWriteLine(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PaintWrite(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
        public static void Header()
        {
            Console.Clear();
            PaintWriteLine("/=-=-=-=-=-=-=-=-=-=-=-=\\");
            PaintWriteLine("      Diamante de X", ConsoleColor.Cyan);
            PaintWriteLine("\\=-=-=-=-=-=-=-=-=-=-=-=/");
        }
        public static void PressEnter(string type)
        {
            switch (type)
            {
                case "USAR-NOVAMENTE":
                    PaintWrite("\nPressione [Enter] para usar novamente.", ConsoleColor.Yellow);
                    Console.ReadKey();
                    break;
            }
        }
        public static int GetNumber()
        {
            int input = Validators.IntVerify("\nPor favor, digite um número inteiro para dar início ao desenho do diamante: ", 2);
            return input;
        }
    }
}
