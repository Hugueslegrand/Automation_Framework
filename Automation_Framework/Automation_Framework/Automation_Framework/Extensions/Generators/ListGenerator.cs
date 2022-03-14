using System;
using System.Collections.Generic;
using System.Linq;


namespace Automation_Framework.Extensions.Generators
{
    public static class ListGenerator
    {
        public static T Random<T>(this List<T> input)
        {
            return input.ElementAt(new Random().Next(input.Count));
        }
    }
}
