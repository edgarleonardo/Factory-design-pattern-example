namespace FactoryLib.Interface
{
    public interface IMobile : IFactoryBaseInstance
    {
        string GetMobileModelName();
        string GetMobileOS();
    }
}