using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Usuarios_bd_duas_tabelasV2
{
    public class Database
    {
        private string connectionString;

        private const string servidor = "localhost";
        private const string bancoDados = "Usuarios";
        private const string usuario = "root";
        private const string senha = "Ghost28012002";

        public Database()
        {
            //declarando variavel conexaoBanco para fazer a conexao do banco de dados
            connectionString = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
