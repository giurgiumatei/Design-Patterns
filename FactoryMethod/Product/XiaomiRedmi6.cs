using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Product
{
    public class XiaomiRedmi6 : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmi6 mobile created...");
        }
    }
}
