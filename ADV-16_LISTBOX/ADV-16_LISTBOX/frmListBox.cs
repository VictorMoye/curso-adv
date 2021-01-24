using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_16_LISTBOX
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {   //variavel do tipo string 
            string nome;
            //atribui o conteudo da propriedade Text do TextBox (txtNome)
            //para a variavel nome 
            nome = txtNome.Text; 

            //verificando o conteudo antes de adicionar 
            //atraves da propriedade length que retorna o tamanho da string 
            //contida na variavel (nome) 
            if (nome.Length ==0){
            MessageBox.Show("por favor informa um nome ","campo vazio ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //colocar o foco no TextBox(txtNome)
            txtNome.Focus();
            //finalizar o evento 
            return;
            }
            //adiciona 
            lstbNomes.Items.Add(nome); 
            //limpa a propriedade do Text do TextBox (txtNome) 
            txtNome.Text = string.Empty; 
            //coloca o curso dentro do TextBox (txtNome) para uma nova digitação 
            txtNome.Focus(); 
                       
            //verificado o conteúdo antes de adicionar
            //através da propiedade lengh que retorna o tamanho da string
            //contida na variavel nome
            if (nome.Length == 0)
            {
                MessageBox.Show("por favor informe um nome", "campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //coloca o evento
                return;
            }


            
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            // atribui o index selecionado no ListBox(LstbNomes)
            int idx = lstbNomes.SelectedIndex;
            // verifica se o valor do index selecionado e menor que 0
            // se for então exib uma mensagem informando para selecionar um item
            if (idx < 0)
            {
                MessageBox.Show("Para remover um item é necessário seleciona-lo na lista", "Seleção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //sai do evento
                return;
            }
            //se continuar
            //remover o item
            lstbNomes.Items.Remove(lstbNomes.Items[idx]);
        }

        private void btnRemoverTudo_Click(object sender, EventArgs e)
        {
            // verifica se ha itens na coleção do ListBox(lstbNomes)
            if (lstbNomes.Items.Count > 0)
            {
                // limpa a coleção
                lstbNomes.Items.Clear();
            }
            else
            {
                MessageBox.Show("Não ha itens na coleção de nomes", "vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }

