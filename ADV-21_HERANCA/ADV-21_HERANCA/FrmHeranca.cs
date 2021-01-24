using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_21_HERANCA
{
    public partial class FrmHeranca : Form
    {
        public FrmHeranca()
        {
            InitializeComponent();
        }

        private void FrmHeranca_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {   
            // adiciona um carro ao grid 
            if (rdbCarro.Checked)
            {
                Carro carro = new Carro();
                // seta os dados do projeto carro 
                carro.Placa = mskPlaca.Text;
                carro.Modelo = txtModelo.Text;
                carro.Marca = txtMarca.Text;
                carro.Ano = int.Parse(mskAno.Text);

                // dispara o metodo que adiciona a linha no grid 
                carro.Add(dsHeranca);
            }
            else // adiciona um caminhao ao grid 
            {
                Caminhao caminhao = new Caminhao();
                // observe que o objeto caminhao herdou os atributos e propriedades da classe carro 
                caminhao.Placa = mskPlaca.Text;
                caminhao.Marca = txtMarca.Text;
                caminhao.Modelo = txtModelo.Text;
                caminhao.Ano = int.Parse(mskAno.Text);
                caminhao.Eixos = int.Parse(nupdEixos.Value.ToString());
                
                // executa o metodo que adiciona a linha no grid 
                caminhao.Add(dsHeranca);
            }

            // limpa os dados 
            LimpaGrupoCarro();
        }
        // limpa os grupos no campo carros 
        private void LimpaGrupoCarro()
        {
            mskPlaca.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            mskAno.Text = string.Empty;


        }

        // metodo que defineira o enabled como true of false do grupo eixos 
        private void grpTipoDeCadastro(object sender, EventArgs e)
        {
            if (rdbCaminhao.Checked)
            {
                groupBox3.Enabled = true;
            }
            else 
            {
                groupBox3.Enabled = false; 
            }
        }

        
    }
}
