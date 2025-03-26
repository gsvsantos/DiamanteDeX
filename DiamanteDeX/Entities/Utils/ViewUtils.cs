using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
