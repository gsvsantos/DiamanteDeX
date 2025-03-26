namespace DiamanteDeX.Entities.Utils

{
    public class ViewWriteErrors
    {
        public static void IsNotANumber(string input)
        {
            ViewColors.PaintWriteLine($"'{input}' não é um número...", ConsoleColor.Red);
        }
        public static void NumberWithChar()
        {
            ViewColors.PaintWriteLine("O valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!", ConsoleColor.Red);
        }
        public static void InvalidNumber()
        {
            ViewColors.PaintWriteLine("O valor digitado não é um número válido.", ConsoleColor.Red);
        }
        public static void NumberBetweenMinAndMax(int maxValue)
        {
            ViewColors.PaintWriteLine($"O valor deve estar entre 3 e {maxValue}.", ConsoleColor.Red);
        }
        public static void IsNotAEven()
        {
            ViewColors.PaintWriteLine($"\nEsse número é inválido! Tente novamente.", ConsoleColor.Red);
        }
    }
}
