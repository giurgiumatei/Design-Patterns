using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobileFactory mobileFactory = new XiaomiFactory();
            mobileFactory.GetMobile(ModelType.RedmiPro).GetMobile();
            mobileFactory.GetSignalStrength(ModelType.RedmiPro).ShowSignalStrength();
        }
    }
}