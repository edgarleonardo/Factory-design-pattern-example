using FactoryLib.Interface;

namespace FactoryLib.ConcrateImplementation
{
    public class Samsung : IMobile
    {
        public string GetMobileOS()
        {
            return "Android";
        }
        public string GetMobileModelName()
        {
            return "Samsung";
        }
        internal Samsung()
        {

        }
    }
}
