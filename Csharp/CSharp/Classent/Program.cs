using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    internal class Creature
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            
            Creature creature = new Creature();
            creature.Breath();
        }

    }

}