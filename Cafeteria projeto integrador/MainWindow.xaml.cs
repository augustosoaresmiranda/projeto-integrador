using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cafeteria_projeto_integrador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()

        {
            InitializeComponent();
            ConectBd banco = new ConectBd();
            ConectBd.AbrirConexao("server=localhost;user=root;password=123456789;database=Loja");
            MainFrame.Navigate(new Cadastro());

            MainFrame.Navigate(new Cadastro());
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnProduto_Click(object sender, RoutedEventArgs e)
        {
            Window2 janela = new Window2();
            janela.Show();

            this.Close();
        }
    }
}