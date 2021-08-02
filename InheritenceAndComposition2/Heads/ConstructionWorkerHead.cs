using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndComposition2.Heads
{
    class ConstructionWorkerHead : HeadBase // this sets up inheritance from the specified file
    {
        public bool HasCoolHair { get; set; }
        public int NumberOfFreckles { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : " is not ")}");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfFreckles < 100)
            {
               NumberOfFreckles += 1;
            }
            
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder.");
        }

        public override void SayHi()
        {
            Console.WriteLine("The Construction Worker says hello.");
        }

        
    }

    enum LegoColor // is a type
    {
        // all about defining possible values -- counts up by one and starts at 0; default is 0, which is yellow here
        Yellow, // is a value
        White, 
        Brown, 
        Green, 
        Red, // trailing and no trailing are both valid
    }
}   

