using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADB2_INTEIROS
{
    class Program
    {
        static void Main(string[] args)
        { // byte
            byte idade = 40;
            Console.WriteLine("VARIAVEIS DO TIPO INTEIRAS");
            CriaLinha();
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("\n variavel byte: {0}",idade);
            CriaLinha(); 

            //sbyte
            sbyte graus = -32;
            Console.WriteLine("\n variavel sbyte : {0}",graus);
            CriaLinha();
            short s = 32000;
            Console.WriteLine("\n variavel do tipo short :{0}",s);
            CriaLinha();

            Console.SetCursorPosition(8,10);
            Console.Write("-------FIM------");
            Console.Read();
            }
        static void CriaLinha()
        {
            for (byte I = 0; I < 40; I++) 
                Console.Write("-");
        }



    }
}
