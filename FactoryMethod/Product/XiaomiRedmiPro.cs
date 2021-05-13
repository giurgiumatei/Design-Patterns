using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Product
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmiPro mobile created...");
        }
    }
}
