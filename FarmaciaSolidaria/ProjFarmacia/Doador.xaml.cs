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
    /// Interaction logic for Doador.xaml
    /// </summary>
    public partial class Doador
    {
        Doadores doad = new Doadores();
        Conexaox conexao = new Conexaox();
        List<Doadores> ListaDoador = new List<Doadores>();
        public Doador()
        {
            InitializeComponent();
            atualizarDataGrid();


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


        private void atualizarDataGrid()
        {
            Conexaox conexao = new Conexaox();
            List<Doadores> ListaDoador = conexao.Doadores.ToList();
            dgDoador.ItemsSource = ListaDoador;
        }

        public static string FormatTel(string TEL)
        {
            return Convert.ToUInt64(TEL).ToString(@"\(00\)00000\-0000");
        }

        private void pegarDadosDoDoador()
        {
            doad.Nome = txtNome.Text;
            doad.Endereco = txtEndereco.Text;
            doad.Bairro = txtBairro.Text;
            doad.Cidade = txtCidade.Text;
            doad.Estado = gbxEstados.Text;
            doad.Cpf = txtCpf.Text;
            doad.Telefone = txtTelefone.Text;
        }

        private void LimparTXTs()
        {
            txtCpf.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            gbxEstados.Text = "";

        }

        public static string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pegarDadosDoDoador();
                conexao.Doadores.Add(doad);
                conexao.SaveChanges();
                atualizarDataGrid();
                MessageBox.Show("Doador cadastrado com sucesso!", "Sucesso.", MessageBoxButton.OK, MessageBoxImage.Information);
                LimparTXTs();
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparTXTs();
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

            if (txtPesquisar.Text == "")
            {
                MessageBox.Show("É obrigatório que o item seja pesquisado antes de excluir", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }


            MessageBoxResult Resultado = MessageBox.Show("Tem certeza que deseja excluir este cadastro?", "Excluir", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (Resultado == MessageBoxResult.Yes)
            {

                {
                    pegarDadosDoDoador();
                    conexao.Doadores.Attach(doad);
                    conexao.Doadores.Remove(doad);
                    conexao.SaveChanges();
                    LimparTXTs();
                    atualizarDataGrid();
                }



            }
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int Id = Convert.ToInt32(txtPesquisar.Text);
                doad = conexao.Doadores.Find(Id);
                txtCpf.Text = doad.Cpf;
                txtNome.Text = doad.Nome;
                txtEndereco.Text = doad.Endereco;
                txtBairro.Text = doad.Bairro;
                txtCidade.Text = doad.Cidade;
                txtTelefone.Text = doad.Telefone;
                gbxEstados.Text = doad.Estado;


            }
            catch
            {
                txtPesquisar.Text = "Pesquise pelo ID";
                MessageBox.Show("ID inválido", "Campo Vazio", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pegarDadosDoDoador();

                conexao.Doadores.AddOrUpdate(doad);
                conexao.SaveChanges();

                atualizarDataGrid();

            }
            catch
            {
                MessageBox.Show("É obrigatório que o doador seja pesquisado antes de atualizar e que todos os campos estejam preenchidos.", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtCpf_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                string RecebCPF = txtCpf.Text;
                txtCpf.Text = FormatCPF(RecebCPF);
            }
            catch
            {
            }

        }

        private void txtTelefone_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                string RecebTEL = txtTelefone.Text;
                txtTelefone.Text = FormatTel(RecebTEL);
            }
            catch
            {
            }
        }
        //-------------------------------------------------------------------------------------------
        private void txtCpf_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCpf.Text = "";
        }

        private void txtTelefone_GotFocus(object sender, RoutedEventArgs e)
        {
            txtTelefone.Text = "";
        }



        private void txtPesquisar_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void txtTelefone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void txtCpf_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
    

