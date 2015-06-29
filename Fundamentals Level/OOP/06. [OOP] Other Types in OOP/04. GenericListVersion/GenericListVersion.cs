using System;
using GenericList;

namespace GenericListVersion
{
    class GenericListVersion
    {
        static void Main()
        {
            Type type = typeof(GenericList<double>);
            object[] allAtributes = type.GetCustomAttributes(false);
            foreach (var attribute in allAtributes)
            {
                if (attribute.GetType().Equals(typeof(Attributes.Version)))
                {
                    Console.WriteLine(attribute);
                }
            }
        }
    }
}
