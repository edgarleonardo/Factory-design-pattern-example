using FactoryLib.Interface;

namespace FactoryLib.ConcrateImplementation
{
    public class Iphone : IMobile
    {
        public string GetMobileOS()
        {
            return "IOS";
        }
        public string GetMobileModelName()
        {
            return "Iphone";
        }
        internal Iphone()
        {

        }
    }
}
