using System;
using System.IO;
using System.Collections;
namespace OOP
{
    class Regra1
    {
        public int Tipo_Regra1 { get; set; }
        public void CalculoRegra1() { Console.WriteLine("Cálculo da REGRA I"); }
        private static void ProcessFile(string path)
        {
            Console.WriteLine("Processado '{0}' arquivo(s).", path);
        }
        private static void ProcessDirectory(string targetDirectory)
        {
            // lista de arquivos encontrados na pasta.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // retorna subdirectories dentro deste diretório.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }
        public void Catalog(string [] args)
        {
            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    // este path é um arquivo
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // este path é um diretório
                    ProcessDirectory(path);
                }
                else
                {
                    Console.WriteLine("{0} não é um arquivo ou diretório válido.", path);
                }
            }
        }
    }
}
