using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Product
{
    public class SamsungA9 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung mobile created...");
        }
    }
}
