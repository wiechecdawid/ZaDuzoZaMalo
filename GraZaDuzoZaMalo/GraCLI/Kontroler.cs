using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraModel;

namespace GraCLI
{
    public class Kontroler
    {
        private Widok widok;
        private Gra gra;
     

        //konstruktor
        public Kontroler()
        {
            widok = new Widok(this); //utworzenie widoku/ referencja do obiektu, by widok wiedział, kto go stworzył
            gra = new Gra();
        }

        //MAPOWANIE Z GRY - pośredniki, poprzez które docieramy do fizycznych danych z Gry (bo nie dajemy widokowi dostępu)
        #region mapowanie z Gry dla widoku
        public Gra.Status StatusGry => gra.StatusGry; //getter. spójrz na blok.
        public TimeSpan CzasGry => gra.CalkowityCzasGry;
        public int MinZakres => gra.MinZakres;
        public int MaxZakres => gra.MaxZakres;
        public int? WylosowanaLiczba => gra.Wylosowana;
        public IReadOnlyCollection<Gra.Ruch> Historia => gra.HistoriaGry;
        #endregion

        public void Run()
        {
            //Opis gry
            widok.WypiszOpisGry();
            // dopóki chcesz kontynuować odpal rozgrywkę
            while (widok.ChceszKontynuowac()) //pytanie powinno pojawić się w widoku
                Rozgrywka();

        }

        public void Rozgrywka()
        {
            widok.CzyscEkran();
            //ToDo: ustaw zakres do losowania
            gra = new Gra(1, 100);
            Console.WriteLine("Wylosowano" + gra.wylosowanaLiczba); //do usunięcia
            do
            {
                int propozycja= 0;
                try
                { propozycja = widok.WczytajLiczbe(); }
                catch(PrzerwaneWprowadzanieException)
                {
                    gra.Poddaj();
                    break;
                }
                

                switch(gra.Ocena(propozycja))
                {
                    case Gra.Odpowiedz.ZaDuzo:
                        widok.WypiszKomunikatZaDuzo();
                        break;
                    case Gra.Odpowiedz.ZaMalo:
                        widok.WypiszKomunikatZaMalo();
                        break;
                    case Gra.Odpowiedz.Trafiony:
                        widok.WypiszKomunikatTrafiony();
                        break;
                }
            }
            while (gra.StatusGry == Gra.Status.WTrakcie);
            //wypisz status gry
            widok.WypiszStatystykiGry();
            widok.WypiszHistorieGry();
        }

        public void WypiszHistorieGry()
        {
            int i = 1;
            foreach (var ruch in kontroler.Historia)
            {
                Console.WriteLine($"{i}  {ruch.Liczba}  {ruch.Wynik}  {ruch.Czas}  {ruch.StatusGry}");
                i++;
            }
        }
    }
}
