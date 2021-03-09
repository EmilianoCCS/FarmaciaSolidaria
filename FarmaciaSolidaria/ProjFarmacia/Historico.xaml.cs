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

namespace ProjFarmacia
{
    /// <summary>
    /// Interaction logic for Historico.xaml
    /// </summary>
    public partial class Historico
    {
        public Historico()
        {
            InitializeComponent();
        }
        private void miRemedio_Click(object sender, RoutedEventArgs e)
        {
            Remedio WinRemedio = new Remedio();
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

        private void miAlterar_Click(object sender, RoutedEventArgs e)
        {
            Estoque WinAlterar = new Estoque();
            WinAlterar.Show();
            Close();
        }

        private void miHistorico_Click(object sender, RoutedEventArgs e)
        {
            Historico WinHistorico = new Historico();
            WinHistorico.Show();
            Close();
        }
    }
}
