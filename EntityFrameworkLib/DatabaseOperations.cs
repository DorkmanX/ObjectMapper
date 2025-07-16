using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkLib
{
    public class DatabaseOperations : IDatabaseOperations
    {
        private readonly DatabaseContext _dbContext;

        public DatabaseOperations(DatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public List<string> GetObjectColumnNamesFromDatabase(Type type)
        {
            var entityType = _dbContext.Model.FindEntityType(type);
            if (entityType == null)
            {
                FileLogger.LogError($"Brak tabeli odpowiadającej klasie: {type.Name}");
                return new List<string>();
            }

            var relational = entityType.Relational();
            var tableName = relational?.TableName;
            var schema = relational?.Schema;

            if (string.IsNullOrEmpty(tableName))
            {
                FileLogger.LogError($"Brak nazwy tabeli dla klasy: {type.Name}");
                return new List<string>();
            }

            var columnNames = entityType.GetProperties()
                .Select(p => p.Relational().ColumnName)
                .Where(name => !string.IsNullOrEmpty(name))
                .ToList();

            return columnNames;
        }
    }
}
