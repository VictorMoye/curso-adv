using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV8_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //chama o meotdo eleitor 
            eleitor();
        }
        static void eleitor()
        {



            //programa eleitor 
            byte idade;
            string msg;
            CriaLinha();
            Console.WriteLine("\n programa - eleitor ");
            CriaLinha();
            Console.Write("\n digite a sua idade : ");
            idade = byte.Parse(Console.ReadLine());

            //estrutura condicional 
            if (idade >= 18 && idade <= 65)
            {
                //entao 
                msg = "voce é eleitor adulto e todo adulto e eleitor obrigatorio  !";

            }
            else if (idade > 12 && idade < 18)
            {
                //entao 
                msg = "voce e adolescente e todo adolescente e eleitor facultativo !";
            }
            else if (idade > 65)
            {
                msg = "voce e idoso ! todo idoso e eleitor facultativo ";
            }
            else
            {
                //senao 
                msg = "voce e criança e pór isso não pode votar ";
            }

            CriaLinha();
            Console.WriteLine("\n {0}", msg);
            CriaLinha();
            continuar();
        }

        static void CriaLinha()
        {
            for (byte i = 0; i < 60; i++)
                Console.Write("-");
        }

        static void continuar()
        {
            char resp;
            Console.Write("\n Degeja continuar ? digite S/N []");
            Console.SetCursorPosition(30, 8);
            resp = char.Parse(Console.ReadLine());

            if (resp != 'n' && resp != 'n')
            {
                Console.Clear();
                eleitor();
            }

        }
    }
}
    


