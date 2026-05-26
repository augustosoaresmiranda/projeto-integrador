using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria_projeto_integrador
{
    class ConectBd
    {
        public string StrConex;
        MySqlConnection con = new MySqlConnection();
        public ConectBd() 
        {
            StrConex = "Server= localhost; Database= Cafeteria; Uid=root; Pwd=123456789;";
        }

        public void Conectar() 
        {
           
            con.ConnectionString = StrConex;
            con.Open();
        }
        public void Insert (string sql) 
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
        }



    }
}
