using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_28_DELEGATE
{
    class sOLDA
    {
        // ATRIBUTOS 
        // CONSTANTE QUE ARMAZENA O NOME DA MAQUINA
        public const string NOMEMAQUINA = "Solda D3"; 

        // meotodo que desliga a maquina de solda 
        public void StopSolda() 
        {
            Console.WriteLine("maquina : {0} desligada ",NOMEMAQUINA);
        }
    }
}
