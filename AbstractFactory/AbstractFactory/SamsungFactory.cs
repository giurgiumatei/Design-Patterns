
using System;

namespace AbstractFactory
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

        public ISignal GetSignalStrength(ModelType modelType)
        {
            switch (modelType)
            {
                case ModelType.Galaxy:
                    return new SamsungGalaxySignal();
                default:
                    throw new Exception("invalid model type");
            }
        }
    }
}

