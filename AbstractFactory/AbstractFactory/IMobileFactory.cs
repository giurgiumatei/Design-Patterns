
namespace AbstractFactory
{
    public interface IMobileFactory
    {
        IMobile GetMobile(ModelType brandType);
        ISignal GetSignalStrength(ModelType modelType);
    }
}
