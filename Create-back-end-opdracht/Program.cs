using System;
using System.Collections.Generic;
using System.Linq;

namespace Create_back_end_opdracht
{
    public class Program
    {
        private static readonly NumberLengthLiberary _numberLengthLiberary = new NumberLengthLiberary();

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            int oneToFive = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 5);
            Console.WriteLine("1 tot 5 is: " + oneToFive);
            int oneToHunderd = _numberLengthLiberary.GetTotalAmountOfCharacters(1, 100);
            Console.WriteLine("1 tot 100 is: " + oneToHunderd);
        }
    }
}
