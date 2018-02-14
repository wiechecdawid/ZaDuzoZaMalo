using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraModel //logika gry
{
    public class Gra
    {
        readonly private int wylosowanaLiczba; //readonly jest metodą - może być użyty przy polach private
        //przy projektowaniu można na chwilę zmienić na public, albo zrobić metodę w ramach klasy, aby wyświetlić priv.
        public int MinZakres { get; } //private set; - mogę zmienić wewnątrz mojej klasy (readonly nie)
        public int MaxZakres { get; }
        public TimeSpan Czas { get; private set; }
        //do zrobienia: czas gry, historia ruchów
        public Status StatusGry { get; private set; }
        public Odpowiedz Ocena(int propozycja)
        {
            if (propozycja < wylosowanaLiczba) return Odpowiedz.ZaMalo;
            else if (propozycja == wylosowanaLiczba)
            {
                StatusGry = Status.Zakończona;
                return Odpowiedz.Trafiony;
            }
            else return Odpowiedz.ZaDuzo;
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
        }

        public void Czasomierz()
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            if (StatusGry!=Status.WTrakcie)
            {
                time.Stop();
                Czas = time.Elapsed;
            }
           
        }
        
        public int Poddaj()
        {
            StatusGry = Status.Poddana;
            return wylosowanaLiczba;
        }

        //status gry
        public enum Status { WTrakcie, Poddana, Zakończona }
        
        
    }
}
