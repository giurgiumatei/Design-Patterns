using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Product
{
    public class SamsungGalaxy : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("SamsungJ7Prime mobile created...");
        }
    }
}
