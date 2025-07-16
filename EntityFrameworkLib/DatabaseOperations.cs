using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EntityFrameworkLib
{
    public class DatabaseOperations : IDatabaseOperations
    {
        private readonly string _connectionString =
            "Server=localhost;Database=LocalMapper;Trusted_Connection=True;TrustServerCertificate=True;";

        public List<string> GetObjectColumnNamesFromDatabase(Type type)
        {
            // 1) Normalize name of the class (remove non-letters, lower-case)
            string desired = HelperOperations
                .RemoveAllCharsExceptLetters(type.Name)
                .ToLower();

            List<string> allTables = new List<string>();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // 2) Pobierz wszystkie tabele
                using (var cmd = new SqlCommand(
                    "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'", conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                        allTables.Add(rdr.GetString(0));
                }

                // 3) Znajdź właściwą tabelę po znormalizowanej nazwie
                string found = allTables
                    .FirstOrDefault(tbl =>
                        HelperOperations.RemoveAllCharsExceptLetters(tbl)
                            .ToLower() == desired);

                if (found == null)
                {
                    FileLogger.LogError($"Brak tabeli odpowiadającej klasie: {type.Name}");
                    return new List<string>();
                }

                // 4) Pobierz kolumny tej tabeli
                var columns = new List<string>();
                using (var cmd = new SqlCommand(
                    "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=@t", conn))
                {
                    cmd.Parameters.AddWithValue("@t", found);
                    using (var rdr = cmd.ExecuteReader())
                        while (rdr.Read())
                            columns.Add(rdr.GetString(0));
                }

                return columns;
            }
        }
    }
}
