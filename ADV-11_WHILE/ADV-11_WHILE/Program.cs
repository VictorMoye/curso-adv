using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_11_WHILE
{
    class Program
    {
        static void CriaLinha() {
            for (byte i = 0; i < 60; i++)
                Console.Write("-");
        }
        static void Main(string[] args)
        {
            int num, fat, count;
            //seta a cor fonte
            Console.ForegroundColor = ConsoleColor.Green;
            CriaLinha();
            Console.SetCursorPosition(25, 1);
            Console.Write("programa fatorial de um numero \n ");
            CriaLinha();
            Console.SetCursorPosition(20,5);
            Console.Write("digite um numero para obter o fatorial : ");

            try
            {
                num = fat = int.Parse(Console.ReadLine());
                //variavel count recebe o valort de fat -1 
                count = fat - 1;

                //enquanto a variavel count for >0 fat recebde o proprio fat*count 
                while (count > 0)
                {

                    fat *= count;
                    //decrementas a variavel count em 1 
                    count--;
                }
                Console.SetCursorPosition(25, 8);
                Console.Write("o fatorial de {0} é {1} ", num, fat);
                Console.SetCursorPosition(0, 10);
                CriaLinha();
                Console.SetCursorPosition(35, 11);
                Console.Write("FIM ");
                Console.SetCursorPosition(0, 12);
                CriaLinha();


            }
            catch (InvalidCastException invCastEx)
            {
                Console.WriteLine(" erro nao foi possivel realizar o cast do valor digitado para int ");
                Console.WriteLine("detalhe {0} ", invCastEx);

            }
            catch (OverflowException overEX)
            {
                Console.WriteLine("erro o valor numerico informado e maior ou menor que o limite aceito ");
                Console.WriteLine("detalhe {0} ", overEX);

            }
            catch (FormatException formEx)
            { Console.WriteLine("erro o formato invalido para um int ");
            Console.WriteLine("detalhe {0} ",formEx);
            }catch(Exception ex){
                Console.WriteLine("erro {0} ", ex);

            }
            finally { Console.ReadKey();
            }
        }
    }
}
