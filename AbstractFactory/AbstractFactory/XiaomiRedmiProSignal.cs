using System;

namespace AbstractFactory
{
    public class XiaomiRedmiProSignal: ISignal
    {
        public void ShowSignalStrength()
        {
            Console.WriteLine("Xiaomi Redmi Pro has poor signal strength. Consider changing mobile network !!");
        }
    }
}