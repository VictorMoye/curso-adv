using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_30_GENERIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "trabalhando com genericos "; 

            // variavel que controlara o numero de clientes cadastrados 
            char Key; 

            // gera o codigo 
            int codigo = 100; 

            // fila que recebe objeto cliente como parametro 
            Queue<Cliente> queue = new Queue<Cliente>();
            Console.WriteLine("program - generic"); 

            // loop que adiciona os clientes na queue 
            do 
            {
                // objeto cliente 
                Cliente cliente = new Cliente ();

                cliente.Codigo = codigo ; 
                Console.Write("entre com o nome : "); 
                cliente.Nome = Console.ReadLine();
                Console.Write("Entre com o segundo nome :"); 
                    cliente.sobreNome = Console.ReadLine();

                queue.Enqueue (cliente);
                // encrementa o codigo em 1 
                codigo++; 

                // informa o usuario 
                Console.WriteLine("\n precione ESC para finalizar o cadastr oou qualquer tecla para continuar \n"); 
                Key = Console.ReadKey().KeyChar; 

                // enquanto o usuario nao preciona a tecla esc 
            }while (Key != 27); 

            // ao sair do llop le os clientes cadastrados 
            Console.Clear();
            Console.WriteLine("leitura da fila ");

            // inteira na queue removendo os itens 
            while (queue.Count > 0)
            {
                // remove o item da fila 
                // obeserve que e seguro atribuir para o o bjeto cliente porque cada item é do tipo cliente 
                Cliente cliente = new Cliente (); 
                cliente = queue.Dequeue();

                // exibe o registro atual 
                Console.WriteLine("codigo : {0} nome {1} sobrenome  {2}",cliente.Codigo,cliente.Nome, cliente.sobreNome); 
            }
            Console.ReadKey();
        }
    }
}
