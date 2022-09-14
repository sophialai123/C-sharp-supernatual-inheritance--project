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
            Pupil p = new Pupil("Mezi-kree");

            //call the methods that return Storm type
            Storm windStorm = p.CastWindStorm();

            //use Announce method to check if the wind is weak or not
            Console.WriteLine(windStorm.Announce());
        }
    }
}
