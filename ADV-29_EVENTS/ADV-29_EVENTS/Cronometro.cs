using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_29_EVENTS
{
    class Cronometro
    {
        // tic tac 
        private Timer ticTac = new Timer();

        // delegate Tick que sera executado a cada um assunto pelo evento 
        public delegate void Tick(int hh, int mm, int ss); 

        // evento associado ao delegate Tiker 
        public event Tick tickEvento; 
        
        // construtor
        public Cronometro() 
        {
            // escreve o metodo que sera executado a cada um segundo 
            // para manter o tempo atualizado 
            this.ticTac.Tick += new EventHandler(this.onTemporizadorEvent);

            // cada um segundo 
            this.ticTac.Interval = 1000;
 
            // começar a roda 
            this.ticTac.Start();
        }
      

        private void onTemporizadorEvent(object source, EventArgs arg)
        {
            DateTime agora = DateTime.Now;
            int hh = agora.Hour;
            int mm = agora.Minute;
            int ss = agora.Second; 

            // chamar o notificador que dispara o evento 
            this.notifica(hh, mm, ss); 
        }
        ///<sumary>
        ///recebe hh,mm,ss e dispara o evento escrito no delegate 
        /// passando os parametros necessarios 
        ///</sumary>
        ///<param name = "hh"></param>
        ///<param name = "mm"></param>
        ///<param name = "ss"></param>

        public void notifica(int hh, int mm, int ss) 
        {
            // se houver um metodo no evento 
            if (this.tickEvento != null)
            {
                // dispara o evento 
                this.tickEvento(hh, mm, ss);
            }
        }

    }
}
