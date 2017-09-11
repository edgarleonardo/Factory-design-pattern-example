
using System;
using FactoryLib.ConcrateImplementation;
using FactoryLib.Factory;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mobile = MobileFactory.Instance.CreateInstance("Iphone");
                if (mobile != null)
                {
                   Console.WriteLine($"The Phone Model Is { mobile.GetMobileModelName()} And its OS is { mobile.GetMobileOS()}");
                }
                mobile = MobileFactory.Instance.CreateInstance("Samsung");
                if (mobile != null)
                {
                    Console.WriteLine($"The Phone Model Is { mobile.GetMobileModelName()} And its OS is { mobile.GetMobileOS()}");
                }
                mobile = MobileFactory.Instance.CreateInstance("Lg");
                if (mobile != null)
                {
                    Console.WriteLine($"The Phone Model Is { mobile.GetMobileModelName()} And its OS is { mobile.GetMobileOS()}");
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Exception Was handle: {ex.Message}");
            }
        }
    }
}
