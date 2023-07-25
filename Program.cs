using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnitFactory cavalryFactory = new CavalryFactory();
            MilitaryUnit cavalry = cavalryFactory.CreateUnit();

            MilitaryUnitFactory infantryFactory = new InfantryFactory();
            MilitaryUnit infantry = infantryFactory.CreateUnit();

       
            MilitaryUnitFactory archerFactory = new ArcherFactory();
            MilitaryUnit archer = archerFactory.CreateUnit();


            infantry.attack();
            cavalry.attack();
            archer.attack();
        }
    }
}
