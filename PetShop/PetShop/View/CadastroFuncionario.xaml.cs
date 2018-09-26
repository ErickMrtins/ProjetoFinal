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

namespace PetShop
{
    /// <summary>
    /// Lógica interna para CadastroFuncionario.xaml
    /// </summary>
    public partial class CadastroFuncionario : Window
    {

        

        public CadastroFuncionario()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Administrador");
            cmbTipo.Items.Add("Comum");
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cargo = txtCargo.Text;
            funcionario.Salario = Convert.ToDouble(txtSalario.Text);
            if (cmbTipo.Text.Equals("Administrador"))
            {
                funcionario.Tipo = true;
            }
            else
            {
                funcionario.Tipo = false;
            }
            funcionario.Senha = txtSenha.Text;
            Controller.FuncionarioController controller = new Controller.FuncionarioController();
            controller.inserir(funcionario);
            
            
        }
    }
}
