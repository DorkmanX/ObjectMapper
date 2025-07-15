using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkLib
{
    public class DatabaseOperations : IDatabaseOperations
    {
        private string connectionString = "Server=localhost;Database=LocalMapper;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<string> GetObjectColumnNamesFromDatabase(Type type)
        {
            string className = type.Name;

            List<string> allTableNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string tableQuery = @"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                using (SqlCommand command = new SqlCommand(tableQuery, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allTableNames.Add(reader.GetString(0));
                    }
                }

                string foundTable = allTableNames
                    .FirstOrDefault(table =>
                        HelperOperations
                            .RemoveAllCharsExceptLetters(table.ToLower())
                            .StringIsEqualTo(HelperOperations.RemoveAllCharsExceptLetters(className.ToLower()))
                    );

                if (string.IsNullOrEmpty(foundTable))
                {
                    FileLogger.LogError($"Brak tabeli odpowiadającej klasie: {className}");
                    return new List<string>();
                }

                List<string> columns = new List<string>();
                string columnQuery = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName";
                using (SqlCommand command = new SqlCommand(columnQuery, connection))
                {
                    command.Parameters.AddWithValue("@TableName", foundTable);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader.GetString(0));
                        }
                    }
                }
                return columns;
            }
        }
    }
}


/*
        Założenia: ta klasa korzysta z DatabaseContext do komunikacji z bazą danych

       Na podstawie nazwy typu klasy w metodzie GetObjectColumnNamesFromDatabase zakładając, że nazwa typu klasy jest taka jak tabeli w 
       bazie danych pobierasz listę która zawiera nazwy kolumn tej tabeli i ją zwracasz. Może się zdarzyć, że dla klasy której szukasz
       nazwa tabeli jest nieco inna przykład:

       StandConfig => Stand_Config w bazie

       taką sytuację też trzeba obsłużyć dlatego

       Porównaj nazwy klasy oraz tabeli w bazie danych używając rozszerzeń
       Rozszerzenia powinny znajdować się w klasie HelperOperations
       Porównując nazwy skonwertuj napisy na małe litery, usuń wszystko po za literami z napisu i następnie porównaj w ten sposób:

       ....
       string napis = "Ala$";
       string napis2 = "Ala";
       napis.RemoveAllCharsExceptLetters();
       if(napis.StringIsEqualTo(napis2))
       .....

       Jeżeli nie znajdziesz tabeli o takiej nazwie jak nazwa klasy:
           -za pomocą klasy FileLogger dodajesz komunikat o błędzie do pliku tekstowego
           -zwracasz pustą listę stringów
        */