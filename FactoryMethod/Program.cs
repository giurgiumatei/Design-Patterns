using FactoryMethod.Factory;
using FactoryMethod.FactoryInterface;
using FactoryMethod.ProductInterface;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMobileFactory mobileFactory = new XiaomiFactory();
            IMobile mobile = mobileFactory.GetMobile(ModelType.RedmiPro);
            
            mobile.GetMobile();
        }
    }
}