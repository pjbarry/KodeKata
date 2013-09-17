using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var DayOne = new BinarySearchOne();
            Console.WriteLine(DayOne.chop(5, new int[] {1, 5}).ToString());

            Console.ReadLine();
        }
    }
}
