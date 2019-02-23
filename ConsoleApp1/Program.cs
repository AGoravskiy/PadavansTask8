using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadawansTask8;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "... Merry.  That Is Why We Have A Lot Of  Friends. Test1 - Test1";
            WordsManipulation.RemoveDuplicateWords(ref s);
            Console.WriteLine(s);
        }
    }
}
