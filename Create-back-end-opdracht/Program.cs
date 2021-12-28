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
            _numberLengthLiberary.GenerateNumbers();
        }
    }
}
