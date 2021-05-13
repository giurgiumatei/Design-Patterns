using System;

namespace AbstractFactory
{
    public class SamsungGalaxy : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("SamsungJ7Prime mobile created...");
        }
    }
}
