using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace ADV_33_CONHECENDO_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // atributos 
        private Binding myBinding;
        private Instrutor instrutor;

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("esse seu primeiro programa usando o WPF ", " HELLO"); 
        }
        // array cursos 
        private string[] cursos = {"banco de dados", "pacote office","web designer","web develop","web master","Web standards","pacote grafico"};
        // metodo que adiciona os cursos na combox 
        private void PreencheCombo()
        {
            // limpa os itens 
            this.cmbCursos.Items.Clear();
            foreach (string curso in cursos)
            {
                // adiciona cada itens 
                this.cmbCursos.Items.Add(curso);
            }
            // exibe o primeiro iten 
            this.cmbCursos.Text = cmbCursos.Items[0].ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // preencha a combox 
            this.PreencheCombo();

            // pra pegarmos a instancia da classe usada no xaml 
            // criamos um objeto do tipo biding e atribuimos o metodos 
            // estatico getbiding (controle, propiedade) da classe BidingOperations
            // que fornece metodos estaticos que nois possibilita a repercussão so source usado 
            // que e um ainstancia da classe instrutor .
            this.myBinding = BindingOperations.GetBinding(this.TxtNome, TextBox.TextProperty);
            this.instrutor = myBinding.Source as Instrutor;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("deseja sair do programa ?","Closing",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.No)
            {
                // cancela o fechamento do formulario 
                e.Cancel = true; 
            }
        }

        private void itemClose_Click(object sender, RoutedEventArgs e)
        {
            // fecha o formulario 
            this.Close();
        }

        private void itemVersao_Click(object sender, RoutedEventArgs e)
        {
            Sobre ajuda = new Sobre();
            ajuda.Show();
        }

        private void clearTxt_Click(object sender, RoutedEventArgs e)
        {
            // limpa o textbox
            TxtNome.Text = string.Empty;
        }
        private void chkFormadoSim_Click(object sender , RoutedEventArgs e) 
        {
            // se o clickFormadoSim estiver selecionado atribui true para a propriedade caso 
            // contrario atribui false 
            instrutor.FormacaoSuperior = chkFormadoSim.IsChecked == true ? true : false; 
        }
        ///<summary> 
        /// metodo que atualiza a experiencia selecionada 
        ///</summary>

        private void ExperienciaSelecionada()
        {
            foreach(RadioButton rbd in grdItensExperiencia.Children)
            {
                if (rbd.IsChecked == true)
                {
                    this.instrutor.Experiencia = rbd.Content.ToString();
                }
            }
        }

        private void itemMenuSave_Click(object sender, RoutedEventArgs e)
        {
            // atualiza a exepriencia atualizada 
            ExperienciaSelecionada(); 
            // pega O CURSO SELECIONADO No COMBOX 
            this.instrutor.Curso = cmbCursos.Text; 

            // cria uma istancia do SaveFileDialog 
            SaveFileDialog saveDialog = new SaveFileDialog(); 

            //se a propriedade erro estive vazia 
            // exibe a mensagem e coloca o focu na caixa de texto 
            // e retorna 
            if (this.instrutor.Error != string.Empty)
            {
                MessageBox.Show(this.instrutor.Error,"Campo obrigatorio",
                MessageBoxButton.OK,MessageBoxImage.Exclamation);
                return; 
            }
            // configuração inicial 
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "arquivos txt (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.AddExtension = true;
            saveDialog.FileName = this.instrutor.Nome;
            saveDialog.InitialDirectory = @"Z:\C# 2010";
            saveDialog.OverwritePrompt = true;
            saveDialog.Title = "Seleção de instrutores";
            saveDialog.ValidateNames = true; 

            //verifica se o usuario clicou no botão save 
            if (saveDialog.ShowDialog().Value)
            {
                //streamWriter e semelhante ao console.writeline 
                // so que inves de mostra na tela escreve o arquivo em texto 

                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("Nome: {0}", this.instrutor.Nome);
                    writer.WriteLine("Formação superior : {0}", this.instrutor.FormacaoSuperior == true ? "sim" : "não");
                    writer.WriteLine("especialidade: {0}", this.instrutor.Curso);
                    writer.WriteLine("experiencia : {0}", this.instrutor.Experiencia);
                }
            }
        }

        private void itemOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // cria uma nova instancia da classe OpenFileDialog 
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "lendo arquivo TXT";
            openFile.ValidateNames = true;
            openFile.Multiselect = false;
            openFile.Filter = "Arquivos txt (*.txt)|*.txt|All files (*.*)|*.*";

            // se o osurario selecionou um arquivo e clicou no botão abrir 
            if (openFile.ShowDialog().Value)
            {
                // stream READ  e semelhante ao console.ReadLine()
                // so que ao inves de ler a linha do prompt 
                //le a linha do arquivo informado e muda o curso pra proxima linha 
                using (StreamReader reader = new StreamReader(openFile.FileName))
                {
                    // iguinora os 5 primeiros caracteres 
                    this.TxtNome.Text = reader.ReadLine().Substring(6);
                    this.chkFormadoSim.IsChecked = reader.ReadLine() == "Sim" ? true : false; 
                    this.SelecionaCurso(reader.ReadLine()); 
                    this.SelecioneExperiencia(reader.ReadLine());
                }
            }
        }
        ///<summary>
        ///metodo que seleciona o curso no combox
        ///</sumamary>
        ///<param name="desc"></param> 

        private void SelecionaCurso(string curso)
        {
            int idx = 0;
            foreach (string cso in cmbCursos.Items)
            {
                if ("Experiencia : " + cso == curso)
                {
                    cmbCursos.SelectedIndex = idx;
                }
                idx++;
            }
        }
        ///<summary>
        ///metodo que seleciona o RaddioButton do grupo experiência
        ///de acordo com o  Contexto passado 
        ///</sumamary>
        ///<param name="desc"></param> 
        private void SelecioneExperiencia(string desc)
        {
            foreach (RadioButton rbd in grdItensExperiencia.Children)
            {
                if ("Experiencia : " + rbd.Content.ToString() == desc)
                {
                    rbd.IsChecked = true;
                }
            }
        }
    }
}
