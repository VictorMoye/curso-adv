using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_10_TRY_CATCH_FINALY
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratando exceções 
            byte idade;
            CriaLinha();
            Console.SetCursorPosition(10, 2);
            Console.Write("--programa tratamento de exceções--");
            Console.SetCursorPosition(5, 4);
            Console.Write("digite sua idade : ");

            try
            {
                idade = byte.Parse(Console.ReadLine());
                Console.WriteLine("a idade {0} e uma idade válida (0-255)", idade);
            }
            //caso nao seja possivel converte pra byte 
            catch (InvalidCastException)
            {
                //exibindo a mensagem personalizada 
                Console.WriteLine("erro : digite apenas numeros entre (0-255)");

            }
            //caso o valor digitado seja amior que 256 
            catch (OverflowException ovEXC)
            {
                //exibindo mensagem pre definida 
                Console.WriteLine("erro : {0} ", ovEXC.Message);
            }
            catch (Exception) { 
            //exceção generica caso o erro nao se enquadre nos exceptions anteriores 
                Console.WriteLine("erro o valor digitado e invalido pra idade ");

            }
            Console.Read();
        
        }
    
        static void CriaLinha() {
            for (byte i = 0; i < 80; i++)
                Console.Write("-");
        }
    }
}
//pra cria um programa estavel precisamos ser critico como ele se comporta quando recebe os valores e tals 
//no dia dia pra caso o usuario digite opção ou esteja digitando o oposto do que se pede como valores imcopativeis com o solicitato ou ate mesmo nao informado 
//precisamos vigiar o codigo e garantir que nao aja erro no programa quando isso acontecer 
//pra isso usamos a estrutura de tratamento TRY, CATCH E FINALY 
//--------------------------
//TRY : aqui vem as intruções que seram inspecionadas em tempo de execução ou ate mesmo em tempo real 
//aqui vc poem o primeiro possivel erro tenta converte algo em alugma coisa e manda um sinal de resposta na tela de certo ou errado
//mais tbm pode concverte o valor errado em um certo usando o CONSOLE.PARSE ele pode converte o erro em um acerto e continuar o programa  
//---------------------------
// CATCH : caso o try nao fucione o erro digitado nao esta no try o catch e um segunda opção de erro como um segundo case ou outro caso 
//pode ser abrir varios catch de acordo com cada possibilidade de erro degejada pode personalizar ele como vc quiser
//---------------------------
//FINALY : cerve pra finalizar o programa idependente de tiver erro ou nao 
// no try ou catch ou no meio de uma transação bancaria eu preciso que o programa feche se ocorre um pico de luz ou nao 
//eu uso o finaly que vai finalizar o programa como for seja o erro que for vai finalizar ele com sucesso e continuar a roda o programa seguinte 
// se for o ultimo fecha tudo apos compilar 
//--------------------------
//OverflowException : ele cerve e tem a função pra quando o numero lansado e menor ou maior que o minimo ou maximo pedido 
//no caso do byte que aceita numero positivo entre 0-255 se o numero for menor ou maior o OverflowException
//exibe uma mensagem de erro 
// exemplo CATCYH {oVERflowException ovEXC }
//exibindo a mensagem pre definida 
//console.writeline("erro {0}",ovEXC.message);   
//----------------------------
//INVALIDCASTEXCEPTION : lançado sempre que nao for possivel fazer 'cast'de valor de um tipo pra outro 
//caso vc receba um string e tenta converte pra byte e nao seja possivel o INVALIDCASTEXCEPTION e lançado 
//caso nao seja possivel converte pra byte 
//catch (InvalidCastException)   
//exibindo a mensagem personalizada
//Console.WriteLine("erro : digite apenas numeros entre (0-255)");
//--------------------------------
//EXEPTION : usamos ela quando o erro for generico e nao tenha cido previsto n otry e chatch 
//usamos eles segundo essas regras
//e importante que ele fique por ultimo na lista de exrecussoes do codigo deste jeito o programa so executara caso  o erro nao se enquadro nos erros anteriores 
//no exemplo overflow e invalid cast podemos usalo quando nao se quer tratata uma execussao expecifica 
//apenas queremos pegar o erro  que venha a acontecer em execussão do programa e tratat ele ou termina com ele 
// e por ultimo o bloco finaly deve ser executado 


  