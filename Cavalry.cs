﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
  

    public class Cavalry : MilitaryUnit
    {

        public override void attack()
        {
            Console.WriteLine("attacking the flanks and rearguard");
        }
    }
}
