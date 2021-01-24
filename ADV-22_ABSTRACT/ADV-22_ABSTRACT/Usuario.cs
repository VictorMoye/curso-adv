using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // namespace criado  

namespace ADV_22_ABSTRACT // crie a HERANÇA 
{   
    abstract class Usuario
    {  
        // atributos protegidos 
        protected string matricula;
        protected string nome;
        protected string login;
        protected string senha; 

        // propriedades 
        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value ;}
        }
        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }
        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }
        // metodo abstrato que sera implementado nas classes derivadas 
        abstract public void Inclui(Usuario obj, DataGridView dg);

        abstract public void RemoveLinha(int idx, DataGridView dg);
     }
}

