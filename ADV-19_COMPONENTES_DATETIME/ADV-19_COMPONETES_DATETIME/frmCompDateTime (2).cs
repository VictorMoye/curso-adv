using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_19_COMPONENTES_DATETIME
{
    public partial class frmCompDateTime : Form
    {
        public frmCompDateTime()
        {
            InitializeComponent();
        }
        // variavel do tipo DataTime 
        DateTime relogio;
        private void lbl_MC_DataSelecionada_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // metodo que exibir a data selecionada no monthcalendar 
        private void DecomporDataSelecionadaMc(SelectionRange sr)
        { 
           //data selecionada 
            lbl_MC_DataSelecionada.Text = sr.End.ToShortDateString();

            // dia selecionado 
            lblDiaMC.Text = sr.End.Day.ToString();

            // mes selecionado
            lblMesMC.Text = sr.End.Month.ToString();

            //ano selecionado 
            lblAnoMC.Text = sr.End.Year.ToString();
        } // metodo que exibe a data selecionada no datetipepicker
        private void DecomporDataSelecionadaDTP(DateTime dt)
        { 
          //data selecionada 
            lbl_DTP_dataSelecionada.Text = dt.ToShortDateString();
            
          //dia selecionado 
            lblDiaTP.Text = dt.Day.ToString();

           //mes selecionado 
            lblMesTP.Text = dt.Month.ToString();

            //ano selecionado 
            lblAnoTP.Text = dt.Year.ToString();


      }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             //mcData_DateChanged();
        }
        private void mcData_DateChanged(object sender, DateRangeEventArgs e)
        { 
        //executa o metodo de DecomporDataSelecionadaMC, passando como parametro 
            //mcData.selecionRenge que leva consigo todas as seleções feitas 
            DecomporDataSelecionadaMc(mcData.SelectionRange); 
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            DecomporDataSelecionadaDTP(dtpData.Value);
        }

        private void frmCompDateTime_Load(object sender, EventArgs e)
        {
            // executa os metodos que alimentam as labels 
            DecomporDataSelecionadaMc(mcData.SelectionRange);
            DecomporDataSelecionadaDTP(dtpData.Value);
        }

        private void timerRelogioDigital_Tick(object sender, EventArgs e)
        {
            // pega o tempo agora e exibe a hora no formato hh:mm:ss 
            relogio = DateTime.Now;
            lblRelogio.Text = relogio.ToLongTimeString();
        }
    }
}
