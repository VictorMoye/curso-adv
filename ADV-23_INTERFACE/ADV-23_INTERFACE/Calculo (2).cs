using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_23_INTERFACE
{   // define que a classe calculo implementa a interface IoperacaoAritimetica 

    class Calculo : IoperacaoAritimetica
    {
         public float Subtracao(float valor1, float valor2)
        {
            return valor1 - valor2;
        }
         public float Adicao(float valor1, float valor2)
        {
            return valor1 + valor2;
        }
         public float Divisao(float valor1, float valor2)
        {
            if (valor2 == 0)
            {
                throw new Exception("nao e possivel  dividir um valor por 0 ");
                
            }
            return valor1 / valor2;
            
        }
         public float Multiplicacao(float valor1, float valor2)
        {
            return valor1 * valor2;
        }
         public float Resto(float valor1, float valor2)
        {
            if (valor2 == 0)
        {
            throw new Exception("nao e possivel dividir um valor por 0");
            
        }
            return valor1 % valor2;
            
        }
    }
}
