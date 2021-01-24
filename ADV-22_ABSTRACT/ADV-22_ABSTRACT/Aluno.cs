using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // adicione esse namespace 

namespace ADV_22_ABSTRACT
{
    class Aluno : Usuario 
    {
        // escopo da classe 
        // atributos 
        private string turma; 

        // constructor 
        public  Aluno(){}
        
        // propriedades 
        public string Turma
        {
            get { return this.turma; }
            set { this.turma = value; }
        }
        ///<summary> sumario pra aparecer em detalhes as funçoes dos metodos 
        /// metodo que incluira a linha no grid recebido como parametro 
        /// </summary>
        ///<param name="dg">Objeto preenchido com os itens que serão adicionados no grid </param>
        ///<param name="obj">Grid que recebera os itens </param>
        ///<returns>true para a inclusão bem sucedita / false para o erro na inclusão </returns>
        
        // implementação do meotodo abstrato incluir 
        public override void Inclui(Usuario obj, DataGridView dg)
        {
            // nova linha no grid 
            int idx = dg.Rows.Add();
            // campos da classe base usuario 
            dg.Rows[idx].Cells[0].Value = obj.Matricula;
            dg.Rows[idx].Cells[1].Value = obj.Nome;
            dg.Rows[idx].Cells[2].Value = obj.Login;
            dg.Rows[idx].Cells[3].Value = obj.Senha;

            // adiciona o campo especifico da classe aluno 
            dg.Rows[idx].Cells[4].Value = this.turma; 
        }
        ///<summary>
        /// metodo que remove a linha do grid 
        /// </summary>
        /// <param name="idx">informa qual a linha a ser resolvida pelo index </param>
        ///<param name="dg">Grid no que etrsa a sua linha removida </param>
        ///<returns>true para remoção bem sucedida / false para erro na remoção </returns>
        
        //implementação do metodo abstrato RemoveLinha 
        public override void RemoveLinha(int idx, DataGridView dg)
        {
            // remover a linha do grid 
            dg.Rows.Remove(dg.Rows[idx]);
        }
    }
}
