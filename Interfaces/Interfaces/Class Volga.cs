using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Volga : Car
    {
        public override void Breke()
        {
            speed -= 5;
            Console.WriteLine("Volga: Braking... Current speed: " + speed);
        }

        public override void Accelerate()
        {
            speed += 50;
            Console.WriteLine("Volga: Accelerating... Current speed: " + speed);
        }
    }
}
