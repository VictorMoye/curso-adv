using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // auxilia de biblioteca adicionado 

namespace ADV_22_ABSTRACT
{
    class Funcionario : Usuario // Crie a herança 
    {
        // atributos 
        private string setor;
        private decimal salario;

        // propriedade 
        public string Setor
        {
            get { return this.setor; }
            set { this.setor = value; }
        }
        public decimal Sario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }
        // metodo contructor
        public Funcionario() { }
        // reescrita do metodo incluir 
        public override void Inclui(Usuario obj, DataGridView dg)
        {
            // nova linha no grid 
            int idx = dg.Rows.Add();
            // Campos da classe base usuario 
            dg.Rows[idx].Cells[0].Value = obj.Matricula;
            dg.Rows[idx].Cells[1].Value = obj.Nome;
            dg.Rows[idx].Cells[2].Value = obj.Login;
            dg.Rows[idx].Cells[3].Value = obj.Senha; 

            // adiciona os campos especificos da classe funcionario 
            dg.Rows[idx].Cells[4].Value = this.setor;
            dg.Rows[idx].Cells[5].Value = this.salario;
        }
        // reescrita do metodo remove linha 
        public override void RemoveLinha(int idx, DataGridView dg)
        {
            // Remover a linha do grid 
            dg.Rows.Remove(dg.Rows[idx]);
        }
    }
}
