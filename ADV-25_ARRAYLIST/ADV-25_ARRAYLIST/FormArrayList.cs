using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; 

namespace ADV_25_ARRAYLIST
{
    public partial class FormArrayList : Form
    {
        // atritbuto do tipo array list 
        private ArrayList cursos = new ArrayList();

        public FormArrayList()
        {

            InitializeComponent();
        }
        private void ExibeArrayList()
        {
            // limpa a data source 
            lstbCursos.DataSource = null; 

            // adiciona um novo arraylist ao datasource 
            lstbCursos.DataSource = cursos; 

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // CRIE UMA VARIAVEL DO TIPO CHAR E ATRIBUIR O CARACTER PRECIONADO 
            char C = e.KeyChar; 

            // se o valor char for 13 entao o usuario precionou a tecla enter 
            if (C == 13 && txtDescricao.Text !="")
            {
                // adiciona o item arrayList 
                cursos.Add(txtDescricao.Text);

                // limpando a caixa de texto para uma nova digitação 
                txtDescricao.Text = string.Empty; 
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            // executar o metodo que exibir o array list na listbox 
            ExibeArrayList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // remover o item pelo index indicado
            cursos.RemoveAt(lstbCursos.SelectedIndex); 
            // atualizar o list box 
            ExibeArrayList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // ordena de [a-z]
            cursos.Sort();

            //atualizar o ListBox
            ExibeArrayList();
        }
       
    }
    
}
 