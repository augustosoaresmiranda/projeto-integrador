using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interação lógica para Login.xam
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Password;

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite o e-mail.", "Aviso",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Digite a senha.", "Aviso",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                txtSenha.Focus();
                return;
            }

            // Valida o formato do e-mail
            if (!EmailValido(email))
            {
                MessageBox.Show("Digite um e-mail válido.", "Erro",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                txtEmail.Focus();
                return;
            }

            // Login de exemplo
            if (email == "admin@saintcoffee.com" && senha == "1234")
            {
                MessageBox.Show("Login realizado com sucesso!",
                    "Sucesso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                // Abre a tela inicial
                NavigationService.Navigate(new Bebidas());

                // Fecha a janela do login
                
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                txtSenha.Clear();
                txtSenha.Focus();
            }
        }

        private bool EmailValido(string email)
        {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cadastro());
        }
    }
}
