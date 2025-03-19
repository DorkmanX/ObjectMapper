using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLib
{
    public class DatabaseOperations : IDatabaseOperations
    {
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
        public List<string> GetObjectColumnNamesFromDatabase(Type type) => throw new NotImplementedException();
    }
}
