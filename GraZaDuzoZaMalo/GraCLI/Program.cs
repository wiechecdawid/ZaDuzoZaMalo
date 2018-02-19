using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraModel;

namespace GraCLI
{
    class Program 
    {
        public static void TestWprowadzaniaLiczby()
        {
            Widok w = new Widok(null);
            try
            {
                int liczba = w.WczytajLiczbe(); //metoda mogłaby być statyczna zamiast na rzecz klasy - nawet lepiej
                Console.WriteLine("Podałeś " + liczba);
            }
            catch
            {
                Console.WriteLine("PaPa");
            }
        }
        static void Main(string[] args)
        {
            // program ma wyglądać tak:
            Kontroler kontroler = new Kontroler();
            kontroler.Run();

            
            
        }
    }
}
