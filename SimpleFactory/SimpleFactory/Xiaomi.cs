using System;

namespace SimpleFactory
{
    public class Xiaomi: IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Xiaomi mobile created...");
        }
    }
}