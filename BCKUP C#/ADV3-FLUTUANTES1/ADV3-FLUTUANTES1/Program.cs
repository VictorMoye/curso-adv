using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV3_FLUTUANTES
{
    class Program
    {
        static void Main(string[] args)
        { // FLOAT
          // OBS. PARA ATRIBUIR VALORES PARA AS VARIAVEIS DO TIPO
          //      float USAMOS A LETRA F OU f

        float q=2.5f;
        float d=1.30f;
        float t= q*d;

        CriaLinha();
        Console.WriteLine("\n Exemplo com numerico float\n");
        Console.WriteLine("O valor :" + q +" * " + d +" é :"+ t);
        Console.WriteLine("O valor : " + t + " /4  é : " + t / 4);
        CriaLinha();

        //DECIMAL
        //OBS. PARA ATRIBUIR VALORES PARA AS VARIAVEIS DO TIPO
        //     decimal USAMOS A LETRA M ou m


        Console.WriteLine("\n Exemplo com numero decimal \n");
        decimal p = 20.55m;
        decimal qtde = 100.5m;
        decimal total = p * qtde * 0.005m;
        Console.WriteLine("preço: "+p+" * "+qtde+" * 0.05 = "+total);
        CriaLinha();
        Console.WriteLine("\n Exemplo com numero double\n");


        //DOUBLE
        double x = 0.33;
        double y = 1.50, z = x * y, evan = 0.43;
        Console.WriteLine(" O valor : " + x + " * " + y + " = " + z);
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

