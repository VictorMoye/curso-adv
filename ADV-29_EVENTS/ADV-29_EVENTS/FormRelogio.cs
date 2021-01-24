using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_29_EVENTS
{
    public partial class FormRelogio : Form
    {
        public FormRelogio()
        {
            InitializeComponent();
        }

        private void FormRelogio_Load(object sender, EventArgs e)
        {
            // crie uma nova instancia da classe 
            this.relogio = new Relogio(lblRelogio);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // comece a roda o relogio 
            this.relogio.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // para de rodar o relogio mas o tempo continua passando 
            // pois o eventhandler execurta a cada um segundo 
            // com isso ao clicar no botão start o relogio é atualizado 
            // com o tempo atual 
            this.relogio.Stop();
        }
    }
}
