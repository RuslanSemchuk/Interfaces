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
            mercedes.Accelerate();
            volga.Accelerate();

            bmw.Breke();
            mercedes.Breke();
            volga.Breke();
        }
    }
}