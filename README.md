Zadania:
        
        EntityFrameworkLib
        W tym folderze powinna się znajdować cała komunikacja z bazą danych.

        1. DatabaseContext - klasa entity framework do bezpośrednich operacji na bazie danych.
        2. DatabaseOperations - opakowanie na DatabaseContext, chcemy jej używać później we wszystkich innych miejscach. Ma mieć w sobie DatabaseContext.

        3.Na podstawie nazwy typu klasy w metodzie GetObjectColumnNamesFromDatabase zakładając, że nazwa typu klasy jest taka jak nazwa tabeli w 
        bazie danych pobierasz listę która zawiera nazwy kolumn tej tabeli i ją zwracasz. Może się zdarzyć, że dla klasy której szukasz
        nazwa tabeli jest nieco inna przykład:

        StandConfig => Stand_Config w bazie

        taką sytuację też trzeba obsłużyć dlatego

        4. Porównaj nazwy klasy oraz tabeli w bazie danych używając rozszerzeń
        Rozszerzenia powinny znajdować się w klasie HelperOperations
        Porównując nazwy skonwertuj napisy na małe litery, usuń wszystko po za literami z napisu i następnie porównaj w ten sposób:
        
        ....
        string napis = "Ala$";
        string napis2 = "Ala";
        napis.RemoveAllCharsExceptLetters();
        if(napis.StringIsEqualTo(napis2))
        .....
        Podsumowując trzeba napisać statyczną klasę która rozszerza typ string.

        5. Dodanie logów do pliku
        
        Jeżeli nie znajdziesz tabeli o takiej nazwie jak nazwa klasy:
            -za pomocą klasy FileLogger dodajesz komunikat o błędzie do pliku tekstowego
            -zwracasz pustą listę stringów z metody GetObjectColumnNamesFromDatabase

      ObjectsLib - ten folder zawiera klasy z których korzystamy w programie.
      1. Dodać przykładową klasę lub wykorzystać istniejącą

      TranslationManagerLib - folder z klasą która ma listę kolumn w bazie oraz listę właściwości z obiektu i z nich tworzy gotową translację.

      Klasa służy do pobrania listy właściwości klasy w formie listy z ich nazwami

      1. Zaimplementować GetObjectsPropertiesWithReflection 
      
      Trzeba tutaj wykorzystać refleksję w C#
      
      Przekazujemy jako parametr typ klasy dla której chcemy uzyskać właściwości
      Pobierasz wszystkie właściwości obiektu i dodajesz do listy ich nazwy
      Zwracasz listę właściwości obiektu

      2. Dodać schemat translacji do za pomocą metody TranslationManager.CreateAndAddTranslationScheme

      Masz już kolumny z bazy oraz właściwości obiektu. Chciałbym aby było podane mapowanie z każdej właściwości klasy na odpowiadającą mu nazwę w bazie.
      Takie mapowanie dodać do listy _translations razem z typem obiektu.

      Przykład:
      Dictionary<string, string> => w takim słowniku kluczem jest właściwość obiektu a wartością nazwa kolumny w bazie
      Id => ID często mamy takie sytuacje, że nazwa propki różni się od nazwy kolumny w bazie wielkością liter, te translacje przed tym zabezpieczą
      
      Gotowy obiekt ma być słownikiem Dictionary<Type, Dictionary<string, string>> czyli kolejny słownik którego kluczem jest typ obiektu a wartością schemat mapowania

      3. GetTranslation - zaimplementować tę metodę, która służy do pobrania gotowej translacji. 
      Parametrem jest typ obiektu. Przeszukać słownik po tym kluczu czyli typie obiektu i zwrócić odpowiednią translację.

W Program.cs znajduje się przykładowe flow aplikacji po zrobieniu tego wszystkiego.
