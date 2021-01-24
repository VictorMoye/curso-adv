using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_15_INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // trocando valor entre os componentes 
            lblnome.Text = txtNome.Text;
            lblEmail.Text = txtEmail.Text;
            
            // definindo sexo de acordo com  a seleção 
            if (rdbmasculino.Checked)
                lblsexo.Text = "masculino";
            else
                lblsexo.Text = "feminino"; 


            

            //pega a adata selecionada no time datetimepicker 
            lbldatadenascimento.Text = dtbdatadenascimento.Value.ToShortDateString ();

            //pega o valor do item selecionado no combo 
            lblcurso.Text = cmbcurso.Text ;     

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void btncancelar_Click(object sender, EventArgs e)
        {
            // AQUI 
            //limpando os cambos do formularios 
            //executa um loop spbre os controles do formularios 
            //a cada controle encontrado atribui o mesmo para a variavel item do tipo
            //object 
            foreach (object item in grbddadosinformados.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txtEmail.Text = "";


                }
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // todo o codigo do evento 
            //todo o codigo do evento 
            //todo o codigo do evento 
            //toda vez que o usuario clicar em botão fechar do formulario ou 
            //chamar o evento close () do formulario sera exibida uma faixa de messagem 
            //solicitar a confirmação 

            // se o usuario clicar no botão [NO] da caixa de mensagem o evento e cancelado 
            if (MessageBox.Show("Dseja sair do programa", "Saindo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            //disparando o evento que fecha o formulario 
            this.Close();

        }

        private void lbldatadenascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblsexo_Click(object sender, EventArgs e)
        {

        }

        private void lblcurso_Click(object sender, EventArgs e)
        {

        }
         
       
  
    }
}
