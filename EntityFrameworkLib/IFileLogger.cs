using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public interface IFileLogger
    {
        void LogToFile(string message, Exception exception);
    }
}
