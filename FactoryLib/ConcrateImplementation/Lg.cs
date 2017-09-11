using FactoryLib.Interface;

namespace FactoryLib.ConcrateImplementation
{
    public class Lg : IMobile
    {
        public string GetMobileOS()
        {
            return "Android";
        }
        public string GetMobileModelName()
        {
            return "LG";
        }        
        internal Lg()
        {

        }
    }
}
