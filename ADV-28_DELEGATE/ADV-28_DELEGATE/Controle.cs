using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV_28_DELEGATE
{
    class Controle
    {
        // atributos 

        // cria uma instancia do delegate 
        private stopMaquinasDelegate stopMaquina;

        // construtor 
        public Controle() { }

        // propriedade que disponibiliza o acesso ao delegate
        public stopMaquinasDelegate StopMaquina
        {
            get { return this.stopMaquina; }
            set { this.stopMaquina = value; }
        }

        // adiciona a maquina ao delegate 
        public void Addiciona(stopMaquinasDelegate stopMetodo)
        {
            // ao adiciona o metodo ao delegate nao passos os parametros 
            //neste momento o metodo nao e executado e apenas referenciado 
            this.stopMaquina += stopMetodo;
        }
        // remove a amaquina do delegate
        public void Remove(stopMaquinasDelegate stopMetodo)
        {
            this.stopMaquina -= stopMetodo;
        }
        // desliga a amaquina que estao no delegate 
        public void ShutDown()
        {
            // caso os metodos tenham parametros é 0 aqui que passamos 
            this.stopMaquina(); 
        }
    } 

}
/* ao ser executadoi o programa foram criados os objetos das classes 
 * e cadfa classe adicionou o seu metodo de desligamento ao delegate e os nome sforam numerados de 1 a 3 e exibidos 
 em seguida a mensagem  e eexibida informando que as maquinas foram adicionadas ao delegate 
 */ 