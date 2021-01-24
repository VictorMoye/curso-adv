using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV5_ENUM
{

    enum MESES
    {
        janeiro = 1, //altera a inicialização do indice para 1 
        fevereiro,
        março,
        abril,
        maio,
        junho,
        julho,
        agosto,
        setembro,
        outubro,
        novembro,
        dezembro
    }

    class Program
    {
        static void CriaLinha()
        {
            for (byte i = 0; i < 40; i++)
                Console.Write("-");
        }
        static void Main(string[] args)
        {
            CriaLinha();
            Console.WriteLine("\n trabalho com ENUM");
            CriaLinha();
            Console.WriteLine("\n no mes de : {0} o instrutor pedro estara de férias ",MESES.março );
            CriaLinha();
            Console.WriteLine("\n lista os intens de um ENUM atraves do indice ");
            //definimos uma variavel dotipo meses e iniciamos co mo primeiro mes da lista 
            MESES eMeses = MESES.janeiro;
            for (byte i = 1; i <= 12; i++)
            {
                Console.WriteLine("mes {0} : {1} ",i, eMeses);
                //INCREMENTA O INDICE DO ENUM PASSANDO PARA O PROXIMO MES  
                eMeses++;

            }
            CriaLinha();
            Console.ReadKey();
        }
    }
}
