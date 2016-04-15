using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlParser
{
    class Erfassung
    {
        Abfrage abfrage = new Abfrage();
        XmlParser xmlparser = new XmlParser();
        public void ConsolenErfassung ()
        {
             try
            {
                Console.WriteLine("Willkommen \nWollen Sie ihr Dokument Parsen \nJa\nNein");

                string request= Console.ReadLine();
                string lowchar = request.ToLower();

                if (lowchar == "ja")
                {
                    xmlparser.GetDirectory();
                }
                else if  (lowchar == "nein")
                {
                    Console.WriteLine("Mach nichts");
                    Console.ReadKey();
                }
                else if (lowchar != "nein" || lowchar != "ja")
                {
                    abfrage.reset();
                }

            }
            catch
            {
                Console.WriteLine("Ein Parse Fehler ist aufgetretten");
                Console.ReadKey();
            }
        }
            
       
    }
}
