using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Usuarios_bd_duas_tabelasV2
{
    internal class Class_Usuario
    {
        private int usuarioID;
        private string nome;
        private int cpf;

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public void inserirFuncionario(Database db)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open(); // Abre a conexão com o banco de dados

                string query = $"insert into funcionarios(nome,cpf) values('{nome}','{cpf}')"; // Define a instrução SQL

                MySqlCommand cmd = new MySqlCommand(query, connection); // Cria o comando MySQL

                //cmd.Parameters.AddWithValue("@Nome", nome); // Adiciona o parâmetro à instrução SQL

                cmd.ExecuteNonQuery(); // Executa a instrução SQL (neste caso, uma inserção)
            }
        }
        public int ObterUltimoUsuarioId(Database db)
        {

            int usuarioId = 0;
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT MAX(UsuarioID) FROM funcionarios;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    usuarioId = Convert.ToInt32(result);
                }
            }
            return usuarioId;
        }
        public static Class_Usuario BuscarUsuarioPorId(Database db, int Cpf)
        {
            Class_Usuario usuario = null;
            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open(); // Abre a conexão com o banco de dados

                    string query = $"SELECT UsuarioID, Nome, Cpf FROM funcionarios WHERE Cpf = '{Cpf}';"; // Define a instrução SQL

                    MySqlCommand cmd = new MySqlCommand(query, connection); // Cria o comando MySQL

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Class_Usuario
                            {
                                UsuarioID = reader.GetInt32("UsuarioID"),
                                Nome = reader.GetString("Nome"),
                                Cpf = reader.GetInt32("Cpf")                             
                            };
                        }
                    }
                }
                return usuario;               
            }  
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método BuscarUsuarioPorId: " + ex.Message);
            }
        return usuario;
        }
        public static void DeletarUsuario(Database db, int usuarioID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM enderecos WHERE UsuarioID = @UsuarioID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.ExecuteNonQuery();
                
                string query1 = "DELETE FROM funcionarios WHERE UsuarioID = @UsuarioID";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd1.ExecuteNonQuery();
            }
        }
        public static void DeletarEndereco(Database db, int enderecoID)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM enderecos WHERE EnderecoID = @EnderecoID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("EnderecoID", enderecoID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}



