using Create_back_end_opdracht.Helper;

namespace Create_back_end_opdracht
{
    internal class NumberLengthLiberary
    {   

        private readonly Dictionary<int, string> _numbersOneToNine = new Dictionary<int, string>()
        {
            { 1, ConstString.eenen},
            { 2, ConstString.tweeën},
            { 3, ConstString.drieën},
            { 4, ConstString.vieren},
            { 5, ConstString.vijfen},
            { 6, ConstString.zesen},
            { 7, ConstString.zevenen},
            { 8, ConstString.achten},
            { 9, ConstString.negenen},
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
            { 20, ConstString.twintig},
            { 30, ConstString.dertig},
            { 40, ConstString.veertig},
            { 50, ConstString.vijftig},
            { 60, ConstString.zestig},
            { 70, ConstString.zeventig},
            { 80, ConstString.tachtig},
            { 90, ConstString.negentig},
            { 100, ConstString.honderd},
        };


        internal Dictionary<int, string> GetNumbers()
        {
            return _numbers;
        }

        internal List<KeyValuePair<int, string>> GetNumbersSection(int beginPoint, int endPoint)
        {
            if(beginPoint < 0 || beginPoint > 99) return null;
            if(endPoint < 1 || endPoint > 100) return null;

            return _numbers.Where(n => n.Key >= beginPoint && n.Key <= endPoint).ToList().ToList();
        }

        internal int GetTotalAmountOfCharacters(int beginPoint, int endPoint)
        {
            int totalAmountOfCharacters = 0;

            List<KeyValuePair<int, string>> listOfNumbers = GetNumbersSection(beginPoint, endPoint);

            listOfNumbers.ForEach( n => totalAmountOfCharacters += n.Value.ToString().Length);
            return totalAmountOfCharacters;
        }

        internal void GenerateNumbers()
        {
            for (int i = 100; i > 20; i--)
            {
                if(i % 100 != 0)
                {
                    if(i % 10 != 0)
                    {
                        _numbers.Add(i, _numbersOneToNine.GetValueOrDefault(i % 10) + _numbers.GetValueOrDefault(i - (i % 10)));
                    }
                }
            }
        }

    }
}
