﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bmw : Car, ISeats, IRadio
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

        public void TurnOn()
        {
            Console.WriteLine("Bmw: Turning on the radio...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Bmw: Turning off the radio...");
        }

        public void ChangeStation()
        {
            Console.WriteLine("Bmw: Changing the radio station...");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Bmw: Increasing the radio volume...");
        }

        public void AdjustPosition()
        {
            Console.WriteLine("Bmw: Adjusting the seat position...");
        }

        public void HeatOn()
        {
            Console.WriteLine("Bmw: Turning on the seat heating...");
        }

        public void HeatOff()
        {
            Console.WriteLine("Bmw: Turning off the seat heating...");
        }
    }
}
