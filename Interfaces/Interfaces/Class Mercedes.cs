using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Mercedes : Car
    {
        public override void Breke()
        {
            speed -= 5;
            Console.WriteLine("Mercedes: Braking... Current speed: " + speed);
        }

        public override void Accelerate()
        {
            speed += 15;
            Console.WriteLine("Mercedes: Accelerating... Current speed: " + speed);
        }
    }
}
