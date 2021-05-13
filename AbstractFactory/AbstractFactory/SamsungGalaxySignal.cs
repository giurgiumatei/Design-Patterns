using System;

namespace AbstractFactory
{
    public class SamsungGalaxySignal: ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Samsung Galaxy Signal strength is good !!");
        }
    }
}