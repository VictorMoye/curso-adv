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
            string texto = "Curso adv informatica avançada ";
            Console.WriteLine("trabalhando com strings \n ");
            CriaLinha();

        //propriedade string.length retorna a quantidade de caracteres armazenados em 
        //variavel do tipo string 
            Console.WriteLine("\n a string : \"{0}\" possue : {1} caracteres \n ",texto,texto.Length);
            CriaLinha();
            //metodo string.replace ("palavra_atual","NOVA_PALAVRA "):substitui a 
            //palavra_atual por NOVA_PALAVRA 
            Console.WriteLine("\n trocando a palavra \"adv\"para ADV : {0}",
                texto.Replace("adv","ADV")) ;


               CriaLinha();

            //COLOCA A FRASE EM MAISCULO 
            Console.WriteLine("\n MAIUSCULO : {0} \n", texto.ToUpper());
            CriaLinha ();
            Console.WriteLine("\n minusculo : {0}", texto.ToLower());
            CriaLinha ();

     
            //dividindo a frase em pedaços 
            Console.WriteLine("\n quebrando o texto : \"{0}\" em partes ",texto);
            string[] ped = texto.Split (' ');
            for (byte i=0 ; i <ped.Length ; i++)
            {
            Console.WriteLine("\n parte : {0} : {1}", i+1, ped[i]);
            }
            CriaLinha ();

            //verificando se a palavra adv esta contido na cadeia de caracteres 
            int idx = texto.IndexOf ("adv");
            if(idx > 0){
            Console.WriteLine("\n a apalavra adv foi localizada no indice : {0}",idx);
            }
            else 
            {
                Console.WriteLine("\n a palavra adv nao foi localizada ");
            
            }
            CriaLinha();
            Console.Read();

        }  
        //cria linha pontilhada 
        static void CriaLinha()
        {
        Console.WriteLine("-");
        }















































        }
    }

