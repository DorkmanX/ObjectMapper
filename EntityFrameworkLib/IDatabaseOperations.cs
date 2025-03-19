using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public interface IDatabaseOperations
    {
        List<string> GetObjectColumnNamesFromDatabase(Type type);
    }
}
