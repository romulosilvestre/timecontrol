using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeControl.Model
{
    public class ResponsabilidadeDAO
    {
       

        public ResponsabilidadeDAO()
        {
                  
        }
        public void InserirResponsabilidade(MySqlConnection conexao,ResponsabilidadesVO r)
        {
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();
            //Definindo o tipo
            comando.CommandType = System.Data.CommandType.Text;

            //Definindo a DML
            comando.CommandText = "INSERT INTO Responsabilidades(Descricao)Values(@Descricao)";

            //Passando valor para os parâmetros
            comando.Parameters.Add(new MySqlParameter("@Descricao",r.Descricao));

            //Executando o comando...

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public DataTable ListarResponsabilidades(MySqlConnection conexao)
        {
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM responsabilidades";
            DataTable dataTable = new DataTable();
            MySqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            conexao.Close();
            return dataTable;

        }
        public void DeletarResposabilidade(MySqlConnection conexao)
        {
            conexao.Open();
            MySqlCommand comando = conexao.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM responsabilidades";
            DataTable dataTable = new DataTable();
            MySqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            conexao.Close();
          


        }

    }
}
