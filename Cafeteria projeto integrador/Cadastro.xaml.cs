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
    /// Interação lógica para Cadastro.xam
    /// </summary>
    public partial class Cadastro : Page
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Password;

            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Digite seu e-mail.",
                    "Aviso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Digite sua senha.",
                    "Aviso",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                txtSenha.Focus();
                return;
            }

            // Verifica se o e-mail é válido
            if (!EmailValido(email))
            {
                MessageBox.Show("Digite um e-mail válido.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                txtEmail.Focus();
                return;
            }

            // Login de exemplo
            if (email == "admin@saintcoffee.com" && senha == "123456")
            {
                MessageBox.Show("Login realizado com sucesso!",
                    "Bem-vindo",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                // Abre a tela inicial
                MainWindow janela = new MainWindow();
                janela.Show();

                // Fecha a janela
                Window.GetWindow(this).Close();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos.",
                    "Erro",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private bool EmailValido(string email)
        {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }
    }
}


