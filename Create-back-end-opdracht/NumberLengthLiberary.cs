namespace Create_back_end_opdracht
{
    internal class NumberLengthLiberary
    {   
        public NumberLengthLiberary()
        {
            GenerateNumbers();
        }

        private readonly Dictionary<int, string> _numbersOneToNine = new Dictionary<int, string>()
        {
            { 1, "eenen"},
            { 2, "tweeën"},
            { 3, "drieën"},
            { 4, "vieren"},
            { 5, "vijfen"},
            { 6, "zesen"},
            { 7, "zevenen"},
            { 8, "achten"},
            { 9, "negenen"},
        };

        private readonly Dictionary<int, string> _numbers = new Dictionary<int, string>()
        {
            { 1, "een"},
            { 2, "twee"},
            { 3, "drie"},
            { 4, "vier"},
            { 5, "vijf"},
            { 6, "zes"},
            { 7, "zeven"},
            { 8, "acht"},
            { 9, "negen"},
            { 10, "tien"},
            { 11, "elf"},
            { 12, "twaalf"},
            { 13, "dertien"},
            { 14, "veertien"},
            { 15, "vijftien"},
            { 16, "zestien"},
            { 17, "zeventien"},
            { 18, "achttien"},
            { 19, "negentien"},
            { 20, "twintig"},
            { 30, "dertig"},
            { 40, "veertig"},
            { 50, "vijftig"},
            { 60, "zestig"},
            { 70, "zeventig"},
            { 80, "tachtig"},
            { 90, "negentig"},
            { 100, "honderd"},
            { 1000, "duizend"},
            { 1000000, "miljoen" },
        };


        internal Dictionary<int, string> GetNumbers()
        {
            return _numbers;
        }

        internal List<KeyValuePair<int, string>> GetNumbersSection(int beginPoint, int endPoint)
        {
            if(beginPoint < 0 || beginPoint >= endPoint) return null;
            if(endPoint < 1 || endPoint >= _numbers.Count() + 1) return null;

            return _numbers.Where(n => n.Key >= beginPoint && n.Key <= endPoint).ToList().ToList();
        }

        internal int GetTotalAmountOfCharacters(int beginPoint, int endPoint)
        {
            int totalAmountOfCharacters = 0;

            List<KeyValuePair<int, string>> listOfNumbers = GetNumbersSection(beginPoint, endPoint);

            if(listOfNumbers == null) return 0;

            foreach (KeyValuePair<int, string> numberItem in listOfNumbers)
            {
               string numberValue = numberItem.Value.ToString();
               string numberValueWithoutSpaces = String.Concat(numberValue.Where(c => !Char.IsWhiteSpace(c)));
               totalAmountOfCharacters += numberValueWithoutSpaces.Length;
            }

            return totalAmountOfCharacters;
        }

        private void GenerateNumbers()
        {
            for (int i = 100; i > 20; i--)
            {
                if (i % 100 != 0)
                {
                    if (i % 10 != 0)
                    {
                        _numbers.Add(i, _numbersOneToNine.GetValueOrDefault(i % 10) + _numbers.GetValueOrDefault(i - (i % 10)));
                    }
                }
            }

            for (int i = 101; i < 1000; i++)
            {
                if (i % 100 == 0)
                {
                    _numbers.Add(i, _numbers.GetValueOrDefault(i / 100) + _numbers.GetValueOrDefault(100) + _numbers.GetValueOrDefault(i));
                }
                else
                {
                    _numbers.Add(i, _numbers.GetValueOrDefault(i - (i % 100)) + _numbers.GetValueOrDefault(i % 100));
                }
            }

            for(int i = 1001; i < 1000000; i++)
            {
                if (i % 1000 == 0)
                {
                    _numbers.Add(i, _numbers.GetValueOrDefault(i / 1000) + _numbers.GetValueOrDefault(1000) + _numbers.GetValueOrDefault(i));
                }
                else
                {
                    _numbers.Add(i, _numbers.GetValueOrDefault(i - (i % 1000)) + " " + _numbers.GetValueOrDefault(i % 1000));
                }
            }
        }
    }
}
