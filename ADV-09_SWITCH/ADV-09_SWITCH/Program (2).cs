using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_09_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Double vlr1, vlr2, result ;
            char Op;
            Console.Title = "PROGRAMA ESTRUTURADA switch (OPERAÇÕES MATEMATICA )";
            CriaLinha();
            Console.WriteLine("\n PROGRAMA ESTRUTURA switch (OPERAÇÕES MATEMATICAS )");
            CriaLinha();
            Console.SetCursorPosition(5,4);
            Console.Write("DIGITE O PRIMEIRO NUMERO : ");
            vlr1 = Double.Parse (Console.ReadLine());
            Console.SetCursorPosition(5,5);
            Console.Write("DIGITE O SEGUNDO NUMERO ");
            vlr2 = double.Parse (Console.ReadLine());
            
            CriaLinha();
            Console.SetCursorPosition(5,7);
            Console.Write("DIGITE A OPERAÇÃO []");
            Console.SetCursorPosition(24,7);
            Op = Console.ReadKey().KeyChar;
            Console.SetCursorPosition(0,8);
            CriaLinha();
            Console.SetCursorPosition(10,9);
            Console.Write("Resultado :");

            //ESTRUTURA switch
            switch (Op)
            {
                case '+': 
                    result = vlr1 + vlr2 ;
                    Console.WriteLine ("{0} {1} {2} = {3}",vlr1,Op,vlr2, result);
                    break ;
                case '*':
                    result = vlr1 * vlr2 ;
                    Console.WriteLine("{0} {1} {2} = {3}",vlr1,Op,vlr2 ,  result);
                    break;
                case '/':
                    result = vlr1/ vlr2 ;
                    Console.WriteLine("{0} {1} {2} = {3}",vlr1,Op,vlr2, result);
                    break;
                case '%':
                    result = vlr1 % vlr2 ;
                    Console.WriteLine("{0} {1} {2} = {3}",vlr1,Op,vlr2, result);
                    break;
                default: 
                    Console.WriteLine("a operação digitada nao e valida use [+-*%]");
                    break;
            }
            Console.Read();

     
        }
        static void CriaLinha(){
        for (byte i=0; i < 60 ; i++);
        }

        }
    }

