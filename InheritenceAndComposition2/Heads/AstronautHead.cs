using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndComposition2.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }

        public override void SayHi()
        {
            // keyword to access base methods and allows to interact with what we are inheriting from
            // call method and then do speific
            base.SayHi(); // without base would be an infinite loop
            Console.WriteLine("Major Tom to Ground Control.");
        }

        public override void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}"); // taken and turned into a string and everything has tostring method
            FacialHair = FacialHair.None;
        } 
    }

}
