using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System.Security.Cryptography;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Usuarios_bd_duas_tabelasV2
{
    public partial class Cadastro : Form
    {
        private Database db;
        private Class_Usuario usuarioID;

        public Cadastro()
        {
            InitializeComponent();
            db = new Database();

            //dados de formatação do listView
            lstBuscar.View = View.Details;
            lstBuscar.LabelEdit = true;
            lstBuscar.AllowColumnReorder = true;
            lstBuscar.FullRowSelect = true;
            lstBuscar.GridLines = true;

            lstBuscar.Columns.Add("ID: ", 30, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Rua: ", 130, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Cidade: ", 100, HorizontalAlignment.Left);
            lstBuscar.Columns.Add("Estado: ", 100, HorizontalAlignment.Left);

            lstBuscar.SelectedIndexChanged += lstBuscar_SelectedIndexChanged_1;

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtCpf.Text.Equals("") && !txtRua.Text.Equals("") && !txtCidade.Text.Equals("") && !txtEstado.Text.Equals(""))
                {
                    Class_Usuario usuario = new Class_Usuario();
                    usuario.Nome = txtNome.Text;
                    usuario.Cpf = Convert.ToInt32(txtCpf.Text);

                    // Inserir um novo usuário
                    usuario.inserirFuncionario(db);

                    // Obter o ID do usuário recém-criado
                    int usuarioId = usuario.ObterUltimoUsuarioId(db);


                    // Inserir endereços para o usuário
                    Class_Endereco endereco = new Class_Endereco
                    {
                        UsuarioID = usuarioId,
                        Rua = txtRua.Text,
                        Cidade = txtCidade.Text,
                        Estado = txtEstado.Text,
                    };

                    endereco.InserirEndereco(db);

                    // Limpar os campos após a inserção
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    MessageBox.Show("Usuário e endereço inseridos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na função inserir Funcionario");
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtRua.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtBuscarContato.Clear();
            lstBuscar.Items.Clear();
            txtNome.Focus();
            lblEnderecoID.Text = "";
            lblId.Text = "";
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int Cpf;

            if (int.TryParse(txtBuscarContato.Text, out Cpf))
            {
                // Buscar usuário pelo ID
                Class_Usuario usuario = Class_Usuario.BuscarUsuarioPorId(db, Cpf);
                if (usuario != null)
                {
                    txtNome.Text = usuario.Nome;
                    txtCpf.Text = Convert.ToString(Cpf);
                    lblId.Text = usuario.UsuarioID.ToString();

                    List<Class_Endereco> enderecos = Class_Endereco.BuscarEnderecosPorUsuarioId(db, Cpf);

                    if (usuario != null)
                    {
                        lstBuscar.Items.Clear();

                        foreach (Class_Endereco endereco in enderecos)
                        {
                            // Cria um novo ListViewItem
                            ListViewItem item = new ListViewItem(endereco.EnderecoID.ToString());
                            // Adiciona as subitems (as outras colunas)
                            item.SubItems.Add(endereco.Rua);
                            item.SubItems.Add(endereco.Cidade);
                            item.SubItems.Add(endereco.Estado);
                            // Adiciona o item ao ListView
                            lstBuscar.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de usuário válido.");
            }
        }
        private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuscar.SelectedItems.Count > 0)
            {
                ListViewItem item = lstBuscar.SelectedItems[0];

                txtRua.Text = item.SubItems[0].Text;
                txtCidade.Text = item.SubItems[1].Text;
                txtEstado.Text = item.SubItems[2].Text;

                // Aqui você pode configurar o ID do endereço selecionado, caso precise para a atualização
                string enderecoID = lblEnderecoID.Text;// Obtenha o ID do endereço conforme sua implementação
                lblEnderecoID.Text = enderecoID;
            }
        }
        private void btnInserirEndereco_Click(object sender, EventArgs e)
        {
            if (!txtBuscarContato.Text.Equals("") && !txtRua.Text.Equals("") && !txtCidade.Text.Equals("") && !txtEstado.Text.Equals(""))
            {
                int usuarioId;
                if (int.TryParse(lblId.Text, out usuarioId))
                {
                    // Inserir endereço para o usuário existente                                    
                    Class_Endereco endereco = new Class_Endereco
                    {
                        UsuarioID = usuarioId,
                        Rua = txtRua.Text,
                        Cidade = txtCidade.Text,
                        Estado = txtEstado.Text,

                    };

                    endereco.InserirEndereco(db);

                    // Limpar os campos após a inserção
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtBuscarContato.Clear();
                    lstBuscar.Items.Clear();
                    txtNome.Focus();

                    MessageBox.Show("Endereço inserido com sucesso!");

                }
                else
                {
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();
                    txtNome.Focus();

                    MessageBox.Show("Deu errado só o endereco!");
                }
            }
            else
            {
                txtNome.Clear();
                txtCpf.Clear();
                txtRua.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                txtNome.Focus();

                MessageBox.Show("Deu errado só o endereco!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblEnderecoID.Text, out int enderecoId))
            {
                Class_Endereco enderecoID = new Class_Endereco
                {
                    EnderecoID = enderecoId,
                    Rua = txtRua.Text,
                    Cidade = txtCidade.Text,
                    Estado = txtEstado.Text
                };

                enderecoID.AtualizarEndereco(db);

                // Limpar os campos após a atualização
                txtRua.Clear();
                txtCidade.Clear();
                txtEstado.Clear();

                MessageBox.Show("Endereço atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de endereço válido.");
            }
        }

        private void lstBuscar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                if (lstBuscar.SelectedItems.Count > 0)
                {
                    ListViewItem item = lstBuscar.SelectedItems[0];

                    lblEnderecoID.Text = item.SubItems[0].Text;
                    txtRua.Text = item.SubItems[1].Text;
                    txtCidade.Text = item.SubItems[2].Text;
                    txtEstado.Text = item.SubItems[3].Text;


                    // Aqui você pode configurar o ID do endereço selecionado, caso precise para a atualização
                    string enderecoID = lblEnderecoID.Text;
                    lblEnderecoID.Text = enderecoID.ToString();
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (lblId != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este usuário?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // int.TryParse(lblId.Text, out int usuarioID);
                    Class_Usuario.DeletarUsuario(db, Convert.ToInt32(lblId.Text));

                    // Limpar os campos após a deleção
                    lblId.Text = "";
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();

                    // Limpar a ListView
                    lstBuscar.Items.Clear();

                    MessageBox.Show("Usuário deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, pesquise um usuário válido antes de deletar.");
            }
        }

        private void btnDeletarEndereco_Click(object sender, EventArgs e)
        {
            if (lblEnderecoID != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar este endereço?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // int.TryParse(lblId.Text, out int usuarioID);
                    Class_Usuario.DeletarEndereco(db, Convert.ToInt32(lblEnderecoID.Text));

                    // Limpar os campos após a deleção
                    lblId.Text = "";
                    txtNome.Clear();
                    txtCpf.Clear();
                    txtRua.Clear();
                    txtCidade.Clear();
                    txtEstado.Clear();

                    // Limpar a ListView
                    lstBuscar.Items.Clear();

                    MessageBox.Show("Endereço deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, pesquise um usuário válido antes de deletar.");
            }
        }
    }
}
