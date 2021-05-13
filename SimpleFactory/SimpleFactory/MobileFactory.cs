using System;

namespace SimpleFactory
{
    public class MobileFactory
    {
        public static IMobile CreateMobile(BrandType brandType)
        {
            switch (brandType)
            {
                case BrandType.Samsung:
                    return new Samsung();
                case BrandType.Xiaomi:
                    return new Xiaomi();
                default:
                    throw new Exception("Invalid brand type...");
            }
        }
    }
}