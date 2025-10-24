using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_file
{
    internal class Writer
    {
        private string filePath;

        public Writer(string path) 
        {
            filePath = path; 
        }

        public void ScriviFile() 
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Prima riga");
                    writer.WriteLine("Seconda riga");
                    writer.WriteLine("Terza linea");

                }

                Console.WriteLine("File scritto con succeso");

            }
            catch (Exception ex)
            {
                Console.WriteLine("errore nella scritttura del file" + ex.Message);
            }
        }

    }
}
