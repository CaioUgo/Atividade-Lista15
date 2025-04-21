namespace AtividadeLista15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, EventArgs.Empty);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    Setores setor = new Setores();
                    setor.Nome = txtNome.Text;

                    if (setor.ExisteNome())
                    {
                        MessageBox.Show("Esse setor j� est� cadastrado!", "Aviso - Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimparCampos();
                        return;
                    }

                    if (setor.CadastrarSetor())
                    {
                        setor.ListarSetores(DataListaSetores);
                        MessageBox.Show("Setor: " + txtNome.Text + " cadastrado com sucesso!", "Sucesso - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel cadastrar", "Erro - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher corretamente os campos!", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel realizar o cadastro: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataListaSetores.Columns.Clear();

            DataListaSetores.ColumnCount = 2;
            DataListaSetores.Columns[0].Name = "ID";
            DataListaSetores.Columns[1].Name = "Nome";

            Setores setor = new Setores();
            setor.ListarSetores(DataListaSetores);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Informe uma linha para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Setores setor = new Setores();
                setor.Nome = txtProcurar.Text;
                setor.Id = int.Parse(txtID.Text);

                if (setor.EditarSetores())
                {
                    setor.ListarSetores(DataListaSetores);
                    MessageBox.Show("Setor: " + txtProcurar.Text + " editado com sucesso!", "Sucesso - edi��o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("N�o foi poss�vel cadastrar", "Erro - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel realizar a edi��o: " + ex.Message, "Erro - Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProcurar.Text))
                {
                    MessageBox.Show("Informe uma linha para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Setores setor = new Setores();
                setor.Nome = txtProcurar.Text;
                setor.Id = int.Parse(txtID.Text);

                if (setor.ExcluirSetores())
                {
                    MessageBox.Show("Setor: " + txtProcurar.Text + " exclus�o com sucesso!", "Sucesso - exclus�o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setor.ListarSetores(DataListaSetores);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("N�o foi poss�vel excluir", "Erro - exclus�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("N�o foi poss�vel realizar a exclus�o: " + ex.Message, "Erro - Exclus�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }

        }

        private void DataListaSetores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DataListaSetores.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nome = row.Cells["nome"].Value.ToString();

                txtProcurar.Text = nome;
                txtID.Text = id;
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string ProcurarNome = txtNome.Text.Trim();

                    Setores setor = new Setores();
                    setor.ListarPorNomes(ProcurarNome, DataListaSetores);

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            Setores setor = new Setores();
            setor.ListarSetores(DataListaSetores);
        }

        public void LimparCampos()
        {
            txtID.Clear();
            txtProcurar.Clear();
        }
    }
}
