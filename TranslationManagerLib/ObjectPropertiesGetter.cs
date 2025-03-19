using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationManagerLib
{
    public class ObjectPropertiesGetter : IObjectPropertiesGetter
    {
        /*
         Klasa służy do pobrania listy właściwości klasy w formie listy z ich nazwami
         czyli dla StandConfig będzie to ID, PlaceID itd.
        Trzeba tutaj wykorzystać refleksję w C#
        Przekazujemy jako parametr typ klasy dla której chcemy uzyskać właściwości
         */ 
        public List<string> GetObjectsPropertiesWithReflection(Type type) => throw new NotImplementedException();
    }
}
