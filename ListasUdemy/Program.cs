using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasUdemy
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listaLinhasArquivo = new List<string>();

            listaLinhasArquivo.Add("Wagner");
            listaLinhasArquivo.Add("joao");
            listaLinhasArquivo.Add("Maria");
            listaLinhasArquivo.Add("denis");
            listaLinhasArquivo.Add("Adenis");

            foreach (string item in listaLinhasArquivo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(listaLinhasArquivo.Count);

            string search = listaLinhasArquivo.Find(Procura);

            Console.WriteLine(search);
            Console.WriteLine("output");

                  Console.Read();
        }
        static bool Procura(string s)
        {
            return s[0] == 'A';
        }

      
    }
}
