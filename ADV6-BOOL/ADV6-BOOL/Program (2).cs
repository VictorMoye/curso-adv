using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV6_BOOL
{
    class Program
    {
        static void CriaLinha()
        {
            for (byte i = 0; i < 60; i++)
                Console.Write("-");
        }
        static void Main(string[] args)
        {
            CriaLinha();
            Console.WriteLine("\n CASOS DE USO DAS VARIAVEIS BOOLEANAS ");
            CriaLinha();

            bool eleitor, sexoMASCULINO;
            char sx;
            byte idade;
            Console.Write("\n qual sua idade : ");
            // FAZ O CASTING DO VALOR DIGITADO PARA byte 
            idade = byte.Parse(Console.ReadLine());
             
            //A VARIAVEL eleitor SO ARMAZENARA VALORES true /false 
            //NESTE CASO PODEMOS USAR EXPRESSÕES PARA OBTERMOS O 
            //RESULTADO BOOLEANO VEJAS OS EXEMPLOS 
            eleitor = idade >= 18 && idade < 65;
            Console.WriteLine("a IDADE : {0} É ELEITOR OBRIGATORIO ? : {1}",idade,eleitor);
            CriaLinha();
                Console.Write("\n qual o seu sexo ? digite [M] para masculino e  [F] para feminino ");
            sx= char.Parse (Console.ReadLine());
            sexoMASCULINO = (sx == 'm' || sx == 'M');
            Console.WriteLine("o sexo é masculino ? : {0}",sexoMASCULINO);
            Console.ReadKey();

        
           
        
        }
    }
}
