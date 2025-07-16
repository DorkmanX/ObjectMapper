using EntityFrameworkLib;
using Microsoft.EntityFrameworkCore;
using ObjectsLib.Models;
using System;
using System.Collections.Generic;
using TranslationManagerLib;

namespace MapperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Server=localhost;Database=LocalMapper;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using (var context = new DatabaseContext(options))
            {
                var dbOperations = new DatabaseOperations(context);
                var objectPropertiesGetter = new ObjectPropertiesGetter();

                List<Type> allClassesTypes = new List<Type>
                {
                    typeof(Users),
                    typeof(StandConfig)
                };

                foreach (var type in allClassesTypes)
                {
                    var databaseColumns = dbOperations.GetObjectColumnNamesFromDatabase(type);
                    var objectProperties = objectPropertiesGetter.GetObjectsPropertiesWithReflection(type);
                    var success = TranslationManager.CreateAndAddTranslationScheme(type, objectProperties, databaseColumns);

                    Console.WriteLine($"Schemat translacji dla {type.Name} {(success ? "został utworzony" : "nie został utworzony")}");
                }

                var translationUsers = TranslationManager.GetTranslation<Users>();
                if (translationUsers != null)
                {
                    Console.WriteLine("Schemat translacji dla Users:");
                    foreach (var kvp in translationUsers)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("Brak schematu translacji dla Users.");
                }

                var translationStandConfig = TranslationManager.GetTranslation<StandConfig>();
                if (translationStandConfig != null)
                {
                    Console.WriteLine("Schemat translacji dla StandConfig:");
                    foreach (var kvp in translationStandConfig)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("Brak schematu translacji dla StandConfig.");
                }
                Console.WriteLine("---- KONIEC TESTU ----");
                Console.ReadLine();
            }
        }
    }
}
