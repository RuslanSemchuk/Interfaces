using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Volga : Car, ISeats, IRadio
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

        public void TurnOn()
        {
            Console.WriteLine("Volga: Turning on the radio...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Volga: Turning off the radio...");
        }

        public void ChangeStation()
        {
            Console.WriteLine("Volga: Changing the radio station...");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Volga: Increasing the radio volume...");
        }

        public void AdjustPosition()
        {
            Console.WriteLine("Volga: Adjusting the seat position...");
        }

        public void HeatOn()
        {
            Console.WriteLine("Volga: Turning on the seat heating...");
        }

        public void HeatOff()
        {
            Console.WriteLine("Volga: Turning off the seat heating...");
        }
    }
}
