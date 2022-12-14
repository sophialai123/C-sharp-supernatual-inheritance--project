using System;

namespace MagicalInheritance
{
    //Inherits from Pupil class
    class Mage : Pupil
    {
        //call base construtor with same argument
        public Mage(string title) :
            base(title)
        {
        }

        //method return Storm type
        // virtual method can be override in the children class
        public virtual Storm CastRainStorm()
        {
            //return Storm object from Storm class
            return new Storm("rain", false, Title);
        }
    }
}
