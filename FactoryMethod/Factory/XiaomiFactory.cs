using FactoryMethod.FactoryInterface;
using FactoryMethod.Product;
using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Factory
{
    public class XiaomiFactory : IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Redmi6:
                    return new XiaomiRedmi6();
                case ModelType.RedmiPro:
                    return new XiaomiRedmiPro();
                default:
                    throw new Exception("invalid model type");
            }
        }
    }
}
