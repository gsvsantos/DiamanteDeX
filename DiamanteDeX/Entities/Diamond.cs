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
                Console.Write(new string('X', i));
                Console.WriteLine();
            }
        }
        public static void MiddlePart()
        {
            Console.WriteLine(new string('X', Diamond.QuantityOfX));
        }
    }
}
