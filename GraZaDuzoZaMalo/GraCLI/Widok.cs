using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GraCLI
{
    public class Widok //nie chcemy żeby komunikował się z modelem, a jedynie z kontrolerem
    {
        //deklaracja publicznej stałej X (typ char)
        public const char ZNAK_ZAKONCZENIA = 'X';
        public static readonly string TEKST_ZACHETY = $"Podaj liczbę (lub "+ ZNAK_ZAKONCZENIA + " aby zakończyć): "; //jeżeli coś jest stałą, nie można tego "zbudować"

        public void CzyscEkran() => Clear(); //Console.Clear() - funkcja czyść ekran

        //tworzymy konstruktor by komunikował się z modelem przez kontroler
        private Kontroler kontroler;
        public Widok(Kontroler kontroler) //formalnie rodzic - parent
        {
            this.kontroler = kontroler;
        }

        //wczytuje liczbe całkowitą, lub zgłasza wyjątek gdy X
        public int WczytajLiczbe()
        {
            int wynik=0;

            //Write(TEKST_ZACHETY); - nie tutaj
            while(true)//wykonuje się w nieskończoność jeśli nie dasz break
            {
                Write(TEKST_ZACHETY);
                try
                {
                    string napis = ReadLine().Trim().ToUpper();
                if (napis.Length>0 && napis[0].Equals(ZNAK_ZAKONCZENIA))
                    throw new PrzerwaneWprowadzanieException();
                
                    wynik = int.Parse(napis); //lub: Convert.ToInt32(napis);
                    break;
                }
                catch(PrzerwaneWprowadzanieException e) //chcę podać dalej wyjątek. Podanie nazwy przechwytuje wyjątek i zapamiętuje go pod nazwą e, której mogę użyć w poniższym kodzie.
                {
                    WriteLine("Naciśnięto " + ZNAK_ZAKONCZENIA + ". Koniec gry. Wy%$#^alaj.");
                    throw e; //podaj dalej - w trakcie obsługi przechwytuje wyjątek i przekazuję go na zewnątrz, tak by ktoś mógł przechwycić go poza blokiem
                    //wyjątek przechodzi do funkcji main, którą trzeba zaprogramować by się nim zainteresowała.
                }
                catch(FormatException)
                {
                    WriteLine("Wprowadzony tekst nie przypomina liczby całkowitej. Spróbuj jeszcze raz.");
                    continue;
                }
                catch(OverflowException)
                {
                    WriteLine("Przesadziłeś-zbyt duża liczba. Spróbuj jeszcze raz.");
                    continue;
                }
                catch (Exception)
                {
                    WriteLine("Nieznany błąd Spróbuj jeszcze raz.");
                    continue;
                    
                }
            }
            return wynik;
        }

        public void WypiszOpisGry()
        {
            WriteLine("Pierdu pierdu sratatata nie odganiesz liczby, nie ma bata");
        }
        public void WypiszKomunikatZaDuzo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Za Dużo!");
            Console.ResetColor();
        }
        public void WypiszKomunikatZaMalo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Za Mało!");
            Console.ResetColor();
        }
        public void WypiszKomunikatTrafiony()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Trafiony!");
            Console.ResetColor();
        }
        public bool ChceszKontynuowac() //może być property
        {
            WriteLine("Czy chcesz kontynuować? (T/N)");
            char odp = ReadKey().KeyChar; //KeyChar zwraca nr klawisza
            WriteLine();
            return (odp == 't' || odp == 'T');

        }
        public void WypiszStatystykiGry()
        {
            WriteLine("Status gry: "+kontroler.StatusGry);
            WriteLine("Wylosowano liczbę {0} z zakresu {1} do {2}", kontroler.WylosowanaLiczba, kontroler.MinZakres,kontroler.MaxZakres);
            WriteLine("Liczba prób " + kontroler.Historia.Count);
            WriteLine("Czas gry: " + kontroler.CzasGry.TotalSeconds + "s");
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
