using InheritenceAndComposition2.Heads;
using System;
using System.Collections.Generic;

namespace InheritenceAndComposition2
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();
            workerHead.Color = LegoColor.Yellow;
            workerHead.SayHi();

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
                // polymorphism -- is a relationship means they can be treated the same
                // methods unique to a specific class cannot be implemented here
            }

        }
    }
}
