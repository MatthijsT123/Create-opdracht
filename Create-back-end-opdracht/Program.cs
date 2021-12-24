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
            var test = _numberLengthLiberary.GetNumbers();
            test.Where(n => n.Key < 10 && n.Key > 50);
            Console.WriteLine("Hello World!");
        }
    }
}
