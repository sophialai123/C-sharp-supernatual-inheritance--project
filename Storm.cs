using System;

namespace MagicalInheritance
{
    class Storm
    {
        //properties
        public string Essence { get; private set; }

        public bool IsStrong { get; private set; }

        public string Caster { get; private set; }

        //constructor
        public Storm(string essence, bool isStrong, string caster)
        {
            //set properites equal to parameters
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        //public method return a string
        public string Announce()
        {
            //check the properties
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence} storm!";
            }
            else
            {
                return $"{Caster} cast a weak {Essence} storm!";
            }
        }
    }
}
