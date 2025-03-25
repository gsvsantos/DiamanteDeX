using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.Entities.Utils
{
    public class Validators
    {
        public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
        {
            do
            {
                ViewUtils.PaintWrite(prompt);
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewUtils.PaintWriteLine($"'{input}' não é um número...", ConsoleColor.Red);
                    continue;
                }
                input = input.Trim();
                if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
                {
                    ViewUtils.PaintWriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!", ConsoleColor.Red);
                    continue;
                }
                if (!int.TryParse(input, out int value))
                {
                    ViewUtils.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    ViewUtils.PaintWriteLine($"O valor deve estar entre 1 e {maxValue}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
    }
}
