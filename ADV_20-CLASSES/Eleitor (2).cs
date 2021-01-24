using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_20_CLASSES
{
    class Eleitor
    { 
        // atributos 
         private int id;
         private string nome;
         private byte idade;
         private string tipo;
         private int nTitulo; 

        // propriedades 
         public int Ntitulo
         {
             get { return this.nTitulo; }
             set { this.nTitulo = value; }
         }
         public string Nome
         {
             get { return this.nome; }
             set { this.nome = value; }
         }
         public byte Idade
         {
             get { return this.idade; }
             set { this.idade = value; }
         }
        /*
         * obs : o atributo tipo é modificado pelo metodo TipoEleitor,
         * * não pela propriedade tipo, portanto nao ira permiti que a propriedade modifique-o 
         * para satisfazer esse requisito vamos ultilizar somente o metodo GET 
         * metodo GET 
         */

         public string Tipo
         {
             get { return this.tipo;  } 
         }


        // construtor padrao 
         public Eleitor()
         { 
          // comandos de inicialização 

         }
        // custumizando 1 
         public Eleitor(int nTitulo)
         {
             this.nTitulo = nTitulo; 
         }
        // custumiando 2 
         public Eleitor(int nTitulo, string nome, byte idade)
         {
             this.nTitulo = nTitulo;
             this.nome = nome;
             this.idade = idade; 
         }
        
        
        //metodos 
        //tipo eleitor 
        public void TipoEleitor()
        { 
          // verifica o tipo do eletor 
            if ((this.idade >= 16 && this.idade < 18) || idade >= 65)
            {
                this.tipo = " eleitor facultativo";
            }
            else if (this.idade > 18)
            {
                this.tipo = "eleitor obrigatorio"; 
            }
            else
            {
            this.tipo = "nao eleitor" ;
            }
             
            
 
        }
    }
}
