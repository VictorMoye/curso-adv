using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ADV_21_HERANCA
{   //classe Caminhao : herda a classe carro 
    class Caminhao : Carro 
    { 
        // atributo do caminhão 
        private int eixos; 
        
        // propriedade eixos
        public int Eixos
        {
            get { return this.eixos; }
            set { this.eixos = value; }
        }
        // definnido a nova versão do metodo add que adiciona uma nova linha no grid 
        public override void Add(DataSet ds)
        {
            // cria uma nova linha do tipo da tabela caminhao criada no dataset 
            DataRow newRow = ds.Tables["caminhoes"].NewRow();

            // alimenta as colunas da linha criada 
            newRow["placa"] = this.placa;
            newRow["marca"] = this.marca;
            newRow["modelo"] = this.modelo;
            newRow["ano"] = this.ano;
            newRow["eixos"] = this.eixos;

            // adiciona  a linha na tabela caminhao 
            ds.Tables["caminhoes"].Rows.Add(newRow);
        }

    }
}
