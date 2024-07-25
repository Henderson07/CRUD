namespace Usuarios_bd_duas_tabelasV2
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCpf = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblEndereco = new Label();
            txtRua = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            lblRua = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            btnInserir = new Button();
            btnPesquisar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            btnInserirEndereco = new Button();
            lblIdUser = new Label();
            lblId = new Label();
            lstBuscar = new ListView();
            lblBusca = new Label();
            txtBuscarContato = new TextBox();
            lblIdEndereco = new Label();
            lblEnderecoID = new Label();
            btnDeletarEndereco = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(64, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(64, 94);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(64, 65);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(64, 112);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(210, 23);
            txtCpf.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(132, 149);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 4;
            lblEndereco.Text = "Endereço";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(62, 184);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(210, 23);
            txtRua.TabIndex = 5;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(62, 228);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(210, 23);
            txtCidade.TabIndex = 6;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(62, 272);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(210, 23);
            txtEstado.TabIndex = 7;
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(62, 166);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(30, 15);
            lblRua.TabIndex = 8;
            lblRua.Text = "Rua:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(62, 210);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 9;
            lblCidade.Text = "Cidade:";
            lblCidade.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(60, 254);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado:";
            lblEstado.TextAlign = ContentAlignment.TopRight;
            // 
            // btnInserir
            // 
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(76, 326);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 26);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(595, 62);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 26);
            btnPesquisar.TabIndex = 12;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(419, 320);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(127, 32);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar Endereço";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(166, 326);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 26);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(340, 390);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(57, 25);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnInserirEndereco
            // 
            btnInserirEndereco.FlatStyle = FlatStyle.Flat;
            btnInserirEndereco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInserirEndereco.Location = new Point(295, 320);
            btnInserirEndereco.Name = "btnInserirEndereco";
            btnInserirEndereco.Size = new Size(118, 32);
            btnInserirEndereco.TabIndex = 16;
            btnInserirEndereco.Text = "+ Novo Endereço";
            btnInserirEndereco.UseVisualStyleBackColor = true;
            btnInserirEndereco.Click += btnInserirEndereco_Click;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Location = new Point(45, 15);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(64, 15);
            lblIdUser.TabIndex = 17;
            lblIdUser.Text = "Usuario ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(104, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 18;
            // 
            // lstBuscar
            // 
            lstBuscar.Location = new Point(306, 94);
            lstBuscar.MultiSelect = false;
            lstBuscar.Name = "lstBuscar";
            lstBuscar.Size = new Size(364, 201);
            lstBuscar.TabIndex = 19;
            lstBuscar.UseCompatibleStateImageBehavior = false;
            lstBuscar.SelectedIndexChanged += lstBuscar_SelectedIndexChanged_1;
            // 
            // lblBusca
            // 
            lblBusca.AutoSize = true;
            lblBusca.Location = new Point(306, 42);
            lblBusca.Name = "lblBusca";
            lblBusca.Size = new Size(91, 15);
            lblBusca.TabIndex = 20;
            lblBusca.Text = "Buscar Contato:";
            // 
            // txtBuscarContato
            // 
            txtBuscarContato.Location = new Point(306, 65);
            txtBuscarContato.Name = "txtBuscarContato";
            txtBuscarContato.Size = new Size(283, 23);
            txtBuscarContato.TabIndex = 21;
            // 
            // lblIdEndereco
            // 
            lblIdEndereco.AutoSize = true;
            lblIdEndereco.Location = new Point(262, 15);
            lblIdEndereco.Name = "lblIdEndereco";
            lblIdEndereco.Size = new Size(73, 15);
            lblIdEndereco.TabIndex = 22;
            lblIdEndereco.Text = "Endereco ID:";
            // 
            // lblEnderecoID
            // 
            lblEnderecoID.AutoSize = true;
            lblEnderecoID.Location = new Point(341, 15);
            lblEnderecoID.Name = "lblEnderecoID";
            lblEnderecoID.Size = new Size(0, 15);
            lblEnderecoID.TabIndex = 23;
            // 
            // btnDeletarEndereco
            // 
            btnDeletarEndereco.FlatStyle = FlatStyle.Flat;
            btnDeletarEndereco.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeletarEndereco.Location = new Point(553, 320);
            btnDeletarEndereco.Name = "btnDeletarEndereco";
            btnDeletarEndereco.Size = new Size(124, 32);
            btnDeletarEndereco.TabIndex = 24;
            btnDeletarEndereco.Text = "Deletar Endereco";
            btnDeletarEndereco.UseVisualStyleBackColor = true;
            btnDeletarEndereco.Click += btnDeletarEndereco_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 455);
            Controls.Add(btnDeletarEndereco);
            Controls.Add(lblEnderecoID);
            Controls.Add(lblIdEndereco);
            Controls.Add(txtBuscarContato);
            Controls.Add(lblBusca);
            Controls.Add(lstBuscar);
            Controls.Add(lblId);
            Controls.Add(lblIdUser);
            Controls.Add(btnInserirEndereco);
            Controls.Add(btnLimpar);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnInserir);
            Controls.Add(lblEstado);
            Controls.Add(lblCidade);
            Controls.Add(lblRua);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtRua);
            Controls.Add(lblEndereco);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(lblCpf);
            Controls.Add(lblNome);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCpf;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblEndereco;
        private TextBox txtRua;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label lblRua;
        private Label lblCidade;
        private Label lblEstado;
        private Button btnInserir;
        private Button btnPesquisar;
        private Button btnAtualizar;
        private Button btnDeletar;
        private Button btnLimpar;
        private Button btnInserirEndereco;
        private Label lblIdUser;
        private Label lblId;
        private ListView lstBuscar;
        private Label lblBusca;
        private TextBox txtBuscarContato;
        private Label lblIdEndereco;
        private Label lblEnderecoID;
        private Button btnDeletarEndereco;
    }
}
