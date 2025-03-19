using EntityFrameworkLib;
using ObjectsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationManagerLib;

namespace MapperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Type> allClassesTypes = new List<Type>();
            var dbOperations = new DatabaseOperations();
            var objectPropertiesGetter = new ObjectPropertiesGetter();

            //utworzenie schematów translacji
            foreach (Type type in allClassesTypes)
            {
                var databaseColumns = dbOperations.GetObjectColumnNamesFromDatabase(type);
                var objectProperties = objectPropertiesGetter.GetObjectsPropertiesWithReflection(type);
                var result = TranslationManager.CreateAndAddTranslationScheme(type, objectProperties, databaseColumns);
            }
            //tak będziemy to wykorzystywać później w projekcie
            var translationSchema = TranslationManager.GetTranslation<StandConfig>();
        }
    }
}
