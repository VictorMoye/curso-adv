using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_17_CHECKEDBOX
{
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            //Se a quantidade de letra for maior ou igual a 4
            if (txtNome.Text.Length >= 4)
            {   //troca a imagem do componentes picturesbox (pbStatus)
                pbStatus.Image = Properties.Resources1.accept; 
                // Exibi o groupbox (curso de interese) 
                grpbCursos.Visible = true  ;
            }
            else {// senao 
                //troca a imagem do componentes picturesbox (pbStatus)
                pbStatus.Image = Properties.Resources1.error;
                //ocuita o groupbox (cursos de interesse)
                grpbCursos.Visible = false ;            
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //variavel que indicará se foi selecionado algu, curso 
            bool itensSelecionados = false;
            string msg ;

            //prepara a mensagem 
            msg = "cursos selecionados : \n\n ";
            //faz o loop pegando cada item no groupBox 
            // como sabenmos que so ha checkbox, é seguro criar variavel do tipo checkbox 
            foreach(CheckBox chk in grpbCursos.Controls){
            if (chk.Checked){
            // foi selecionado um curso 
                itensSelecionados = true;
                // concatena na mensagem o nome do curso selecionado 
                msg += "\t" + chk.Text + "\n" ;
            }
            }
            //se a variavel itens selecionados for true 
            // ou seja ter alguma string dentro 
            if (itensSelecionados)
            {
                //exiba a mensagem 
                MessageBox.Show(msg, txtNome.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("selecione ao menos um curso ", txtNome.Text, MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
