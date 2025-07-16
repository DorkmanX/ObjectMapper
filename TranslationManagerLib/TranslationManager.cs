using ObjectsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationManagerLib
{
    public static class TranslationManager
    {
        private static Dictionary<Type, Dictionary<string, string>> _translations = new Dictionary<Type, Dictionary<string, string>>();

        public static bool CreateAndAddTranslationScheme(Type type,List<string> objectProperties,List<string> databaseColumns)
        {
            if (type == null || objectProperties == null || databaseColumns == null)
                return false;

            var translation = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var prop in objectProperties)
            {
                var matchedColumn = databaseColumns.FirstOrDefault(col => col.Equals(prop, StringComparison.OrdinalIgnoreCase));

                if (!string.IsNullOrEmpty(matchedColumn))
                {
                    translation[prop] = matchedColumn;
                }
            }

            if (_translations.ContainsKey(type))
            {
                _translations[type] = translation;
            }            else
            {
                _translations.Add(type, translation);
            }
            return true;
        }
        public static Dictionary<string,string> GetTranslation<T>() where T : class
        {
            var type = typeof(T);
            return _translations.TryGetValue(type, out var translation) ? translation : null;
        }
    }
}
