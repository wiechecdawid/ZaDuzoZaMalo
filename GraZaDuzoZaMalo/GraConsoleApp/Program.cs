﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraModel;

namespace GraModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Gra g = new Gra(1, 100);
            g.Czasomierz();
            do
            {
                while (true)
                {
                    Console.WriteLine("Podaj propozycję (x-poddaj się): ");
                    string napis = Console.ReadLine();
                    if ((napis.ToLower().Trim()).Equals("x")) //NAPISÓW NIE WOLNO PORÓWNYWAĆ ZA POMOCĄ ==
                    {
                        Console.WriteLine("wynik = {0}. KONIEC GRY. \nCzas gry: {1}\nNaciśnij ENTER by wyjść", g.Poddaj(), g.Czas);
                        Console.ReadLine();
                        return; //funkcja Main nie zwraca wyniku więc nie musi zwracać liczby
                        //Environment.Exit(1); - systemowe, bezwarunkowe wyjście z aplikacji
                    }
                    int propozycja = 0;
                    
                    try
                    {
                        propozycja = Int32.Parse(napis); //var zmusza do wywnioskowania typu (było ale trza było przenieść bo SCOPE)
                    }
                    //instrukcja sterująca catch - hierarchia wywoływania wyjątków LICZY SIĘ
                    catch (FormatException) // mogę go nazwać, ale nie muszę
                    {
                        Console.WriteLine("nie przypomina liczby");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Przesadziłeś z wielkością liczby");
                        continue;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("nieznany wyjątek");
                        Console.WriteLine(e.StackTrace);
                        continue;
                    }

                    Console.WriteLine(g.Ocena(propozycja));
                    break;
                }
            }
            while (g.StatusGry==Gra.Status.WTrakcie);

            Console.ReadLine();
        }
    }
}
