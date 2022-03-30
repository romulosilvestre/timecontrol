using MySql.Data.MySqlClient; //usar MySQLConnection
using System.Data.Common; //usar o DbConnection

namespace TimeControl.Model //definição do namespace
{
    public class Conexao //Classe:é um conjunto de objetos.
    {
        //palavra reservada:exclusiva.
        //private: privado - encapsulamento
        //static: que é da classe
        //no-static: de instância - 
        //use static com moderação

        //conexão única
        private static MySqlConnection _conn;

        //Verificar a conexão (se existe conexão)
        public static MySqlConnection Instance
        {
            get
            {
                //se não existe conexão.
                if(_conn == null)
                {
                    //criar a conexão com MySQL   //nos parênteses -connection string
                    _conn = new MySqlConnection(@"Server = localhost; Database = timecontrol; Uid = root; Pwd = senac;");
                }
                //retorna a conexão
                return _conn;
            }
       
        }
    }
}
