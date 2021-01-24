using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_12_DO_WHILE_AND_FOR
{
    class Program
    {
        static void CriaLinha() {
            for (byte i = 0; i < 60; i++)
                Console.WriteLine("---");

        }
        static void Main(string[] args)
        {
            int num;
            char cont;
            do //faça
            {
                Console.Clear();
                CriaLinha();
                Console.SetCursorPosition(30, 1);
                Console.Write("programa tabuada ");
                Console.SetCursorPosition(0, 2);
                CriaLinha();
                Console.SetCursorPosition(15, 3);
                Console.Write("digite um numero para obter a tabuada :");
                num = int.Parse(Console.ReadLine());
                CriaLinha();
                //a cada passagem do loop do while o loop for e executado 
                //gerando a multiplicação 
                for (int i = 1; i < 20; i++)
                {
                    Console.SetCursorPosition(15, i + 4);
                    Console.WriteLine("{0} * {1} = {2}", num, i, num * i);

                }
                CriaLinha();
                Console.SetCursorPosition(15, 17);
                Console.Write("degeja continuar : [S/N]");
                Console.SetCursorPosition(38, 17);
                cont = Console.ReadKey().KeyChar;
                cont = char.Parse(cont.ToString().ToUpper());

            } while (cont == 's');

        }
    }
}
