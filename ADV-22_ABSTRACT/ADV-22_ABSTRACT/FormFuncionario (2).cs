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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // cria um metodo da classse aluno 
            Aluno objAluno = new Aluno();

            // alimentando os dados dos objetos 
            objAluno.Matricula = txtMatricula.Text;
            objAluno.Nome =  txtNome.Text;
            objAluno.Login = txtLogin.Text;
            objAluno.Senha = txtSenha.Text;
            objAluno.Turma = cmbturmas.Text;
            /*
             *adiciona os dados na linha do grid 
             *observe que ao abrir o parentese sera exibido uma caixa 
             *contendo informações da invocação do metodo 
             */ 
            
             // limpando ..as caixas de texto 
               limpaCampos ();
        }
        private void limpaCampos()
        { 
            // faz um loop em todos os controles do formulario 
            foreach (object campo in this.Controls)
            { 
                // verifica se o campo é um textBox 
                if (campo is TextBox)
                {
                    TextBox txt = (TextBox)campo;
                    txt.Text = string.Empty;
                }
            }
            // coloca o curso dentro da caixa de texto matricula para a nopva digitação
            txtMatricula.Focus();
        }

        private void cmbturmas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntFuncionario_Click(object sender, EventArgs e)
        {
            // objeto do form form funcionari o
            FormFuncionario frFuncionario = new FormFuncionario();
            // exibe o form funcionario 
            frFuncionario.Show();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int idx = dgvFuncionarios.CurrentRow != null ? dgvFuncionarios.CurrentRow.Index : -1;
            if (idx == -1)
            {
                MessageBox.Show("SELECIONE UMA LINHA PARA REMOVE-LA", "seleção vazia ");
                return; 
            }
            Funcionario objFuncionario = new Funcionario();
            // observe mais uma vez a caixa de informações do metodo 
            objFuncionario.RemoveLinha(idx, dgvFuncionarios);
        }

    
   
    }
}
