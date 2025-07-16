using EntityFrameworkLib;
using Microsoft.EntityFrameworkCore;
using ObjectsLib.Models;
using System;
using System.Collections.Generic;
using TranslationManagerLib;
using LibPull.Objects.EntityFrameworkCore;


namespace MapperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Server=localhost;Database=PullSystem_NEW;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            using (var context = new DatabaseContext(options))
            {
                var dbOperations = new DatabaseOperations();
                var objectPropertiesGetter = new ObjectPropertiesGetter();

                List<Type> allClassesTypes = new List<Type>
                {
                    typeof(StandConfig),
                    typeof(PullOrder),
                    typeof(WorkOrder)
                };

                foreach (var type in allClassesTypes)
                {
                    var databaseColumns = dbOperations.GetObjectColumnNamesFromDatabase(type);
                    var objectProperties = objectPropertiesGetter.GetObjectsPropertiesWithReflection(type);
                    var success = TranslationManager.CreateAndAddTranslationScheme(type, objectProperties, databaseColumns);

                    Console.WriteLine($"Schemat translacji dla {type.Name} {(success ? "został utworzony" : "nie został utworzony")}");
                }

                var translationStandConfig = TranslationManager.GetTranslation<StandConfig>();
                if (translationStandConfig != null)
                {
                    Console.WriteLine("\nSchemat translacji dla StandConfig:");
                    foreach (var kvp in translationStandConfig)
                    {
                        PrintMappingWithDiff(kvp.Key, kvp.Value);
                    }
                }
                else
                {
                    Console.WriteLine("\nBrak schematu translacji dla StandConfig.");
                }

                var translationPullOrder = TranslationManager.GetTranslation<PullOrder>();
                if (translationPullOrder != null)
                {
                    Console.WriteLine("\nSchemat translacji dla PullOrder:");
                    foreach (var kvp in translationPullOrder)
                    {
                        PrintMappingWithDiff(kvp.Key, kvp.Value);
                    }
                }
                else
                {
                    Console.WriteLine("\nBrak schematu translacji dla PullOrder.");
                }

                var translationWorkOrder = TranslationManager.GetTranslation<WorkOrder>();
                if (translationWorkOrder != null)
                {
                    Console.WriteLine("\nSchemat translacji dla WorkOrder :");
                    foreach (var kvp in translationWorkOrder)
                    {
                        PrintMappingWithDiff(kvp.Key, kvp.Value);
                    }
                }
                else
                {
                    Console.WriteLine("\nBrak schematu translacji dla WorkOrder .");
                }

                Console.WriteLine("\n---- KONIEC TESTU ----");
                Console.ReadLine();
            }
        }

        private static void PrintMappingWithDiff(string prop, string col)
        {
            Console.Write($"{prop} -> {col}");

            if (!prop.Equals(col, StringComparison.Ordinal))
            {
                var diffs = new List<string>();
                int max = Math.Max(prop.Length, col.Length);
                for (int i = 0; i < max; i++)
                {
                    char c1 = i < prop.Length ? prop[i] : '∅';
                    char c2 = i < col.Length ? col[i] : '∅';
                    if (c1 != c2)
                        diffs.Add($"[{i + 1}: '{c1}'→'{c2}']");
                }
                if (diffs.Count > 0)
                {
                    Console.Write("   Różnice: " + string.Join(" ", diffs));
                }
            }

            Console.WriteLine();
        }
    }
}
