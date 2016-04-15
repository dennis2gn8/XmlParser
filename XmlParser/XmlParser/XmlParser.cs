using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XmlParser
{
    class XmlParser
    {
        private string filecheck { get; set; }


        public void GetDirectory()
            {
            string dirPath = @"C:\ParseTest";

           

    List<string> Files = new List<string>(Directory.EnumerateFiles(dirPath));

            var id = new List<int>();
            Dictionary<int, String> testDict = new Dictionary<int, string>();


            //Start Hier wird für jedes File eine ID gesetzt
            for (int i = 0; i < Files.Count; i++)
            {
                testDict.Add(i+1, Files[i]);
            }
          


              foreach (string file in Files)
              {
                  string filecheck = file;
                  if (filecheck != null)
                  {
                      Console.WriteLine("Es wurde ein Files gefunden" +  filecheck);
                      Console.ReadLine();
                  }

                  else if (filecheck == null)
                  {
                      Console.WriteLine("Keine File gefunden");
                      Console.ReadKey();
                  }

              }
              

        }
    }
}
