using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PopSweetApp
{
    public partial class frm_editarProdutos : UserControl
    {
        public frm_editarProdutos()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void cbx_selecaoProduto_DropDown(object sender, EventArgs e) {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.PopSweetConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Produto FROM Produtos", conn);

            try {
                try {
                    conn.Open();
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir a conexão com a base de dados!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try {
                    cbx_selecaoProduto.Items.Clear();
                    reader = comm.ExecuteReader();
                    while (reader.Read()) {
                        cbx_selecaoProduto.Items.Add(reader.GetString(0));
                    }
                    reader.Close();

                }
                catch (Exception error) {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally {
                conn.Close();
            }
        }

        private void cbx_selecaoProduto_SelectedIndexChanged(object sender, EventArgs e) {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.PopSweetConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Produto, Quant_sabores, Preco FROM Produtos WHERE Produto = @Produto", conn);
            comm.Parameters.Add("@Produto", SqlDbType.NVarChar);
            comm.Parameters["@Produto"].Value = cbx_selecaoProduto.SelectedItem.ToString();

            try {
                try {
                    conn.Open();
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir a conexão com a base de dados!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                try {
                    reader = comm.ExecuteReader();
                    while (reader.Read()) {
                        tbx_nome.Text = reader.GetString(0).Trim();
                        num_quantSabores.Value = Convert.ToDecimal(reader.GetValue(1));
                        num_preco.Value = Convert.ToDecimal(reader.GetValue(2));
                           
                    }
                    reader.Close();

                }
                catch (Exception error) {
                    MessageBox.Show(error.Message,
                        "Erro ao executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally {
                conn.Close();
            }
            
        }

        private void bt_alterar_Click(object sender, EventArgs e) {
            if (cbx_selecaoProduto.SelectedItem == null) {
                MessageBox.Show("Selecione um produto válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (num_preco.Value == 0) {
                MessageBox.Show("A quantidade de sabores permitidos não pode ser 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                bool bOK = true;

                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("UPDATE Produtos SET Produto = @Produto, Preco = @Preco, Quant_sabores = @Quant_sabores WHERE Produto = @ProdutoSelecionado", conn);

                comm.Parameters.Add("@ProdutoSelecionado", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@ProdutoSelecionado"].Value = cbx_selecaoProduto.SelectedItem.ToString();

                comm.Parameters.Add("@Produto", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Produto"].Value = tbx_nome.Text;

                comm.Parameters.Add("@Preco", System.Data.SqlDbType.Float);
                comm.Parameters["@Preco"].Value = Convert.ToSingle(num_preco.Value);

                comm.Parameters.Add("@Quant_sabores", System.Data.SqlDbType.TinyInt);
                comm.Parameters["@Quant_sabores"].Value = Convert.ToInt16(num_quantSabores.Value);

                try {
                    try {
                        conn.Open();
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o banco de dados.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                    try {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                }
                catch { }
                finally {
                    conn.Close();

                    if (bOK == true) {
                        MessageBox.Show("Produto alterado com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e) {
            if (!cbx_selecaoProduto.Items.Contains(cbx_selecaoProduto.Text)) {
                MessageBox.Show("Selecione um produto válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja mesmo deletar este Produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                bool bOK = true;

                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("DELETE FROM Produtos WHERE Produto = @Produto", conn);
                comm.Parameters.Add("@Produto", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Produto"].Value = cbx_selecaoProduto.SelectedItem.ToString();

                try {
                    try {
                        conn.Open();
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o banco de dados.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                    try {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error) {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOK = false;
                    }
                }
                catch { }
                finally {
                    conn.Close();
                    if (bOK == true) {
                        MessageBox.Show("Produto deletado com sucesso!",
                            "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
