using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ADV_27_HASHTABLE_SORTEDLIST
{
    

    public partial class Form1 : Form
    {
        // atributos 
        Hashtable hasheTable = new Hashtable();
        SortedList sortedList = new SortedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtIdade.Text == "")
                return ;
            // adiciona uma chave e valor no hashtable 
            hasheTable[txtNome.Text] = txtIdade.Text ; 

            // adiciona uma chave e valor no sortedlist 
            sortedList[txtNome.Text] = txtIdade.Text;

            // limpa os campos 
            txtNome.Text = string.Empty ; 
            txtIdade.Text = string.Empty; 

            // poe o focus no txtname 
            txtNome.Focus();

            // atualizar os listboxes 
            exibeCollections();
            } //metodo que integra os itens dos collections (hasttable , sortedlist)

        private void exibeCollections ()
        {
            // limpa os itens atuais dos listboxes 
            lstHashTable.Items.Clear();
            lstSortedList.Items.Clear();

            // loop que inteira s chaves / valores do hashtable
            foreach (DictionaryEntry htmembro in hasheTable )
            {
                lstHashTable.Items.Add("nome : "+ htmembro.Key+" idade :"+ htmembro.Value);
            }
            // loop que intera nas chaves / valores do sortedlist 
            foreach (DictionaryEntry slmembro in sortedList)
            {
                lstSortedList.Items.Add("nome : "+ slmembro.Key+ "idade : "+ slmembro.Value); 
            }
        }

        private void btnRemoveKeyHashTable_Click(object sender, EventArgs e)
        {
            // remover a chave informada dqa coleção hashtable
            hasheTable.Remove(txtChaveHashTable.Text);

            // atualizar os listboxes 
            exibeCollections();

        }
    }
}
