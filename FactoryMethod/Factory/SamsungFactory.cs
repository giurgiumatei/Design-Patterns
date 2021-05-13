using FactoryMethod.FactoryInterface;
using FactoryMethod.Product;
using FactoryMethod.ProductInterface;
using System;

namespace FactoryMethod.Factory
{
    public class SamsungFactory: IMobileFactory
    {
        public IMobile GetMobile(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxy();
                case ModelType.A9:
                    return new SamsungA9();
                default:
                    throw new Exception("invalid model type");
            }
        }
    }
}

