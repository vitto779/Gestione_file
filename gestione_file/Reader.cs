using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_file
{
        internal class Reader
    {
        private string filePath;

        public Reader(string path)
        {
            filePath = path;
        }

        public void LeggiFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore nella lettura del codice" + e.Message);
            }
        }


    }
}
