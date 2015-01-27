using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson4_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero(7,8,"female");
            myHero.doesGoodThings();
            //wait for input before closing console
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
