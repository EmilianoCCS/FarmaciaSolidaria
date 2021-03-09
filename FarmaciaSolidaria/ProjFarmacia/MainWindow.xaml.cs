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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace ProjFarmacia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((txtUser.Text == "Admin") && (pbSenha.Password == "admin"))
            {
                ConsultaEstoque WinConsulta = new ConsultaEstoque();
                WinConsulta.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Login e senha não conferem", "Acesso Negado");
                txtUser.Text = "";
                pbSenha.Password = "";
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Logoff = new MainWindow();
            Logoff.Show();
            Close();
        }
    }
}
