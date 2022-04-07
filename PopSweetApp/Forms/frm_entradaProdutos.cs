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

namespace PopSweetApp {
    public partial class frm_entradaProdutos : UserControl {
        public frm_entradaProdutos() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_confirmar_Click(object sender, EventArgs e) {
            tbx_cpfcnpj.Text = "";
            tbx_nome.Text = "";
            if (tbx_registo.Text.Length == 0) {
                MessageBox.Show("Digite o registro do fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(tbx_registo.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                SqlConnection conn;
                SqlCommand comm = null;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;
                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT Nome, CPF, CNPJ FROM Fornecedores WHERE Registro = @Registro", conn);
                comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                comm.Parameters["@Registro"].Value = Convert.ToInt64(tbx_registo.Text);

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
                        if (reader.Read()) {
                            tbx_nome.Text = reader["Nome"].ToString();
                            if (reader["CPF"].ToString().Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Length == 11) {
                                tbx_cpfcnpj.Text = reader["CPF"].ToString();
                            }
                            if (reader["CNPJ"].ToString().Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Replace("/", "").Length == 14) {
                                tbx_cpfcnpj.Text = reader["CNPJ"].ToString();
                            }

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
        }

        private void btn_finalizar_Click(object sender, EventArgs e) {
            if (tbx_registo.Text.Length == 0) {
                MessageBox.Show("Digite o registro do fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(tbx_registo.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx_descricao.Text.Length == 0) {
                MessageBox.Show("Digite a descrição do produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Confirma a entrada de produtos com essas informações?", "Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                bool sucessoCadastro = false;
                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("INSERT INTO Entradas (Fornecedor, Produto, Valor, Data) VALUES (@Fornecedor, @Produto, @Valor, @Data)", conn);

                comm.Parameters.Add("@Fornecedor", System.Data.SqlDbType.Int);
                comm.Parameters["@Fornecedor"].Value = Convert.ToInt64(tbx_registo.Text);

                comm.Parameters.Add("@Produto", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Produto"].Value = tbx_descricao.Text;

                comm.Parameters.Add("@Valor", System.Data.SqlDbType.Float);
                comm.Parameters["@Valor"].Value = Convert.ToSingle(num_preco.Value);

                comm.Parameters.Add("@Data", System.Data.SqlDbType.Date);
                comm.Parameters["@Data"].Value = DateTime.Now.Date;

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
                        comm.ExecuteNonQuery();
                        sucessoCadastro = true;
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
                    if (sucessoCadastro) {
                        MessageBox.Show("Entrada cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }
    }
}
