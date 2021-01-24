using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_20_CLASSES
{
    class Program
    {
        static void Main(string[] args)
        { 
            byte construtor;
            CriaCabecalho();

            Console.WriteLine("1. Construtor padrão ");
            Console.WriteLine("2. Construtor customizado 1 ");
            Console.WriteLine("3. Construtor custumizado 2 ");

            Console.SetCursorPosition(0, 7);

            construtor = byte.Parse(Console.ReadLine().ToString());
            if (construtor == 1)
                InstanciaContrutorPadrao();
            else if (construtor == 2)
                InstanciaConstrutorCustumizado1();
            else
                InstanciaCunstrutroCustumizado2();
        
           
            }
            
        // meotdo de cria um objeto com o construtor padrão 
        static void InstanciaContrutorPadrao()
        { 
            // cria um objeto da classe eleitor rotulando de objEleitor
            //ultilizando o contrutor padrão 

            Eleitor objEleitor = new Eleitor();

            // numero do titulo 
            Console.Write("Digite o numero do titulo : ");
            objEleitor.Ntitulo = int.Parse(Console.ReadLine());


            // idade do eleitor
            Console.Write("informe a idade do eleitor ");
            objEleitor.Idade = byte.Parse(Console.ReadLine());

            // nome do eleitor
            Console.Write("informe o nome do eleitor : ");
            objEleitor.Nome = Console.ReadLine();

            ExibeObjeto(objEleitor);
        }
        static void InstanciaConstrutorCustumizado1()
        {
            CriaCabecalho();
            

            int titulo;
            // numero do titulo 
            Console.Write("Digite o numero do titulo : ");
            titulo  = int.Parse(Console.ReadLine());

            Eleitor objEleitor = new Eleitor(titulo);

            // idade do eleitor
            Console.Write("informe a idade do eleitor ");
            objEleitor.Idade = byte.Parse(Console.ReadLine());

            // nome do eleitor
            Console.Write("informe o nome do eleitor : ");
            objEleitor.Nome = Console.ReadLine();

            // exibir os dados do objeto na tela 
            ExibeObjeto(objEleitor); 
        }
        
        static void InstanciaCunstrutroCustumizado2()
        { // cria cabeçalho 
            CriaCabecalho();
            int titulo;
            string nome;
            byte idade;

            Console.Write("digite o numero do eleitor ");
            titulo = int.Parse(Console.ReadLine().ToString());

            Console.Write("digite o nome do eleior ");
            nome = Console.ReadLine();

            Console.Write("informe a idade do eleitor ");
            idade = byte.Parse(Console.ReadLine().ToString());

            // cria uma instancia de classses eleitor 
            //usando o contrutor 2 
            Eleitor objEleitor = new Eleitor(titulo,nome,idade); 
            // exibir os dados do eleio=tor 
            ExibeObjeto(objEleitor);
             }
        static void CriaCabecalho()
        { // limpa o console 
            Console.Clear();
            Console.Title = "programaçãp orientada a objetos";
            CriaLinhaPontilhada();
            Console.WriteLine(" CRIANDO E ULTILIZANDO CLASSES ");
            CriaLinhaPontilhada();
        }
        // criando uma linha pontilhada
        static void CriaLinhaPontilhada()
        {
            for (byte i = 0; i < 80; i++) {
                Console.Write("-");
            } 
        } // lendo os dados dos objetos 
        static void ExibeObjeto(Eleitor objEleitor)
        {   
            Console.Clear();
            CriaLinhaPontilhada();
            //exibindo os dados dos objetos 
            Console.WriteLine("DADOS DOS ELEITORES \n");
            Console.WriteLine("numero do titulo : {0}", objEleitor.Ntitulo);
            Console.WriteLine("nome do eleitor : {0}", objEleitor.Nome);
            Console.WriteLine("idade do eleitor : {0}", objEleitor.Idade);

            //exibimos o tipo eleitor atarves do metodo TipoEleitor
            // que retorna o tipo de acordo com a faixa etaria de idade 
            objEleitor.TipoEleitor();
            Console.WriteLine("classificação : {0}", objEleitor.Tipo);
            // cria uma linha pontilhada 
            CriaLinhaPontilhada();
            Console.ReadKey();
        }
           }
         }
