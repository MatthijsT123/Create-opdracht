using Create_back_end_opdracht.Helper;
using System.Linq;

namespace Create_back_end_opdracht
{
    internal class NumberLengthLiberary
    {   
        private readonly Dictionary<int, string> numbers = new Dictionary<int, string>()
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
            { 21, ConstString.eenen + ConstString.twintig},
            { 22, ConstString.tweeën + ConstString.twintig},
            { 23, ConstString.drieën + ConstString.twintig},
            { 24, ConstString.vieren + ConstString.twintig},
            { 25, ConstString.vijfen + ConstString.twintig},
            { 26, ConstString.zesen + ConstString.twintig},
            { 27, ConstString.zevenen + ConstString.twintig},
            { 28, ConstString.achten + ConstString.twintig},
            { 29, ConstString.negenen + ConstString.twintig},
            { 30, ConstString.dertig},
            { 31, ConstString.eenen + ConstString.dertig},
            { 32, ConstString.tweeën + ConstString.dertig},
            { 33, ConstString.drieën + ConstString.dertig},
            { 34, ConstString.vieren + ConstString.dertig},
            { 35, ConstString.vijfen + ConstString.dertig},
            { 36, ConstString.zesen + ConstString.dertig},
            { 37, ConstString.zevenen + ConstString.dertig},
            { 38, ConstString.achten + ConstString.dertig},
            { 39, ConstString.negenen + ConstString.dertig},
            { 40, ConstString.veertig},
            { 41, ConstString.eenen + ConstString.veertig},
            { 42, ConstString.tweeën + ConstString.veertig},
            { 43, ConstString.dertig + ConstString.veertig},
            { 44, ConstString.vieren + ConstString.veertig},
            { 45, ConstString.vijfen + ConstString.veertig},
            { 46, ConstString.zesen + ConstString.veertig},
            { 47, ConstString.zevenen + ConstString.veertig},
            { 48, ConstString.achten + ConstString.veertig},
            { 49, ConstString.negenen + ConstString.veertig},
            { 50, ConstString.vijftig},
            { 51, ConstString.eenen + ConstString.vijftig},
            { 52, ConstString.tweeën + ConstString.vijftig},
            { 53, ConstString.drieën + ConstString.vijftig},
            { 54, ConstString.vieren + ConstString.vijftig},
            { 55, ConstString.vijfen + ConstString.vijftig},
            { 56, ConstString.zesen + ConstString.vijftig},
            { 57, ConstString.zevenen + ConstString.vijftig},
            { 58, ConstString.achten + ConstString.vijftig},
            { 59, ConstString.negenen + ConstString.vijftig},
            { 60, ConstString.zestig},
            { 61, ConstString.eenen + ConstString.zestig},
            { 62, ConstString.tweeën + ConstString.zestig},
            { 63, ConstString.drieën + ConstString.zestig},
            { 64, ConstString.vieren + ConstString.zestig},
            { 65, ConstString.vijfen + ConstString.zestig},
            { 66, ConstString.zesen + ConstString.zestig},
            { 67, ConstString.zevenen + ConstString.zestig},
            { 68, ConstString.achten + ConstString.zestig},
            { 69, ConstString.negenen + ConstString.zestig},
            { 70, ConstString.zevenen},
            { 71, ConstString.eenen + ConstString.zevenen},
            { 72, ConstString.tweeën + ConstString.zevenen},
            { 73, ConstString.drieën + ConstString.zevenen},
            { 74, ConstString.vieren + ConstString.zevenen},
            { 75, ConstString.vijfen + ConstString.zevenen},
            { 76, ConstString.zesen + ConstString.zevenen},
            { 77, ConstString.zevenen + ConstString.zevenen},
            { 78, ConstString.achten + ConstString.zevenen},
            { 79, ConstString.negenen + ConstString.zevenen},
            { 80, ConstString.tachtig},
            { 81, ConstString.eenen + ConstString.tachtig},
            { 82, ConstString.tachtig + ConstString.tachtig},
            { 83, ConstString.drieën + ConstString.tachtig},
            { 84, ConstString.vieren + ConstString.tachtig},
            { 85, ConstString.vijfen + ConstString.tachtig},
            { 86, ConstString.zesen + ConstString.tachtig},
            { 87, ConstString.zevenen + ConstString.tachtig},
            { 88, ConstString.achten + ConstString.tachtig},
            { 89, ConstString.negenen + ConstString.tachtig},
            { 90, ConstString.negentig},
            { 91, ConstString.eenen + ConstString.negentig},
            { 92, ConstString.tweeën + ConstString.negentig},
            { 93, ConstString.drieën + ConstString.negentig},
            { 94, ConstString.vieren + ConstString.negentig},
            { 95, ConstString.vijfen + ConstString.negentig},
            { 96, ConstString.zesen + ConstString.negentig},
            { 97, ConstString.zevenen + ConstString.negentig},
            { 98, ConstString.achten + ConstString.negentig},
            { 99, ConstString.negenen + ConstString.negentig},
            { 100, ConstString.honderd},
        };

        public Dictionary<int, string> GetNumbers()
        {
            return numbers;
        }

        public Dictionary<int, string> GetNumbersSection(int beginPoint, int endPoint)
        {
            int test2 = 0;
            var test = numbers.Where(n => n.Key > beginPoint && n.Key < endPoint).ToList().ToList();
            test.ForEach(n => test2 += n.Value.FirstOrDefault().ToString().Length);
        }

    }
}
