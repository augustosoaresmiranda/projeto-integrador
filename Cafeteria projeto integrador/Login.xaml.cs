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
    /// Interação lógica para Login.xam
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            string nome = txb1.Text;
            string senha = txbsenha1.Password;
        }

        private void BtnLogar(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT Nome, Senha FROM Usuario WHERE Nome = @nome AND Senha= @senha";

            MySqlCommand comando = new MySqlCommand(sql, ConectBd.Conexao);
            comando.Parameters.AddWithValue("@nome", txb1.Text);
            comando.Parameters.AddWithValue("@senha", txbsenha1.Password);

            using (MySqlDataReader leitor = comando.ExecuteReader())
            {
                if (leitor.Read())
                {
                    string nome = leitor["nome"].ToString();
                    MessageBox.Show($"Bem-vindo {nome}");
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
                leitor.Close();
            }
        }
    }
}
