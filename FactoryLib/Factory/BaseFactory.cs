using FactoryLib.Interface;

namespace FactoryLib.Factory
{
    public abstract class BaseFactory<T> where T : IFactoryBaseInstance
    {
        public abstract T CreateInstance(string type);
    }
}
