using MySql.Data.MySqlClient;
using System.Data.Common;

namespace TimeControl.Model
{
    public class Conexao
    {
        
        private static DbConnection _conn;
        public static DbConnection Instance
        {
            get
            {
                if(_conn == null)
                {
                    _conn = new MySqlConnection(@"Server = localhost; Database = timecontrol; Uid = root; Pwd = senac;");
                }
                return _conn;
            }
       
        }
    }
}
