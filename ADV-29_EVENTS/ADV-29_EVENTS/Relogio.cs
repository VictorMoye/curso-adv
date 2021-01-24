using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADV_29_EVENTS
{
    class Relogio
    {
        // instancia do cronometro 
        private Cronometro pulsando = new Cronometro();
        private Label display;

        ///<sumary>
        ///construtor que recebe como parametro a label onde sera escrito o horaio 
        ///</sumary>
        ///<param name = "displayBox">Label</param>

        public Relogio(Label displayBox)
        {
            this.display = displayBox; 
        }
        ///<sumary>
        ///escreve o metodo atualizada tempo ao evento 
        ///</sumary>

        public void Start() 
        {
            this.pulsando.tickEvento += this.atualizaTempo; 
        }
        ///<sumary>
        ///remove o metodo atualizartempo do evento 
        /// parando assim de atualizar o a propriedade text da label 
        ///</sumary>

        public void Stop() 
        {
            this.pulsando.tickEvento -= this.atualizaTempo; 
        }
        ///<sumary>
        ///recebe a nova hora , minuto e segundo 
        /// e escreve o valor formado hh:mm:ss 
        /// no label passado como parametro no construtor  
        ///</sumary>
        ///<param name = "hh">hora</param>
        ///<param name = "mm">minuto</param>
        ///<param name = "ss">segundo</param>

        private void atualizaTempo(int hh, int mm, int ss) 
        {
            this.display.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hh, mm, ss); 
        }   
    }
}
