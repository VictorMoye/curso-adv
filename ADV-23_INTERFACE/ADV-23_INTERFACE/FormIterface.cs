using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_23_INTERFACE
{
    public partial class FormIterface : Form
    {
        public FormIterface()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo objCalculo = new Calculo();

            char op = char.Parse(cmbOperacao.Text);

            string []memoria = new string[4]; 

            // alimenta a memoria no array 
            memoria[0] = txtValor1.Text;
            memoria[1] = op.ToString();
            memoria[2] = txtValor2.Text;

            switch (op)
            {
                case '+': 
                    memoria[3] = objCalculo.Adicao(float.Parse(memoria[0]),
                    float.Parse(memoria[2])).ToString();
                    break;
                case '-':
                    memoria[3] = objCalculo.Subtracao(float.Parse(memoria[0]),
                    float.Parse(memoria[2])).ToString();
                    break;
                case'*' : 
                    memoria [3] = objCalculo.Multiplicacao(float.Parse(memoria[0]),
                    float.Parse(memoria[2])).ToString();
                    break;
                case '/': 
                    memoria [3] = objCalculo.Divisao(float.Parse(memoria[0]),
                    float.Parse(memoria[2])).ToString();
                    break;
                case '%' :
                    memoria[3] = objCalculo.Resto(float.Parse(memoria[0]),
                    float.Parse(memoria[2])).ToString();
                    break;
            }
            // adiciona a memmoria 
            lboxCalculos.Items.Add(string.Concat(memoria[0],"",memoria[1],"",memoria[2],"=",memoria[3])); 
            // limpa os valores 
            txtValor1.Text = string.Empty ;
            txtValor2.Text = string.Empty; 
            txtValor1.Focus();
        }
    }
}
