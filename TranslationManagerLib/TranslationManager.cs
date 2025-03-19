using ObjectsLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationManagerLib
{
    //to jest ta główna statyczna klasa z której będziemy korzystać przy pobieraniu translacji
    public static class TranslationManager
    {
        //lista translacji
        private static Dictionary<Type, Dictionary<string, string>> _translations = new Dictionary<Type, Dictionary<string, string>>();

        //ta metoda ma dodawać do listy _translations parę klucz wartość z typu i słownika gdzie kluczem słownika jest właściwość obiektu a wartością
        //nazwa kolumny z bazy danych
        public static bool CreateAndAddTranslationScheme(Type type,List<string> objectProperties,List<string> databaseColumns)
        {
            throw new NotImplementedException();
        }
        //ta metoda ma przeszukiwać listę translacji i zwracać konkretny schemat dla klasy przekazanej jako T generycznie
        public static Dictionary<string,string> GetTranslation<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
