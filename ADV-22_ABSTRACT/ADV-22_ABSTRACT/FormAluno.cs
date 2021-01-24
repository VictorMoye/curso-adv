using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_22_ABSTRACT
{
    public partial  class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // cria um metodo da classse aluno 
            Aluno objAluno = new Aluno();

            // alimentando os dados dos objetos 
            objAluno.Matricula = txtMatricula.Text;
            objAluno.Nome = txtNome.Text;
            objAluno.Login = txtLogin.Text;
            objAluno.Senha = txtSenha.Text;
            objAluno.Turma = cmbTurmas.Text;
             /*
              *adiciona os dados na linha do grid 
              *observe que ao abrir o parentese sera exibido uma caixa 
              *contendo informações da invocação do metodo 
              */
            objAluno.Inclui(objAluno, dgvAlunos);
        }
      

        private void btnRemoveItem_Click_1(object sender, EventArgs e)
        {
            int idx = dgvAlunos.CurrentRow != null ? dgvAlunos.CurrentRow.Index : -1;
            if (idx == -1)
            {
                MessageBox.Show("selecione uma linha para remove-la ", " seleção vazia ");
                return;
            }
            Aluno objAluno = new Aluno();
            // observe mais uma vez a caixa de informações do metodo 
            objAluno.RemoveLinha(idx, dgvAlunos);
        }

      
    }
}
