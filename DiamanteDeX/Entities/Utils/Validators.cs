using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.Entities.Utils
{
    internal class Validators
    {
        public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"'{input}' não é um número...");
                    continue;
                }
                input = input.Trim();
                if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
                {
                    Console.WriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!");
                    continue;
                }
                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("O valor digitado não é um número válido.");
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    Console.WriteLine($"O valor deve estar entre 1 e {maxValue}.");
                    continue;
                }
                return value;
            } while (true);
        }
    }
}
