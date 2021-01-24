using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_28_DELEGATE
{
    class Pintura
    {
        // atributos 
        // constante que armazena o nome da maquina 
        public const string NOMEMAQUINA = "printura D20 "; 

        // meotodos que desliga a maquina de pintura 
        public void StopPintura() 
        {
            Console.WriteLine("maquina : {0} desligada ", NOMEMAQUINA);
        }
    }
}
