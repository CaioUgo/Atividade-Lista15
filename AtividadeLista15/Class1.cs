using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AtividadeLista15
{
    class Setores
    {
        private string nome;
        private int id;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    public bool CadastrarSetor()
        {
            try
            {
                using(MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string inserir = "insert into setores (nome) value (@nome);";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comando.ExecuteNonQuery();

                    if(resultado>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar setor - Método -> " + ex.Message, "Erro - Cadastrar setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ListarSetores(DataGridView grid)
        {
            using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
            {
                string select = "select * from setores;";

                MySqlCommand comando = new MySqlCommand(select, conexaoBanco);
                MySqlDataReader readerSelect = comando.ExecuteReader();
               
                grid.Rows.Clear();

                while (readerSelect.Read())
                {
                    string nome = readerSelect["nome"].ToString();
                    string id = readerSelect["id"].ToString();
                    grid.Rows.Add(id, nome);
                }
               
                readerSelect.Close();

            }
        }

        public bool ExcluirSetores()
        {
            try
            {
                using(MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string delete = "DELETE FROM setores WHERE nome = @nome;";
                    MySqlCommand deletarSql = new MySqlCommand(delete, conexaoBanco);
                    deletarSql.Parameters.AddWithValue("@nome", Nome);

                    int resultado = deletarSql.ExecuteNonQuery();
                    return resultado > 0;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir setor - Método -> " + ex.Message, "Erro - Excluir setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EditarSetores()
        {
            try
            {
                using(MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string editar = "Update setores set nome = @nome where id = @id;";
                    MySqlCommand editarSql = new MySqlCommand(editar, conexaoBanco);
                    editarSql.Parameters.AddWithValue("@nome", Nome);
                    editarSql.Parameters.AddWithValue("@id", Id);

                    int resultado = editarSql.ExecuteNonQuery();
                    return resultado > 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar setor - Método -> " + ex.Message, "Erro - Editar setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void ListarPorNomes(string nomeBusca, DataGridView grid)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string select = "Select * from setores where nome LIKE @nome;";

                    MySqlCommand selectSql = new MySqlCommand(select, conexaoBanco);
                    selectSql.Parameters.AddWithValue("@nome", "%" + nomeBusca + "%");

                    MySqlDataReader readerSelect = selectSql.ExecuteReader();
                    grid.Rows.Clear();

                    while (readerSelect.Read())
                    {
                        string id = readerSelect["id"].ToString();
                        string nome = readerSelect["nome"].ToString();
                        grid.Rows.Add(id, nome);
                    }

                    readerSelect.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar setor - Método -> " + ex.Message, "Erro - Procurar setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarPorId(string nomeBusca, DataGridView grid)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string select = "Select * from setores where id LIKE @id;";

                    MySqlCommand selectSql = new MySqlCommand(select, conexaoBanco);
                    selectSql.Parameters.AddWithValue("@id", "%" + nomeBusca + "%");

                    MySqlDataReader readerSelect = selectSql.ExecuteReader();
                    grid.Rows.Clear();

                    while (readerSelect.Read())
                    {
                        string id = readerSelect["id"].ToString();
                        string nome = readerSelect["nome"].ToString();
                        grid.Rows.Add(id, nome);
                    }

                    readerSelect.Close();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar setor - Método -> " + ex.Message, "Erro - Procurar setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ExisteNome()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string select = "SELECT COUNT(*) FROM setores WHERE nome = @nome;";
                    MySqlCommand comando = new MySqlCommand(select, conexaoBanco);
                    comando.Parameters.AddWithValue("@nome", Nome);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar nome existente - Método -> " + ex.Message, "Erro - Verificar Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
