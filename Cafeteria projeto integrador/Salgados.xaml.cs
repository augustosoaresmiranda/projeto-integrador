using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cafeteria_projeto_integrador
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Salgados : Page
    {
        public Salgados()
        {
            InitializeComponent();
        }

       

        private void BtnSalgados_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Carrinho_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarrinhoPage());
        }

        private void BtnBebidas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Bebidas());
        }

        private void crospresunt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
