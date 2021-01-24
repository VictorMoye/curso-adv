using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADCV_32_CLASS_LIBRARY
{
    /// <summary>
    /// implementa a interface IComparable 
    /// que fornece o unico metodo chamado compareTo que recebe um unico 
    /// parametro ; objeto a ser comparado com a instancia atual 
    /// e retorna um int : 
    /// menor que 0 a intancia atual é menor que o parametro . 
    /// 0 a instancia atual e igual ao parametro 
    /// maior que 1 a instancia atual e maior que o parametro 
    /// </summary>
    /// <typeparam name = "TlTEM"> Tltem representas o tipo do generico que identificado na compilação </typeparam>
    
    public class Arvore <Tltem> where Tltem : IComparable<Tltem>
    {
        // propriedade 
        public Tltem NodeData { get; set; }
        public Arvore<Tltem> ArvoreDaDireita { get; set; }
        public Arvore<Tltem> ArvoreDaEsquerda { get; set; }
        ///<summary>
        ///construtor que recebe o primeiro item do tipo informado 
        ///alimenta o nomedata e inicia as propriedades com o valor null
        ///</summary>
        ///<param name = "node value"></param>

        public Arvore(Tltem nodeValue)
        {
            this.NodeData = nodeValue;
            this.ArvoreDaEsquerda = null;
            this.ArvoreDaDireita = null; 
        }
        ///<summary>
        ///metodo recursivo que insere a nova arvore 
        ///</summary>
        ///<param name ="novArvore"></param>

        public void Insert(Tltem novArvore )
        {
            // arvore corrente 
            Tltem arvoreCorrente = this.NodeData;

            // se for maior que a nova arvore 
            if (arvoreCorrente.CompareTo(novArvore) > 0)
            {
                // insere o novo item na Sub-Arvore da esquerda 
                if (this.ArvoreDaEsquerda == null)
                {
                    // cria uma nova arvore 
                    this.ArvoreDaEsquerda = new Arvore<Tltem>(novArvore);
                }
                else 
                {
                    //insere item na arvore 
                    this.ArvoreDaEsquerda.Insert(novArvore); 
                }
            }
            else
            {
                // insere um novo item na arvore da direita 
                if (this.ArvoreDaDireita == null)
                {
                    // cria uma nova arvore 
                    this.ArvoreDaDireita = new Arvore<Tltem>(novArvore);
                }
                else 
                {
                    // insere o item na arvore 
                    this.ArvoreDaDireita = new Arvore<Tltem>(novArvore);
                }

            }
        }
        public void PeDaArvore()
        {
            if (this.ArvoreDaEsquerda != null)
            {
                this.ArvoreDaEsquerda.PeDaArvore();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.ArvoreDaDireita != null)
            {
                this.ArvoreDaDireita.PeDaArvore();
            }
        }
    }
}
