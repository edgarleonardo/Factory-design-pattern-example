using FactoryLib.ConcrateImplementation;
using FactoryLib.Helpers;
using FactoryLib.Interface;

namespace FactoryLib.Factory
{
    public enum MobileTypesSupported { Iphone, Samsung, Lg}
    public class MobileFactory : BaseFactory<IMobile>
    {
        private static MobileFactory _baseInstance = null;
        private MobileFactory()
        {
        }
        /// <summary>
        /// This is the singleton Pattern implemented
        /// </summary>
        public static MobileFactory Instance
        {
            get
            {
                if (_baseInstance == null)
                {
                    _baseInstance = new MobileFactory();
                }
                return _baseInstance;
            }
        }
        public override IMobile CreateInstance(string type)
        {
            if (MobileTypesSupported.Iphone == EnumToString<MobileTypesSupported>.GetEnumValue(type))
                return new Iphone();
            if (MobileTypesSupported.Samsung == EnumToString<MobileTypesSupported>.GetEnumValue(type))
                return new Samsung();
            return new Lg();
        }
    }
}
