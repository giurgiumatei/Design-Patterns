
using System;
using AbstractFactory;

namespace AbstractFactory
{
    public class XiaomiRedmiPro : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("XiaomiRedmiPro mobile created...");
        }
    }
}
