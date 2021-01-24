//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_23_INTERFACE
{
    interface IoperacaoAritimetica
    {
        // metodos que serão implementados pelas classes que a implementarão 

        // Adição 
        float Adicao(float valor1, float valor2);

        // subtração 
        float Subtracao(float valor1, float valor2);

        // multiplicação 
        float Multiplicacao(float valor1, float valor2);

        //Divisão 
        float Divisao(float valor1, float valor2);

        // resto da divisão 
        float Resto(float valor1, float valor2);
    }
}

   