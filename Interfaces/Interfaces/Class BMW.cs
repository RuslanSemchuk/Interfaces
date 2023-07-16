using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bmw : Car
    {
        public override void Breke()
        {
            speed -= 10;
            Console.WriteLine("Bmw: Braking... Current speed: " + speed);
        }
        public override void Accelerate()
        {
            speed += 20;
            Console.WriteLine("Bmw: Accelerating... Current speed: " + speed);
        }
    }
}
