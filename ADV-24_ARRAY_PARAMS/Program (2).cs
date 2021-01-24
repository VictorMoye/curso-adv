using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_24_ARRAY_PARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            // define o titulo 
            Console.Title = "Trabalho com ARRAY PARAMS ";
            Console.WriteLine("Descobrindo qual o menor e o maior valor em um conjunto de dados ");
            Console.SetCursorPosition(5, 3);
            Console.WriteLine("Conjunto [10,5,3,20,30,50]");

            Console.SetCursorPosition(5, 5);
            Console.WriteLine(" o menor valor é {0}", MenorValor(10, 5, 3, 20, 30, 50));

            Console.SetCursorPosition(5, 6);
            Console.WriteLine("o maior valor valor é {0}", MaiorValor(10, 5, 3, 20, 30, 50));

            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Conjunto [10,50,30,20,40,66,80,77,55,66,99,33]");

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("o menor valor é {0}",MenorValor(10,50,30,20,40,66,80,77,55,66,99,33));

            Console.SetCursorPosition(5,11);
            Console.WriteLine("O Maior valor é {0}",MaiorValor(10,50,30,20,40,66,80,77,55,66,99,33));
            Console.ReadKey();

        }
        /*
         * retorna o menor numero encontrado no array de numeros 
         */
        static int MenorValor(params int[] paramList)
        {// inicia a variavel menor com o maior valor aceito por um tipo int 
            int menor = int.MaxValue;

            //pega cada valor informado e chama ao metodo 
            foreach (int n in paramList)
            {
                /*
                 * verifica se o valor informado e manor que o valor contido na variavel menor 
                 * se verdadeiro atribui a valor na variavel menor 
                 */

                if (menor > n )
                {
                    menor = n;
                }
            }// retorna o menor valor contido na variavel menor 
            return menor;
        }
        // retorna o maior numero encontrado no array de numeros
        static int MaiorValor(params int[] paramList)
        {
            // inicia a variavel menor com  o maior valor aceito por um tipo int 
            int maior = int.MinValue; 

            // pega cada valor informado e chama ao metodo 
            foreach(int n in paramList)
            {
                // verifica se o valor informado e maior que o valor contiduo na variavel maior 
                // severdadeiro atribui o valor para a variavel maior 

                if (maior < n)
                    maior = n;
            }
            // retorna o maior valor contido na variavel maior 
            return maior;
        }
 
    }
}
