using FactoryMethod.ProductInterface;

namespace FactoryMethod.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType brandType);
    }
}
