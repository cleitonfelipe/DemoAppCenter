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

namespace DemoAppCenter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public MainWindow()
        {
            Nome = "Cleiton";
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            var login = txtLogin.Text;
            var pwd = txtPass.Password;

            if (login != Nome)
            {
                MessageBox.Show($"Opss! Algo deu Errado.😢");
            }
            else 
            { 
                MessageBox.Show($"Olá {Nome}, seja bem vindo!😉");
            }
        }
    }
}
