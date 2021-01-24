using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ADV_26_QUEUE_STACK
{
    public partial class FormQueueStack : Form
    {

        // Cria os objetos dos collecions 
        private Queue queue = new Queue ();
        private Stack stack = new Stack();

        public FormQueueStack()
        {
            
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "")
            {
                // adiciona o item a fila 
                queue.Enqueue(txtTitulo.Text);

                // adiciona o item a pilha 
                stack.Push(txtTitulo.Text);

                //envoca os metodo que exibe os dados 
                exibeDadosDosCollections();

                //limpa a caixa de texto titulo e seta o focus para uma nova digitação 
                txtTitulo.Text = string.Empty;
                txtTitulo.Focus();
            }
          }
        private void exibeDadosDosCollections()
        {
            // limpa os dados do list box para nao duplicar os itens 
            lstQueue.Items.Clear();
            lstStack.Items.Clear();
            
            // itera na coleção queue adicionado cada item encontrado no listbox 
            foreach (string item in stack)
            {
                lstQueue.Items.Add(item); 
            }
            // itera na coleção do stack adicionadocada item encontrad ono list box 
            foreach (string item in stack)
            {
                lstStack.Items.Add(item);
            }

               
        }

        private void btnRemoveItemQueue_Click(object sender, EventArgs e)
        {
            // se a quantidade itensd na queue for maior que 0 
            // remova o priemiro item da lfila 
            if (queue.Count > 0)
            {
                // ometodo dequeue remover o primeiro item da fila e retorna o mesmo 
                string itemRemovido = (string)queue.Dequeue(); // casting do tipo object para a string
                MessageBox.Show("item : " + itemRemovido + "REMOVIDO ", " REMOVE ITEM DA FILA ");

                // ATUALIZAR A LIST BOX 
                exibeDadosDosCollections();
            }
        }

        private void btnRemveItemStack_Click(object sender, EventArgs e)
        {
            // VERIFICA SE EXISTE ITENS NA PILHA 
            if (stack.Count > 0)
            {
                // o metodo pop do stack remove o primeiro item da pilha e retorna o mesmo 
                string itemRemovido = (string)stack.Pop(); // casting do tipo object para a string 
                MessageBox.Show("item : " + itemRemovido + "rmeovido da pilha ", " remove  pilha ");

                //atualizar o List box
                exibeDadosDosCollections();
            }

        }
    }
}
