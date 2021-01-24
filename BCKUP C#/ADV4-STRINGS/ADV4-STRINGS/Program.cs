using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV4_STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Curso avd Informatica Avançada";
            Console.WriteLine("trabalhando com strings \n");
            CriaLinha();
            // PROPRIEDADE string.length RETORNA A QUANT DE CARACTERES ARMAZENADOS
            // EM VARIAVEL DO TIPO string
            Console.WriteLine("\n a string: " + texto + "possue:{0} caracteres \n", texto.Length);

            CriaLinha();
            //Metodo string.Replace("palavra_atual","nova_palavra") :
            //Substitui a palvara_atual por nova_palavra
            Console.WriteLine("\n trocando a palavra\"adv\"para ADV:{0}", texto.Replace("adv", "ADV"));

            CriaLinha();
            //Coloca a frase em maisculo e minusculo
            Console.WriteLine("\n Maisculo:{0} \n", texto.ToUpper());
            CriaLinha();
            Console.WriteLine("\n Minusculo:{0} \n", texto.ToLower());
            
            CriaLinha();
            //Dividindo a frase em pedaços
            Console.WriteLine("\n Quebrando o texto:\"{0} \" em partes",texto);
            string[] ped = texto.Split();
            for (byte i=0;i< ped.Length;i++)
            {
                Console.WriteLine("\n Parte:{0}:{1}", i + 1, ped[i]);
            }
            CriaLinha();

            //Verificando se a palavra adv esta contido na cadeia de caract
            int idx = texto.IndexOf("adv");
            if (idx > 0)
            {
                Console.WriteLine("\n A palavra adv foi localizada no indice {0}",idx);
            }
            else
            {      
                Console.WriteLine("\n A palavra nao foi localizada");

            }
            CriaLinha();
            Console.Read();



   

       
          
        }

        static void CriaLinha()
        {
            for (byte i = 0; i < 40; i++)
                Console.Write("-");
        }



    }

        

}
