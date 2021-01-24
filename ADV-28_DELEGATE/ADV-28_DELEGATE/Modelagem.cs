using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_28_DELEGATE
{
    class Modelagem
    {
        // atributos 

        // constante que armazena o nome da maquina 
        public const string NOMEMAQUINA = "Modelagem 3000";

        // metodo que desliga a maquina de modelagem 
        public void StopModelagem() 
        {
            Console.WriteLine("Maquina {0} desligada ", NOMEMAQUINA); 
        }
    }
}
