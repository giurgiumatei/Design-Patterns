using System;

namespace SimpleFactory
{
    public class Samsung: IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Samsung mobile created...");
        }
    }
}