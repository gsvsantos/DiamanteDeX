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
                    ViewWrite.IsNotANumber(input);
                    continue;
                }
                input = input.Trim();
                if (input.Contains(' ') || input.Contains('.') || input.Contains(','))
                {
                    ViewWrite.NumberWithChar();
                    continue;
                }
                if (!int.TryParse(input, out int value))
                {
                    ViewWrite.InvalidNumber();
                    continue;
                }
                if (value <= minValue || value > maxValue)
                {
                    ViewWrite.NumberBetweenMinAndMax(maxValue);
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
                    ViewWrite.IsNotAEven();
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
