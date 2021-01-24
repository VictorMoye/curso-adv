using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ADV_21_HERANCA
{
    public class Carro
    {
        
            protected string placa;
            protected string marca;
            protected string modelo;
            protected int ano = 0;
            // propriedades 
            public string Placa
            {
                get { return this.placa; }
                set { this.placa = value; }
            }
            public string Marca
            {
                get { return this.marca; }
                set { this.marca = value; }
            }
            public string Modelo
            {
                get { return this.modelo; }
                set { this.modelo = value; }
            }
            public int Ano
            {
                get { return this.ano; }
                set { this.ano = value; }
            }
            // metotodo que adiciona o resgistro no grid 
            public virtual void Add(DataSet ds)
            { 
                // cria uma nova linha do tipo da tabela carro criada no dataset 
                DataRow newRow = ds.Tables["carros"].NewRow();
                // alimenta a coluna da linha criada 
                newRow["placa"] = this.placa;
                newRow["marca"] = this.marca;
                newRow["modelo"] = this.modelo;
                newRow["ano"] = this.ano;

                //adicina linha na tabela carro 
                ds.Tables["carros"].Rows.Add(newRow);
            }
            

        }



}