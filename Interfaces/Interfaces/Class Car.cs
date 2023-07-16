using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Car : IRadio , Iseats
    {
        protected double speed;

        public double GetSpeed()
        {
            return speed;
        }
        public abstract void Breke();

        public abstract void Accelerate();


    }
}
