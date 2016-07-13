using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Menu menu = new Menu();
            
            while (exit == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*************************************");
                Console.WriteLine("*             Hauptmenü             *");
                Console.WriteLine("*************************************");
                Console.WriteLine("*                                   *");
                Console.WriteLine("* 1.) Vorhandene Nutzer anzeigen    *");
                Console.WriteLine("* 2.) Statistik je Nutzer anzeigen  *");
                Console.WriteLine("* 3.) Reportnamen anzeigen          *");
                Console.WriteLine("* 4.) Einzelreportnamen ausgeben    *");
                Console.WriteLine("* 5.) Weitere relevante Daten       *");
                Console.WriteLine("* 6.) Statistikerweiterung anzeigen *");
                Console.WriteLine("* 7.) Persistente Quelle einbinden  *");
                Console.WriteLine("* X.) Programm beenden              *");
                Console.WriteLine("*                                   *");
                Console.WriteLine("*************************************");

                string confirm = Console.ReadLine();

                switch (confirm)
                {
                    case "1":
                        menu.showUsers();
                        break;
                    case "2":
                        menu.showStatistic();
                        break;
                    case "3":
                        menu.showReportName();
                        break;
                    case "4":
                        menu.showReportData();
                        break;
                    case "5":
                        menu.showRelevantData();
                        break;
                    case "6":
                        menu.showAdvancedStatistics();
                        break;
                    case "7":
                        menu.postFile();
                        break;
                    case "X":
                        exit = true;
                        break;
                    case "x":
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unerlaubte Eingabe! Wiederholen mit Enter...");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();

            }
        }      
    }
}
