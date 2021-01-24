using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV1
{
    class Program
    {
        static void Main(string[] args)
        {

            string strNOME;
            Console.WriteLine("meu programa no Visual c# 2010 Express \n");
            Console.Write("==============================================\n");
            Console.Write("Digite seu nome : ");
            strNOME = Console.ReadLine();
            Console.Write("\nBem-vindo (a) ; {0} este é o seu primeiro dia programando \n",strNOME);
            Console.Write("===================================================================");

            Console.WriteLine("\n\n----------------FIM-------------");
            Console.Read(); 
        }
    }
}
