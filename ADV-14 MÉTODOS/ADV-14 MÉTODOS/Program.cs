using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_14_MÉTODOS
{
    class Metodos
    {  //escopo global das classes , variaveis escritas aqui 
        //sera visivel em todos os metodos das classes 
        static DateTime data = DateTime.Now;
        static TimeSpan tempo = new TimeSpan(data.Hour, data.Minute, data.Second);

        //Metodo que cria a linha pontilhada 
        static void CriaLinha()
        {
            for (byte i = 0; i < 60; i++)
                Console.Write("-");

        }
        //arranque do programa 
        static void Main(string[] args)
        {
            //chama o metodo cria menu 
            criaMENU();
        }
        //metodo sem retorno que cria opções 
        static void criaMENU()
        {
            //limpa tela 
            Console.Clear();
            //cabeçalho 
            CriaLinha();
            Console.SetCursorPosition(15, Console.CursorTop);
            //definido o titulo do programa com a data contida na variavel global data 
            Console.Title = data.ToLongDateString();
            Console.Write("programa ultilizado metodos (METHODS)\n ");

            CriaLinha();
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.Write("escolha o metodo abaixo : ");
            Console.SetCursorPosition(12, Console.CursorTop + 1);
            Console.WriteLine("[1] fatorial ");
            Console.SetCursorPosition(12, Console.CursorTop);
            Console.WriteLine("[2] numero primo ");
            Console.SetCursorPosition(12, Console.CursorTop);
            Console.WriteLine("[3] é impar ou par ");
            CriaLinha();

            Console.SetCursorPosition(12, Console.CursorTop);
            try
            {
                Console.Write("digite o metodo escolhido : []");
                Console.SetCursorPosition(40, Console.CursorTop);
                byte opcao = byte.Parse(Console.ReadLine());
                chamaMetodoDaOpcao(opcao);
            }
            catch (Exception)
            {
                Console.SetCursorPosition(12, Console.CursorTop + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("informe apenas numeros inteiros o menu metodo escolhido ? ");

                //reseta a cor do texto 
                Console.ResetColor();

                //chama o metodo que controla a continuação do programa 
                Continuar();
            }


        }
        //metodo que recebe a opção escolhida é chama o metodo responsavel 
        static void chamaMetodoDaOpcao(byte opcao)
        {
            int num;
            CriaLinha();
            try //propicio a erros 
            { //testa os casos para a opção 
                switch (opcao)
                {
                    case 1:
                        Console.SetCursorPosition(12, Console.CursorTop);
                        Console.Write("digite um numero para obter o fatorial : ");
                        num = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(12, Console.CursorTop + 1);

                        //chama o metodo que retorna o farial de um numero e escreve o resultado 
                        Console.WriteLine("o fatorial de : {0} é {1}", num, Fatorial(num));

                        //chama o metodo que controla a continuação do programa 
                        Continuar();
                        break;
                    case 2:
                        Console.SetCursorPosition(12, Console.CursorTop + 1);
                        Console.Write("digite um numero pra verificar se é primo : ");
                        num = int.Parse(Console.ReadLine());

                        Console.SetCursorPosition(12, Console.CursorTop + 1);

                        //chama o metodo que retorna true/false (primo / nao primo )
                        Console.WriteLine("o numero : {0}  é primo : {1} ", num, Eprimo(num) == true ? "sim" : "não");

                        //chama o metodo que controla a continuação do programa 
                        Continuar();
                        break;
                    case 3:
                        Console.SetCursorPosition(12, Console.CursorTop);
                        Console.Write("digite um numero para verificar se é par ou impar : ");
                        num = int.Parse(Console.ReadLine());
                        Console.SetCursorPosition(12, Console.CursorTop + 1);

                        // chama o metodo que retorna par ou impar 
                        Console.WriteLine("o numero {0} é {1}", num, EparOUimpar(num));

                        //chama o metodo que controla a continuação do programa 
                        Continuar();
                        break;
                    default:
                        Console.SetCursorPosition(12, Console.CursorTop + 1);

                        //muda a cor do texto 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("opção : {0} é invalida ", opcao);

                        //resetar a cor do texto 
                        Console.ResetColor();

                        //chama o metodo que controla a continuação do programa 
                        Continuar();
                        break;
                }


            }
            catch (Exception)
            {
                Console.SetCursorPosition(12, Console.CursorTop + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("informe apenas numeros inteiros para o metodos");

                // resetar a cor do texto 
                Console.ResetColor();

                //chama o metodo que controla a continuação do programa 
                Continuar();
            }
        }
        //metodo fatorial , faz um loop multiplicando o valor informado 
        //pelo os seus antecessores maiores que 1 e retorna um fatorial 
        static int Fatorial(int num)
        {
            int count = num - 1;
            while (count > 1)
            {
                num *= count;
                count--;
            }
            return num;

        }
        //metodo que verifica se o numero é primo 
        static bool Eprimo(int num)
        {
            bool primo = true;
            for (int i = num - 1; i > 1; i--)
            {
                if (num % 1 == 0)
                {
                    primo = false;
                }
            }
            return primo;
        }
        //metodo que verifica se um numero é par 
        static string EparOUimpar(int num)
        {
            if (num % 2 == 0)
            {
                return "par";
            }
            else
            {
                return "impar";
            }

        }
        //metodo continuar 
        static void Continuar()
        {
            char cont;
            Console.SetCursorPosition(15, Console.CursorTop + 2);
            Console.Write("deseja continuar ? []");
            Console.SetCursorPosition(33, Console.CursorTop);
            cont = Console.ReadKey().KeyChar;
            if (cont == 's' || cont == 's')
            {
                criaMENU();
            }
            else
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                //chama o metodo cria linha 
                CriaLinha();
                Console.SetCursorPosition(25, Console.CursorTop);

                //ultilizando a variavel (tempo) do escopo global 
                Console.WriteLine("tempo de uso : {0}", (DateTime.Now - tempo).ToLongTimeString());
                Console.SetCursorPosition(25, Console.CursorTop);
                Console.Read();
            }
        }
    }
}
//METODO E UMA SEQUENCIA NOMEADA DE INTRUÇÕES E QUASE UMA FUNÇÃO OU UMA SUB-ROTINA 
//ELE E COMPOSTO DE NOME E CORPO 
//O NOME DEVE SER BEM INDENTIFICADO COMO UM INDENTIFICADOR BEM SIGNIFICATIVO QUE INDIQUE A SUA FINALIDADE 
//LOGIN_DO_SISTEMA POR EXEMPLO 
//E O CORPO SAO AS INTRUÇÕES A SEREM EXECUTADAS QUANDO O NOME DO METODO E CHAMADO 
//ELES PODEM RECEBER DADOS PROCESSAR ELES E RETORNAM INFORMAÇÕES DOS DADOS PROSEÇADOS 
//PARA O CHAMADOR 
//SENDO UM MECANISMO PODEROSO E FUNDAMENTAL 
//COM OS METODOS PODEMOS DECOMPOR O PROGRAMA EM PARTES QUE REALIZAM DETERMINADAS TAREFAS 
//UM FORTE EXEMPLO Exception O METODOD CRIARLINHA (); 
//QUE MAIS USO TODA VEZ QUE CHAMAMOS ELE ELE EXECUTA A FUNÇÃO CONTIDA NELE E DEPOIS O PROGRAMA SEGUE SEU CURSO NORMAL 