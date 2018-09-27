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

namespace PetShop.View
{
    /// <summary>
    /// Lógica interna para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionarios_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionario janela = new CadastroFuncionario();
            janela.Show();
            
        }

        private void btnCadastrarAnimais_Click(object sender, RoutedEventArgs e)
        {
            CadastroAnimais janela = new CadastroAnimais();
            janela.Show();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente janela = new CadastroCliente();
            janela.Show();
        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            CadastroProduto janela = new CadastroProduto();
            janela.Show();
        }
    }
}
