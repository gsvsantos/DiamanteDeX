namespace DiamanteDeX.Entities.Utils

{
    public class ViewUtils
    {
        public static void PressEnter(string type)
        {
            switch (type)
            {
                case "USAR-NOVAMENTE":
                    ViewColors.PaintWrite("\nPressione [Enter] para usar novamente.", ConsoleColor.Yellow);
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
