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

namespace ProjFarmacia
{
    /// <summary>
    /// Interaction logic for RemedioDoado.xaml
    /// </summary>
    public partial class RemedioDoado
    {
        Doadores doad = new Doadores();
        Remedios remed = new Remedios();
        Conexaox conexao = new Conexaox();
        Estoque estoque = new Estoque();
        //List<Remedios> ListaDoador;
        public List<Doadores> Doadores;
        public List<Estoque> ListEstoque; 
        

        public RemedioDoado()
        {
            InitializeComponent();
            atualizarDataGrid();
            Doadores = conexao.Doadores.ToList();
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
        private void miSaida_Click(object sender, RoutedEventArgs e)
        {
            Saida WinSaida = new Saida();
            WinSaida.Show();
            Close();
        }


        private void LimparTXTs()
        {
            txtNomeRemedio.Text = "";
            txtPrincipioAtivo.Text = "";
            txtQuantidade.Text = "";
            DateEntrada.Text = "";
            DateVencimento.Text = "";
            ComboBoDoador.Text = "";
        }

        private void pegarDadosDoRemedio()
        {
                remed.Nome = txtNomeRemedio.Text;
                remed.Validade = Convert.ToDateTime(DateVencimento.Text);
                remed.PrincipioAtivo = txtPrincipioAtivo.Text;
                remed.Entrada = Convert.ToDateTime(DateEntrada.Text);
                remed.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                remed.FK_Doadores_Id = doad.Id;
            

        }
        private void atualizarDataGrid()
        {
            try
            {
                Conexaox conexao = new Conexaox();
                List<Remedios> ListaRemedio = conexao.Remedios.ToList();
                dgRemedio.ItemsSource = null;
                dgRemedio.ItemsSource = ListaRemedio;
                dgRemedio.DisplayMemberPath = "Nome";
            }
            catch
            {
                MessageBox.Show("É obrigatório que o doador seja pesquisado antes de atualizar", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PopularComboBox()
        {
            

            ComboBoDoador.ItemsSource = null;
            ComboBoDoador.ItemsSource = Doadores;
            ComboBoDoador.DisplayMemberPath = "Nome";

        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pegarDadosDoRemedio();
                conexao.Remedios.Add(remed);
                conexao.SaveChanges();
                MessageBox.Show("Remédio Cadastrado com Sucesso!", "Sucesso.", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparTXTs();
                atualizarDataGrid();
            }
            catch
            {
                MessageBox.Show("Todos os campos devem estar preenchidos", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void ComboBoDoador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            doad = (Doadores)ComboBoDoador.SelectedItem;
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pegarDadosDoRemedio();
                conexao.Remedios.AddOrUpdate(remed);
                conexao.SaveChanges();
                MessageBox.Show("Remédio Atualizado com Sucesso!", "Sucesso.", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparTXTs();
                atualizarDataGrid();
            }
            catch
            {
                MessageBox.Show("É obrigatório que o remédio seja pesquisado antes de atualizar e que todos os campos estejam preenchidos.", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int Id = Convert.ToInt32(txtPesquisar.Text);
                remed = conexao.Remedios.Find(Id);
                txtNomeRemedio.Text = remed.Nome;
                txtPrincipioAtivo.Text = remed.PrincipioAtivo;
                txtQuantidade.Text = Convert.ToString(remed.Quantidade);
                DateVencimento.Text = Convert.ToString(remed.Validade);
                DateEntrada.Text = Convert.ToString(remed.Entrada);
                ComboBoDoador.Text = remed.Doadores.Nome;
                txtPesquisar.Text = "Pesquise pelo ID";
            }
            catch
            {
                MessageBox.Show("ID inválido", "Campo Vazio", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
           
                MessageBoxResult Resultado = MessageBox.Show("Tem certeza que deseja excluir este cadastro?", "Excluir", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (Resultado == MessageBoxResult.Yes)
                {
                    pegarDadosDoRemedio();
                    conexao.Remedios.Attach(remed);
                    conexao.Remedios.Remove(remed);
                    conexao.SaveChanges();
                    LimparTXTs();
                    atualizarDataGrid();
                }
            
            
            
                //MessageBox.Show("É obrigatório que o doador seja pesquisado antes de excluir", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparTXTs();
        }

        private void txtQuantidade_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void DateEntrada_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void DateVencimento_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void txtPesquisar_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void txtPesquisar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Logoff = new MainWindow();
            Logoff.Show();
            Close();
        }

        
    }
}

