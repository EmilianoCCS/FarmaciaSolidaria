using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Data.Entity.Migrations;
using System.Text.RegularExpressions;
using MahApps.Metro.Controls.Dialogs;

namespace ProjFarmacia
{
    /// <summary>
    /// Interaction logic for Saida.xaml
    /// </summary>
    public partial class Saida
    {
        Conexaox conexao = new Conexaox();
        Doadores doad = new Doadores();
        Instituicoes inst = new Instituicoes();
        Remedios remed = new Remedios();
         Estoque estoque = new Estoque();
        
        

        public List<Doadores> Doadores;
        public List<Instituicoes> Instituicoes;
        public List<Remedios> Remedios;
        public List<Estoque> Estoque;
        public Saida()
        {
            InitializeComponent();

            Remedios = conexao.Remedios.ToList();
            Instituicoes = conexao.Instituicoes.ToList();
            //Estoque = conexao.Estoque.ToList();
           // Doadores = conexao.Doadores.ToList();
            ComboBoxInstituicao.ItemsSource = Instituicoes;
            ComboBoxRemedio.ItemsSource = Remedios;
            //ComboBoxDoador.ItemsSource = Doadores;
            PopularComboBox();
        }

        
        private void miRemedio_Click(object sender, RoutedEventArgs e)
        {
            RemedioDoado WinRemedio = new RemedioDoado();
            WinRemedio.Show();
            Close();
        }

        private void miInstituicao_Click(object sender, RoutedEventArgs e)
        {
            Instituicao WinInstituicao = new Instituicao();
            WinInstituicao.Show();
            Close();

        }

        private void miDoador_Click(object sender, RoutedEventArgs e)
        {
            Doador WinDoacao = new Doador();
            WinDoacao.Show();
            Close();
        }

        private void miConsultar_Click(object sender, RoutedEventArgs e)
        {
            ConsultaEstoque WinConsultar = new ConsultaEstoque();
            WinConsultar.Show();
            Close();
        }

        private void PopularComboBox()
        {

            
            ComboBoxInstituicao.ItemsSource = Instituicoes;
            ComboBoxInstituicao.DisplayMemberPath = "Nome";

            
            ComboBoxRemedio.ItemsSource = Remedios;
            ComboBoxRemedio.DisplayMemberPath = "Nome";

            //ComboBoxDoador.ItemsSource = Doadores;
            //ComboBoxDoador.DisplayMemberPath = "Nome";

        }
        private void LimparTXTs()
        {
            ComboBoxRemedio.Text = "";
            ComboBoxInstituicao.Text = "";
            txtQtd.Text = "";
            dateSaida.Text = "";
            //ComboBoxDoador.Text = "";
            
        }


        private async void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Estoque estoque = new Estoque();
                int resultadoTXT = Convert.ToInt32(txtQtd.Text);
                if (resultadoTXT > remed.Quantidade)
                {
                    MessageBox.Show("A quantidade esta além do que possui no estoque", "Quantidade doada", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    remed.Quantidade = remed.Quantidade - Convert.ToInt32(txtQtd.Text);
                    conexao.Entry(remed).State = System.Data.Entity.EntityState.Modified;
                    conexao.SaveChanges();


                    estoque.Id = conexao.Estoque.Count() + 1;
                    estoque.Doadores = remed.Doadores;
                    //estoque.IdDoador = remed.Doadores.Id;
                    estoque.IdInstituicao = inst.Id;
                    estoque.IdRemedio = remed.Id;
                    estoque.DataSaida = Convert.ToDateTime(dateSaida.Text);
                    conexao.Estoque.Add(estoque);
                    conexao.SaveChanges();
                    MessageBox.Show("Estoque atualizado com sucesso!", "Ação Concluída", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimparTXTs();
                }
            }
            catch
            {
                MessageBox.Show("Todos os campos devem estar preenchidos", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void ComboBoxInstituicao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            inst = (Instituicoes)ComboBoxInstituicao.SelectedItem;
        }

        private void ComboBoxRemedio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            remed = (Remedios)ComboBoxRemedio.SelectedItem;
        }


        private void txtQtd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void dateSaida_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Saida WinSaida = new Saida();
            WinSaida.Show();
            Close();
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparTXTs();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Logoff = new MainWindow();
            Logoff.Show();
            Close();
        }
    }
}
