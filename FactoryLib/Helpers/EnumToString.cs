using System;

namespace FactoryLib.Helpers
{
    public static class EnumToString<T>
    {
        public static T GetEnumValue(string strValue)
    {
        return (T)Enum.Parse(typeof(T), strValue, ignoreCase: true);
    }
}
}
