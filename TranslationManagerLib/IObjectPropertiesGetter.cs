using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationManagerLib
{
    public interface IObjectPropertiesGetter
    {
        List<string> GetObjectsPropertiesWithReflection(Type type);
    }
}
