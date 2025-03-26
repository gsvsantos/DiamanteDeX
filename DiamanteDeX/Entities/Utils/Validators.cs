namespace DiamanteDeX.Entities.Utils

{
    public class Validators
    {
        public static int IntVerify(string prompt, int minValue = 0, int maxValue = int.MaxValue)
        {
            do
            {
                ViewColors.PaintWrite(prompt);
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                    ViewColors.PaintWriteLine($"'{input}' não é um número...", ConsoleColor.Red);
                    continue;
                }
                input = input.Trim();
                if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
                {
                    ViewColors.PaintWriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!", ConsoleColor.Red);
                    continue;
                }
                if (!int.TryParse(input, out int value))
                {
                    ViewColors.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    ViewColors.PaintWriteLine($"O valor deve estar entre {minValue} e {maxValue}.", ConsoleColor.Red);
                    continue;
                }
                return value;
            } while (true);
        }
        public static void OddOrEven()
        {
            do
            {
                if (OddOrEvenCheck())
                {
                    ViewColors.PaintWriteLine($"\nEsse número é par! Precisa ser um número ímpar!", ConsoleColor.Red);
                    Diamond.QuantityOfX = ViewUtils.GetNumber();
                }
                else
                    break;
            } while (true);
        }
        public static bool OddOrEvenCheck()
        {
            return Diamond.QuantityOfX % 2 == 0;
        }
    }
}
