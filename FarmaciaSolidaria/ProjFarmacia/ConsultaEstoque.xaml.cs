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


namespace ProjFarmacia
{
    /// <summary>
    /// Interaction logic for ConsultaEstoque.xaml
    /// </summary>
    public partial class ConsultaEstoque
    {
        Doadores doad = new Doadores();
        Remedios remed = new Remedios();
        Conexaox conexao = new Conexaox();
        Instituicoes inst = new Instituicoes();
        Estoque estoque = new Estoque();


        public List<Estoque> Estoque;
        public List<Doadores> Doadores;
        public List<Remedios> Remedios ;
        public List<Instituicoes> Instituicoes;
        public List<Estoque> listaGlobal = new List<Estoque>();

        public ConsultaEstoque()
        {
            InitializeComponent();
            AtualizaDataGrid();
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

        private void AtualizaDataGrid()
        {

            List<Instituicoes> ListaInstituicao = conexao.Instituicoes.ToList();
            List<Doadores> ListaDoador = conexao.Doadores.ToList();
            List<Remedios> ListaRemedio = conexao.Remedios.ToList();
            List<Estoque> ListaEstoque = conexao.Estoque.ToList();
            dtgTudo.ItemsSource = ListaInstituicao;
            dtgTudo.ItemsSource = ListaRemedio;
            dtgTudo.ItemsSource = ListaDoador;
            dtgTudo.ItemsSource = ListaEstoque;

        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtPesquisar.Text);
                var query = conexao.Estoque.Where(estoqueRecebe => estoqueRecebe.Id == Id);
                listaGlobal.Clear();
                Estoque estoqueTmp = new Estoque();
                estoqueTmp = query.FirstOrDefault();
                listaGlobal.Add(estoqueTmp);
                BuscarDataGrid(listaGlobal);
            }
            catch
            {
                txtPesquisar.Text = "Pesquise pelo ID";
                AtualizaDataGrid();
            }
        }

        private void BuscarDataGrid(List<Estoque> listaGlobal)
        {
            dtgTudo.ItemsSource = null;
            dtgTudo.ItemsSource = listaGlobal;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Saida WinSaida = new Saida();
            WinSaida.Show();
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow winLogin = new MainWindow();
            winLogin.Show();
            Close();
        }

        private void txtPesquisar_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPesquisar.Text = "";
        }
        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Logoff = new MainWindow();
            Logoff.Show();
            Close();
        }
    }
        
}
    

