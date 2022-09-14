using System;

namespace MagicalInheritance
{
    class Pupil
    {
        //properites with getter and private setter
        public string Title { get; private set; }

        //constructor
        public Pupil(string title)
        {
            this.Title = title;
        }

        //public method return type Storm;
        public Storm CastWindStorm()
        {
            //return a new object of Storm
            return new Storm("wind", false, Title);
        }
    }
}
