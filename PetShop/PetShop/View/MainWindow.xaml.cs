using PetShop.View;
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

namespace PetShop
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            Controller.FuncionarioController controller = new Controller.FuncionarioController();
            Funcionario funcionario = new Funcionario();
            

            if(txtUsuario.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
            {
                MenuPrincipal janela = new MenuPrincipal();
                janela.Show();
            }
            else
            {
                MessageBox.Show("Erro de Login");
            }
        }
    }
}
