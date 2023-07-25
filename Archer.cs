using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class Archer : MilitaryUnit
    {
        public override void attack()
        {
            Console.WriteLine("fire arrows");
        }
    }
}
