using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object with arguments
            //Storm s = new Storm("wind", false, "Zul rajas");
            //call the Storm method
            //Console.WriteLine(s.Announce());
            //create an object with arguments
            Pupil p = new Pupil("Mezi-kree");

            //call the methods that return Storm type
            Storm windStorm = p.CastWindStorm();

            //use Announce method to check if the wind is weak or not
            Console.WriteLine(windStorm.Announce());

            //create an object with arguments
            Mage m = new Mage("Gul's dan");
            Storm rainStorm = m.CastRainStorm();
            Console.WriteLine(rainStorm.Announce());

            //create a new object
            Archmage a = new Archmage("Aran");
            Storm lightingRainStorm = a.CastRainStorm();
            Storm LightningStorm = a.CastLightningStorm();
            Console.WriteLine(lightingRainStorm.Announce());
            Console.WriteLine(LightningStorm.Announce());
        }
    }
}
