using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_18_DATAGRIDVIEW
{
    public partial class frmDataGridView : Form
    {   //declaração de variaveis 
        int _codigo;
        string _descricao;
        decimal _preco ;
        byte _qtde ;
        
        //metodo que verifica se os campos estão preenchidos 
        private string CamposPreenchidos(){
        // variavel que armazenara as mensagem referentes a cada campo 
            string msgs = null; 

            //loop nos componentes que estaram dentro do groupbox (compra de produtos)
            foreach (object cmp in grpbProduto.Controls) { 
            if (cmp is TextBox){
                TextBox txt = (TextBox)cmp;
                if (txt.Text == string.Empty) msgs += "\n preencha o campo : " + txt.AccessibleName;
            }
            else if (cmp is NumericUpDown) {
                NumericUpDown nupd = (NumericUpDown)cmp;
                if (nupd.Value <= 0) msgs += "\n informe um valor mair que 0 para \n o campo :  " + nupd.AccessibleName;
                }
            }
            return msgs; 

        }
        /// <summary>
        /// / metodo que adiciona uma nova linha no grid 
         private void  AdicionaLinhaNoGrid(){
             try
             {
                 _codigo = int.Parse(txtCodigo.Text);
                 _descricao = txtDescricao.Text;
                 _preco = decimal.Parse(txtPreco.Text);
                 _qtde = byte.Parse(nupdQtde.Value.ToString());

                 // cria uma nova linha no grid e pega o seu index 
                 int idx = dgvProdutos.Rows.Add();

                 // pega a linha criada no grid 
                 DataGridViewRow row = dgvProdutos.Rows[idx];

                 // alimenta as celulas da linha 
                 row.Cells["Codigo"].Value = _codigo;
                 row.Cells["descricao"].Value = _descricao;
                 row.Cells["preco"].Value = string.Format("{0:N}", _preco);
                 row.Cells["qtde"].Value = _qtde;
                 row.Cells["SubTotal"].Value = string.Format("{0:N}", _preco * _qtde);
             }
             catch (ArgumentException anex)
             {
                 MessageBox.Show("valor nao pode ser null\n detalhe : " + anex.Message, "valor invalido");
             }
             catch (FormatException fex)
             {
                 MessageBox.Show("formato invalido \n detalhe : " + fex.Message, "valor invalido ");
             }
             catch (OverflowException ofex)
             {
                 MessageBox.Show(" Campo maior ou meno que o tamanho aceito \n detalhe : " + ofex.Message, "campo invalido"); 
             }
    }
        /// </summary>
      

        public frmDataGridView() 
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            //armazenar o retorno do metodo na variavel msg 
            string msg = CamposPreenchidos(); 
            // se  o retorno do metodo for diferente de null

            if (msg != null)
            {
                MessageBox.Show(msg, " CamposPreenchidos invalido");
            }
            else { 
            // senao adicionar a nova linha 
                AdicionaLinhaNoGrid();
                CaculaTotal();

                // limpando os campos 
                txtCodigo.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtPreco.Text = string.Empty; 

                //voltando a quantidade para 1 
                nupdQtde.Value = 1 ;

                // coloca o foco no taxbox (codigo)
                txtCodigo.Focus();
                

            }
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CaculaTotal();
            try
            { // multiplica a quantidade com o preço e armazena na variavel subtotal 
                decimal subtotal = int.Parse(dgvProdutos.Rows[e.RowIndex].Cells["qtde"].Value.ToString()) * decimal.Parse(dgvProdutos.Rows[e.RowIndex].Cells["preco"].Value.ToString());
                //exibe o subtotal formato no grid 
                dgvProdutos.Rows[e.RowIndex].Cells["SubTotal"].Value = string.Format("{0:N}", subtotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro : " + ex.Message, " erro na edição ");
            
            }
         
        }
        //...
        // metodo de calcula o total 
        private void CaculaTotal()
        {
            decimal total = 0; 
 
            // varre a linha do grid , pegando o subtotal na variavel total 
            for (int i = 0; i < dgvProdutos.Rows.Count; i++) { 
            // soma e mantem na variavel total 
                total += decimal.Parse(dgvProdutos.Rows[i].Cells["subtotal"].Value.ToString()); 
            }
            // exibir o total formatado na label (lbltotal)
            lbltotal.Text = string.Format("R$ {0:N}", total);
        }

        private void lbltotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // ao remover uma ou mais linha sera recalculado o total do pedido 
            CaculaTotal();
        }

     

       
        

      
      
    }
}

