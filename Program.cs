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

    /*
     
     public abstract class UnidadMilitar
{
    public abstract void Atacar();
}

public class Infanteria : UnidadMilitar
{
    public override void Atacar()
    {
        // Lógica para atacar como infantería
    }
}

public class Caballeria : UnidadMilitar
{
    public override void Atacar()
    {
        // Lógica para atacar como caballería
    }
}

public class Arquero : UnidadMilitar
{
    public override void Atacar()
    {
        // Lógica para atacar como arquero
    }
}

public abstract class UnidadMilitarFactory
{
    public abstract UnidadMilitar CrearUnidad();
}

public class InfanteriaFactory : UnidadMilitarFactory
{
    public override UnidadMilitar CrearUnidad()
    {
        return new Infanteria();
    }
}

public class CaballeriaFactory : UnidadMilitarFactory
{
    public override UnidadMilitar CrearUnidad()
    {
        return new Caballeria();
    }
}

public class ArqueroFactory : UnidadMilitarFactory
{
    public override UnidadMilitar CrearUnidad()
    {
        return new Arquero();
    }
}
     
     
     */
}
