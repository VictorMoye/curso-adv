using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ADV_33_CONHECENDO_WPF
{
    class Instrutor : IDataErrorInfo
    {
        // atributos 
        private string nome; 
        private Boolean formacaoSuperior ;
        private string curso ; 
        private string experiencia ; 
        private string error; 

        // contrutor 
        public Instrutor () {}

        // propriedades 
        public string Nome 
        {
            get {return this.nome;}
            set {this.nome = value;}
        }
        public Boolean FormacaoSuperior
        {
            get { return this.formacaoSuperior; }
            set { this.formacaoSuperior = value; }
        }
        public string Curso
        {
            get { return this.curso; }
            set { this.curso = value; }
        }
        public string Experiencia
        {
            get { return this.experiencia; }
            set { this.experiencia = value; }
        }
        // propriedade da interface IdataErrorInfo
        public string Error
        {
            get { return this.error; }
            
        }
        public string this[string columnName]
        {
            get {
                this.error = string.Empty; 

                // se a propriedade acessa form nome 
                if (columnName == "Nome")
                {
                    // verifica o valor do atributo nome 
                    if (string.IsNullOrEmpty(this.nome))
                    {
                        //define a mensagem 
                        this.error = "informe o nome do instrutor"; 
                    }
                }
                return this.error;
            }
        }

    }
}
