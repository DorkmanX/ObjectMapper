using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public class DatabaseContext : DbContext
    {
        /*
         Utworzyć za pomocą entity frameworka klasę kontekstową do komunikacji z bazą danych MS SQL Server
         Założenia: 
            -wykorzystujemy Fluent Api
            -każda tabela w bazie nazywa się identycznie jak nazwa klasy obiektu czyli StandConfig => StandConfig
            -klasy obiektów są w ObjectsLib w folderze Models
         */ 
    }
}
