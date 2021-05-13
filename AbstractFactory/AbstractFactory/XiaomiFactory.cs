
using System;

namespace AbstractFactory
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

        public ISignal GetSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.RedmiPro:
                    return new XiaomiRedmiProSignal();
                default:
                    throw new Exception("invalid model type");
            }
        }
    }
}
