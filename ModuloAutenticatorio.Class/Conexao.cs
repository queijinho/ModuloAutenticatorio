using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;
        public static SqlConnection MinhaInstancia
        { //chave da propriedade
            get
            {
                //se não existe conexão.
                if (_conn == null)

                {
                    //criar conexao com SqlServer // nos parenteses -connection string
                    _conn = new SqlConnection(@"Server = Lab206_14\SQLEXPRESS; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;
            }

        }
    }
}

