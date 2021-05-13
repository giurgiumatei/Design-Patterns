using System;

namespace SimpleFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IMobile mobile = MobileFactory.CreateMobile(BrandType.Samsung);
            mobile.GetMobile();
        }
    }
}