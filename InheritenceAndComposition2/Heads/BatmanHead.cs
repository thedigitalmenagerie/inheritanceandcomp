using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndComposition2.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";

        public BatmanHead()
        {
            Color = LegoColor.Brown;
        }

        public void InquireAboutJokersLocation()
        {
            Console.WriteLine("Where is the joker?!?!?");
        }

        public override void Spin()
        {
            Console.WriteLine("Batman spins before attacking.");
        }

        // override on inheriting class must match virtual with override
        public override void SayHi()
        {
            Console.WriteLine("I'm Batman");
        }
    }
}
