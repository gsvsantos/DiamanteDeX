﻿using DiamanteDeX.Entities.Utils;

namespace DiamanteDeX.Entities
{
    public class Diamond
    {
        public static int QuantityOfX { get; set; }
        static int quantityOfSpaces;

        public static int SpacesCount()
        {
            for (int i = 1; i < QuantityOfX; i += 2)
            {
                quantityOfSpaces++;
            }
            return quantityOfSpaces;
        }
        public static void UpperPart()
        {
            SpacesCount();
            for (int i = 1; i < QuantityOfX; i += 2)
            {
                for (int j = quantityOfSpaces; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                quantityOfSpaces--;
                ViewUtils.PaintWrite(new string('X', i), ConsoleColor.Red);
                Console.WriteLine();
            }
        }
        public static void MiddlePart()
        {
            ViewUtils.PaintWrite(new string('X', Diamond.QuantityOfX), ConsoleColor.White);
            Console.WriteLine();
        }
        public static void LowerPart()
        {
            SpacesCount();
            int oldQuantityOfSpaces = quantityOfSpaces;
            for ( int i = QuantityOfX - 2; i < QuantityOfX; i -= 2)
            {
                for (int j = quantityOfSpaces; j <= oldQuantityOfSpaces; j++)
                {
                    if (j == 0)
                        break;
                    Console.Write(" ");
                }
                quantityOfSpaces--;
                if (i < 0)
                    break;
                ViewUtils.PaintWrite(new string('X', i), ConsoleColor.Red);
                Console.WriteLine();
            }
        }
    }
}
