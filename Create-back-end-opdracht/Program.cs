namespace Create_back_end_opdracht
{
    public class Program
    {
        private static readonly NumberLengthLiberary _numberLengthLiberary = new NumberLengthLiberary();

        public static void Main(string[] args)
        {
            int oneToFive = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 5);
            Console.WriteLine("1 t/m 5: " + oneToFive + " letters.");
            int oneToHunderd = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 100);
            Console.WriteLine("1 t/m 100: " + oneToHunderd + " letters.");
            int oneToThousand = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 1000);
            Console.WriteLine("1 t/m 1000: " + oneToThousand + " letters.");
            int oneToTenThousand = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 10000);
            Console.WriteLine("1 t/m 10000: " + oneToTenThousand + " letters.");
            int oneToHundredThousand = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 100000);
            Console.WriteLine("1 t/m 100000: " + oneToHundredThousand + " letters.");
            int oneToMillion = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 1000000);
            Console.WriteLine("1 t/m 1000000: " + oneToMillion + " letters.");
            
        }
    }
}
