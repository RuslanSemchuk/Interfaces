using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Bmw();
            Car mercedes = new Mercedes();
            Car volga = new Volga();

            bmw.Accelerate();
            bmw.Breke();


            mercedes.Accelerate();
            mercedes.Breke();


            volga.Accelerate();
            volga.Breke();


            IRadio bmwRadio = (IRadio)bmw;
            ISeats bmwSeats = (ISeats)bmw;


            IRadio mercedesRadio = (IRadio)mercedes;
            ISeats mercedesSeats = (ISeats)mercedes;


            IRadio volgaRadio = (IRadio)volga;
            ISeats volgaSeats = (ISeats)volga;


            bmwRadio.TurnOn();
            bmwRadio.TurnOff();
            bmwRadio.ChangeStation();
            bmwRadio.IncreaseVolume();
            bmwSeats.AdjustPosition();
            bmwSeats.HeatOn();
            bmwSeats.HeatOff();


            mercedesRadio.TurnOn();
            mercedesRadio.TurnOff();
            mercedesRadio.ChangeStation();
            mercedesRadio.IncreaseVolume();
            mercedesSeats.AdjustPosition();
            mercedesSeats.HeatOn();
            mercedesSeats.HeatOff();


            volgaRadio.TurnOn();
            volgaRadio.TurnOff();
            volgaRadio.ChangeStation();
            volgaRadio.IncreaseVolume();
            volgaSeats.AdjustPosition();
            volgaSeats.HeatOn();
            volgaSeats.HeatOff();
        }
    }
}