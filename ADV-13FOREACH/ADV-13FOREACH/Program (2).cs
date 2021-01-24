using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_13FOREACH
{
    class Program
    {
        static void CriaLinha() {
            for (byte i = 0; i < 80; i++ ) {
                Console.Write
                    ("-");
            }
        }
        static void Main(string[] args)
        {
            CriaLinha();
            Console.SetCursorPosition(25,1);
            Console.Title = "Loop foreach ";
            CriaLinha();
            // array de nomes 
            string[] nomes = new string[5];
            //solicita 4 nomes 
            Console.Write("\n");

            for (int i = 0; i < nomes.Length; i++) {
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.Write("entre com o {0}° nome : ", 1);
                nomes[i] = Console.ReadLine();

                CriaLinha();
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.Write("interagindo no array nomes e exibindo cada nome \n");
                CriaLinha();

                //pegando os itens do array naomes com o loop foreach 
                int p = 1;
                Console.Write("\n");
                foreach (string nome in nomes) { 
                //exibe os nomes 
                    Console.SetCursorPosition(10, Console.CursorTop);
                    Console.Write("{0}° nome : {1}\n ", p++, nome);
                }
                CriaLinha();
                Console.SetCursorPosition(25,Console.CursorTop);
                Console.Write("---FIM----\n");
                CriaLinha();
                Console.ReadKey();

            }
            //estuda o que sognifica 
            //Console.CursorTop
            //foreach : ele interage na matriz pegando o valor contido em cada indice de forma sequencial 
            //porem nao oferece informação das localizaçoes deles em que veotr esta ou ate mesmo em qual casa 
            //por isso ele nao e indicado para edição de conteudo 
            //para conteudo verei em outra pagina 
            //Console.Title 

        }
    }
}
