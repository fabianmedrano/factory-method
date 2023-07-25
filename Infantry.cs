using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class Infantry : MilitaryUnit
    {

        public override void attack() {
            Console.WriteLine("assault, ambush and flanking");
        }
    }
}
