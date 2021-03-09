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
    /// Interaction logic for Instituicao.xaml
    /// </summary>
    public partial class Instituicao 
    {
        Instituicoes inst = new Instituicoes();
        Conexaox conexao = new Conexaox();
        List<Instituicoes> ListaInstituicao = new List<Instituicoes>();
        public Instituicao()
        {
            InitializeComponent();
            atualizarDataGrid();
            txtPesquisar.Text = "Pesquise pelo ID";
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Saida WinSaida = new Saida();
            WinSaida.Show();
            Close();
        }

        private void atualizarDataGrid()
        {
            Conexaox conexao = new Conexaox();
            List<Instituicoes> ListaInstituicao = conexao.Instituicoes.ToList();
            dgInst.ItemsSource = ListaInstituicao;
        }
        private void pegarDadosDasInstituicao()
        {
            inst.Nome = txtNome.Text;
            inst.Endereco = txtEndereco.Text;
            inst.Bairro = txtBairro.Text;
            inst.Cidade = txtCidade.Text;
            inst.UF = cbUf.Text;
            inst.CNPJ = txtCNPJ.Text;
            inst.Email = txtemail.Text;
            inst.Telefone = txtTelefone.Text;


        }

        private void LimparTXTs()
        {
            txtCNPJ.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            txtemail.Text = "";
            cbUf.Text = "";
            
        }
        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pegarDadosDasInstituicao();
                conexao.Instituicoes.Add(inst);
                conexao.SaveChanges();
                atualizarDataGrid();
                MessageBox.Show("Instituicao cadastrado com sucesso!", "Sucesso.", MessageBoxButton.OK, MessageBoxImage.Information);
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

        public static string FormatCNPJ(string CNPJ)
        { 
                return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
           
        }

        public static string FormatTel(string TEL)
        {
            return Convert.ToUInt64(TEL).ToString(@"\(00\)0000\-0000");
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtPesquisar.Text);
                inst = conexao.Instituicoes.Find(Id);

                txtCNPJ.Text = inst.CNPJ;
                txtNome.Text = inst.Nome;
                txtEndereco.Text = inst.Endereco;
                txtBairro.Text = inst.Bairro;
                txtCidade.Text = inst.Cidade;
                txtTelefone.Text = inst.Telefone;
                txtemail.Text = inst.Email;
                cbUf.Text = inst.UF;
                txtPesquisar.Text = "Pesquise pelo ID";
            }
            catch
            {
                txtPesquisar.Text = "Pesquise pelo ID";
                MessageBox.Show("ID inválido", "Campo Vazio", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                 
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult Resultado = MessageBox.Show("Tem certeza que deseja excluir este cadastro?", "Excluir", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (Resultado == MessageBoxResult.Yes)
                {
                    pegarDadosDasInstituicao();
                    conexao.Instituicoes.Attach(inst);
                    conexao.Instituicoes.Remove(inst);
                    conexao.SaveChanges();
                    LimparTXTs();
                    atualizarDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("É obrigatório que o doador seja pesquisado antes de atualizar", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtCNPJ_LostFocus(object sender, RoutedEventArgs e)
        {
            try {
                string RecebCNPJ = txtCNPJ.Text;
                txtCNPJ.Text = FormatCNPJ(RecebCNPJ);
            }
            catch
            {

            }
        }

        private void txtTelefone_LostFocus(object sender, RoutedEventArgs e)
        {
            try {
                string RecebTEL = txtTelefone.Text;
                txtTelefone.Text = FormatTel(RecebTEL);
            }
            catch
            {

            }
        }

        private void txtTelefone_GotFocus(object sender, RoutedEventArgs e)
        {
            txtTelefone.Text = "";
        }

        private void txtCNPJ_GotFocus(object sender, RoutedEventArgs e)
        {
            txtCNPJ.Text = "";
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            

            try
            {
                if (txtBairro.Text == "" || txtCidade.Text == "" || txtCNPJ.Text == "" || txtemail.Text == "" || txtEndereco.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
                {
                    MessageBox.Show("É obrigatório que a instituição seja pesquisada antes de atualizar e que todos os campos estejam preenchidos.", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {

                    pegarDadosDasInstituicao();

                    conexao.Instituicoes.AddOrUpdate(inst);
                    conexao.SaveChanges();

                    atualizarDataGrid();
                }
            }
            catch
            {
                MessageBox.Show("É obrigatório que o doador seja pesquisado antes de atualizar", "Campos vazios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtPesquisar_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPesquisar.Text = "";
        }

        private void txtCNPJ_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void txtTelefone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
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
