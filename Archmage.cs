using System;

namespace MagicalInheritance
{
    //inherits from Mage class
    class Archmage : Mage
    {
        //call Mage construtor with same title argument
        public Archmage(string title) :
            base(title)
        {
        }

        //overrides method with Storm type
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }

        //define a new method and turn Storm
        public Storm CastLightningStorm()
        {
            return new Storm("lighting", true, Title);
        }
    }
}
