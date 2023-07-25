using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
   
    public class CavalryFactory : MilitaryUnitFactory
    {
        public override MilitaryUnit CreateUnit()
        {
            return new Cavalry();
        }
    }
}
