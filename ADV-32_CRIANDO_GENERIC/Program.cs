using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADV_32_CRIANDO_GENERIC; 
using ADCV_32_CLASS_LIBRARY;

namespace ADV_32_CRIANDO_GENERIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARVORE BINARIA DE INT \n"); 
            // arvore 1
            Arvore<int> arvore = new Arvore<int>(10);
            arvore.Insert(20);
            arvore.Insert(12);
            arvore.Insert(2);
            
            // exibe a arvore 1 
            arvore.PeDaArvore();

            Console.WriteLine("\n ARVORE BINARIA DE STRING \n");
            // arvore 2 
            Arvore<string> arvore2 = new Arvore<string>("pedro"); 
            arvore2.Insert("jessica");
            arvore2.Insert("willis");
            arvore2.Insert("bolsonario");
            arvore2.Insert("leonardo");
            arvore2.Insert("luciano");
            arvore2.Insert("mauro");

            // EXIBE A ARVORE 2
            arvore2.PeDaArvore();
            Console.WriteLine("\n arvore binaria de char \n "); 
            Arvore<char>arvore3 = new Arvore<char>('A');
            arvore3.Insert('D');
            arvore3.Insert('F');
            arvore3.Insert('H');
            arvore3.Insert('J');
            arvore3.Insert('B');

            // exibe a arvore 3
            arvore3.PeDaArvore();
            Console.ReadKey();
        }
    }
}
