using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Cafeteria_projeto_integrador
{
    class ConectBd
    {
        public string StrConex;
        public static MySqlConnection? Conexao { get; private set; }
        public ConectBd()
        {
            StrConex = "Server= localhost; Database= Cafeteria; Uid=root; Pwd=123456789";
        }


        public static void AbrirConexao(string banco)
        {
            try
            {
                if (Conexao == null)
                {
                    Conexao = new MySqlConnection(banco);
                    Conexao.Open();

                }
            }
            catch (Exception ex)
            {
                Conexao = null;
                MessageBox.Show(ex.ToString());

            }
        }

        public static void FecharConexao()
        {
            if (Conexao != null && Conexao.State == System.Data.ConnectionState.Open)
                Conexao.Close();
        }

    }

}

