using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_28_DELEGATE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Utilizando o Delegate ";
            Console.WriteLine("PROGRAMA FABRICA AUTOMATIZADA ");
            Console.WriteLine("");

            // objeto controle 
            Controle controle = new Controle();

            // objeto pintura 
            Pintura pintura = new Pintura();
            
            // objeto solda 
            sOLDA solda = new sOLDA();

            // objeto modelagem 
            Modelagem modelagem = new Modelagem(); 

            // adiciona os metodos do objeto ao delegate 
            controle.Addiciona(pintura.StopPintura);
            controle.Addiciona(solda.StopSolda);
            controle.Addiciona(modelagem.StopModelagem);

            Console.WriteLine("1 - {0}",Pintura.NOMEMAQUINA);
            Console.WriteLine("2- {0}", sOLDA.NOMEMAQUINA);
            Console.WriteLine("3-{0}",Modelagem.NOMEMAQUINA);
            Console.WriteLine("");

            // lê a ação 
            char acao = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            switch (acao)
            {
                case '1': controle.Remove(pintura.StopPintura);
                    Console.WriteLine("\n maquina {0} foi removida ", Pintura.NOMEMAQUINA);
                    break;
                case '2': controle.Remove(solda.StopSolda);
                    Console.WriteLine("\n maquina {0} foi removida ", sOLDA.NOMEMAQUINA);
                    break;
                case '3': controle.Remove(modelagem.StopModelagem);
                    Console.WriteLine("\n maquina {0} foi removida ", Modelagem.NOMEMAQUINA);
                    break;
            }
            Console.WriteLine("\n pressione a tecla enter para desligar as maquinas \n"); 

            // chave de desligamento 
            char Key = Console.ReadKey().KeyChar;
            if (Key == 13)
            {
                // desliga as maquinas 
                controle.ShutDown();
            }
            else 
            {
                Console.WriteLine("Ação cancelada ");
            }
            Console.ReadKey();
        }
    }
}
