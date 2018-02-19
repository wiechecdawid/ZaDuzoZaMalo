using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MVC model widok kontroller
namespace GraModel //logika gry
{
    public class Gra
    {
        public readonly /*private*/ int wylosowanaLiczba; //readonly jest metodą - może być użyty przy polach private
        //przy projektowaniu można na chwilę zmienić na public, albo zrobić metodę w ramach klasy, aby wyświetlić priv.
        public int MinZakres { get; } //private set; - mogę zmienić wewnątrz mojej klasy (readonly nie)
        public int MaxZakres { get; }
        //do zrobienia: czas gry, historia ruchów
        public Status StatusGry { get; private set; }
        public DateTime CzasRozpoczecia { get; }
        public DateTime CzasZakonczenia { get; private set; } //private set - zrobimy to w klasie, natomiast mysimy mieć
        public TimeSpan CalkowityCzasGry => CzasZakonczenia - CzasRozpoczecia; //Timaspan - odcinek w czasie
        public TimeSpan AktualnyCzasGry => DateTime.Now - CzasRozpoczecia;

        //historia ruchów
        public class Ruch
        {
            public int? Liczba { get; } //typy nullable - wartość może być liczbą, bądź null - dzięki temu można zanotować poddanie się 
            public Odpowiedz? Wynik { get; }
            public DateTime? Czas { get; }
            public Status StatusGry { get; }

            public Ruch(int? propozycja, Odpowiedz? odp, Status statusGry)
            {
                Liczba = propozycja;
                Wynik = odp;
                StatusGry = statusGry;
                Czas = DateTime.Now;
                
            }
        }

        private List<Ruch> listaRuchow;
        public IReadOnlyCollection<Ruch> HistoriaGry { get { return listaRuchow.AsReadOnly(); } }
        public Odpowiedz Ocena(int propozycja)
        {
            if (propozycja < wylosowanaLiczba)
            {
                listaRuchow.Add(new Ruch(propozycja, Odpowiedz.ZaMalo, Status.WTrakcie));
                return Odpowiedz.ZaMalo;
            }
            else if (propozycja == wylosowanaLiczba)
            {
                StatusGry = Status.Zakończona;
                CzasZakonczenia = DateTime.Now;
                listaRuchow.Add(new Ruch(propozycja, Odpowiedz.Trafiony, Status.Zakończona));
                return Odpowiedz.Trafiony;
            }
            else
            {
                listaRuchow.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo, Status.WTrakcie));
                return Odpowiedz.ZaDuzo;

            }
        }

        public enum Odpowiedz { ZaMalo=-1, Trafiony=0, ZaDuzo=1} //stałe formalnie są wartościami liczbowymi

        //public Gra() : this(1,100){} //mamy 1 wypasiony konstruktor, nad którym pracujemy i drugi, który przypisuje konkretne wartości

        public Gra(int min=1, int max=100)
        {
            if (min >= max) throw new ArgumentException("min musi być mniejszy od max");
            MinZakres = min;
            MaxZakres = max;
            /*Random rnd = new Random(); */ wylosowanaLiczba = (new Random()).Next(MinZakres, MaxZakres + 1);
            StatusGry = Status.WTrakcie;
            CzasRozpoczecia = DateTime.Now;
            listaRuchow = new List<Ruch>();
        }
        public int Poddaj()
        {
            StatusGry = Status.Poddana;
            CzasZakonczenia = DateTime.Now;
            listaRuchow.Add(new Ruch(null, null, StatusGry));
            return wylosowanaLiczba;
        }

        //status gry
        public enum Status { WTrakcie, Poddana, Zakończona }
        public int? Wylosowana //typy wartościowe z pytajnikiem "nullables" - do zbioru wartości dodane zostaje null 
        {
            get
            {
                if (StatusGry != Gra.Status.WTrakcie)
                    return wylosowanaLiczba;
                else
                    return null; //gdy gra jest w trakcie nie masz prawa poznać wylosowanej liczby
            }
        }


    }
}
