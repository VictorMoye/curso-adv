using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV3_FLUTUANTES
{
    class Program
    {
        static void Main(string[] args)
        {
            // FLOAT 
            // OBS. PARA ATRIBUIR VALORES PARA AS AVRIAVEIS DO TIPO
            // float USAMOS a LETRA F ou f 
            float q = 2.5f;
            float d = 1.30f;
            float t = q * d;

            criaLinha();
            Console.WriteLine("\n exemplo com numéro float \n");
            Console.WriteLine("o valor : {0} * {1} é : {2}", q, d, t);
            Console.WriteLine("o valor {0} /4 é : {1}\n", t, t / 4);
            criaLinha();

            //DECIMAL
            //Obs.PARA ATRIBUIR VALORES PARA VARIAVEIS DO TIPO  
            //DECIMAL USAMOS A LETRA m OU M 

            Console.WriteLine("\n exemplo com numero decimal \n ");
            decimal p = 20.55M;
            decimal qtde = 100.5m;
            decimal total = p * qtde * 0.05m;
            Console.WriteLine("preço : {0} * {1} * 0.55 = {2}", p, qtde, total);

            criaLinha();
            Console.WriteLine("\n exemplo com numero double\n");

            //DOUBLE
            double x = 0.33;
            double y = 1.50, z = x * y;
            Console.WriteLine("o valor : {0} * {1} = {2} ", x, y, z);
            criaLinha();
            Console.Read();
        }
        static void criaLinha()
        {
            for (byte i = 0; i < 40; i++)
                Console.Write("-");
        }


    }
}
