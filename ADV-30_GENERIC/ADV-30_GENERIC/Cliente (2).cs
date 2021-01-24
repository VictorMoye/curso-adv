using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_30_GENERIC
{
    class Cliente
    {
        ///<sumary>
        ///atributo oculto 
        ///ao cria a propriedade para apenas levar e trazer dados para os 
        ///atributos ,  oc# oferece a sintaxe mostrada a baixo 
        ///o compilador criara atributos privados ocultos que aguardarão os dados informados 
        ///pelas propriedades 
        ///</sumary>

        public int Codigo { get; set; }
        public string sobreNome { get; set; }
        public string Nome { get; set;  }
    }
}
