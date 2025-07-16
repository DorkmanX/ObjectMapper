using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TranslationManagerLib
{
    public class ObjectPropertiesGetter : IObjectPropertiesGetter
    {
        public List<string> GetObjectsPropertiesWithReflection(Type type)
        {
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyNames = new List<string>();

            foreach(var prop in properties)
            {
                propertyNames.Add(prop.Name);
            }

            return propertyNames;
        }
    }
}
