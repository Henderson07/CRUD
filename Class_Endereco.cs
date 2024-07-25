using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios_bd_duas_tabelasV2
{
    internal class Class_Endereco
    {
        private int enderecoID;
        private int usuarioID;
        private string rua;
        private string cidade;
        private string estado;

        public int EnderecoID
        {
            get { return enderecoID; }
            set { enderecoID = value; }
        }
        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void InserirEndereco(Database db)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Enderecos (UsuarioID, Rua, Cidade, Estado) VALUES (@UsuarioID, @Rua, @Cidade, @Estado)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UsuarioID", this.UsuarioID);
                cmd.Parameters.AddWithValue("@Rua", this.Rua);
                cmd.Parameters.AddWithValue("@Cidade", this.Cidade);
                cmd.Parameters.AddWithValue("@Estado", this.Estado);
                cmd.ExecuteNonQuery();
            }
      
        }
      
        public static List<Class_Endereco> BuscarEnderecosPorUsuarioId(Database db,int usuarioId)
        {
            List<Class_Endereco> lista = new List<Class_Endereco>();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = $"select funcionarios.UsuarioID, funcionarios.Nome, funcionarios.Cpf, enderecos.EnderecoID, enderecos.Rua, enderecos.Cidade, enderecos.Estado from funcionarios " +
                    $"inner join enderecos on funcionarios.UsuarioID = enderecos.UsuarioID where funcionarios.cpf = '{usuarioId}';";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var endereco = new Class_Endereco
                        {
                            EnderecoID = reader.GetInt32("EnderecoID"),
                            UsuarioID = reader.GetInt32("UsuarioID"),
                            Rua = reader.GetString("Rua"),
                            Cidade = reader.GetString("Cidade"),
                            Estado = reader.GetString("Estado")
                        };
                        lista.Add(endereco);
                    }
                }
            }
            return lista;

        }
        public void AtualizarEndereco(Database db)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Enderecos SET Rua = @Rua, Cidade = @Cidade, Estado = @Estado WHERE EnderecoID = @EnderecoID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Rua", Rua);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@EnderecoID", EnderecoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
