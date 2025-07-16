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
            if (type == null) return new List<string>();

            var properties = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            var propertyNames = properties.Select(p => p.Name).ToList();

            return propertyNames;
        }
    }
}