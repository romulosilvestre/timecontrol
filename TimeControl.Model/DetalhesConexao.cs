using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Model
{
    public class DetalhesConexao
    {
        public string ConexaoString { get; set; }

        public DetalhesConexao(MySqlConnection conexao)
        {
            conexao.Open();
            this.ConexaoString = conexao.ConnectionString;
            conexao.Close();
        }
    }
}
