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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cafeteria_projeto_integrador
{
    /// <summary>
    /// Interação lógica para Bebidas.xam
    /// </summary>
    public partial class Bebidas : Page
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        

        private void BtnSalgados_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Salgados());
        }

        private void Carrinho_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CarrinhoPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
