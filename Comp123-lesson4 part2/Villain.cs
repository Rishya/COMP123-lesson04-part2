using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson4_part2
{
    class Villain : Hero
    {

        //PRIVATE PROPERTY+++++++++++++++++++++++++
        private string name;
        public Villain(string name, int health, int smarts, string gender):base(health, smarts, gender)
        {
            this.name = name;
        }
        //PUBLIC METHODS++++++++++++++++++++++++++++
        public void doesBadThings()
        {
            Console.WriteLine("Doin bad things ...yeah!");
        }
    }
}
