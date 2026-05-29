using MySql.Data.MySqlClient;
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
    /// Interação lógica para Cadastro.xam
    /// </summary>
    public partial class Cadastro : Page
    {


        public Cadastro()
        {
            InitializeComponent();

            string nome = txbnome.Text;
            string senha = txbsenha.Password;


        }


        private void BtnCadastrar(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = @"INSERT INTO usuario (Nome, Senha) VALUES (@nome, @senha)";

                using (MySqlCommand cmd = new MySqlCommand(sql, ConectBd.Conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", txbnome.Text);
                    cmd.Parameters.AddWithValue("@senha", txbsenha.Password);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário cadastrado com sucesso!");

                txbnome.Clear();
                txbsenha.Clear();

                NavigationService.Navigate(new Login());
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Este usuário já existe.");
                }
                else
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }
    }
}


