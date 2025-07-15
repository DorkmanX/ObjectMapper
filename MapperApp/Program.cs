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
            var dbOperations = new DatabaseOperations();

            Console.WriteLine("Test pobrania kolumn z tabeli Users:");
            var columns = dbOperations.GetObjectColumnNamesFromDatabase(typeof(Users));
            foreach (var col in columns)
            {
                Console.WriteLine(col);
            }
            Console.WriteLine("---- KONIEC TESTU ----");
            Console.ReadLine();

            List<Type> allClassesTypes = new List<Type>();
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
