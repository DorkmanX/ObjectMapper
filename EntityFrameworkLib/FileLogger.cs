using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public class FileLogger : IFileLogger
    {
        //tutaj prosta sprawa klasa służy do dodania wiadomości o błędzie wraz z wyjątkiem jaki wyskoczył do pliku tekstowego
        public void LogToFile(string message, Exception exception)
        {

        }
    }
}
