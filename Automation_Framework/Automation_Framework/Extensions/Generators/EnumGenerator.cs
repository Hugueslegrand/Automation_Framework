using System;


namespace Automation_Framework.Extensions.Generators
{
    public static class EnumGenerator
    {
        public static T ToEnum<T>(this string value, bool ignoreCase = true)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }
    }
}
