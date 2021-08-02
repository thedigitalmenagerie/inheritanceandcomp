using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndComposition2.Heads
{
    abstract class HeadBase // abstract is the idea of a thing and this keyword prevents from being instantiated
        // and is only good for inheriting from 
    {
        public LegoColor Color { get; set; }

        // if all were to say hi the same-- just define in base as opposed to specific class
        // default but each head specific use keyword people that inherit can change -- virtual
        public virtual void SayHi()
        {
            Console.WriteLine($"Hi.");
        }

        public abstract void Spin(); // specifies that all inheriting classes must include this method and doesn't
        // know what behavior it has but knows you have to have it
    }
}
