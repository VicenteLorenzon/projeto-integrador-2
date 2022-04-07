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
using Validacao;

namespace PopSweetApp
{
    public partial class frm_editarEmpresas : UserControl
    {
        public frm_editarEmpresas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_alterar_Click(object sender, EventArgs e) {
            if (tbx_registro.Text.Length == 0) {
                MessageBox.Show("Digite o Registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(tbx_registro.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_telefone.Text.Length < 13) {
                MessageBox.Show("Preencha todos os dígitos do telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_cnpj.Text.Replace(" ", "").Replace(".", "").Replace("-", "").Replace("/", "") == "" && mtx_cpf.Text.Replace(" ", "").Replace(".", "").Replace("-", "").Replace("/", "") == "") {
                MessageBox.Show("Digite o CPF ou CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_cnpj.Text.Replace(" ", "").Replace(".", "").Replace("-", "").Replace("/", "").Length > 0 && !Validacao.Validacao.IsCnpj(mtx_cnpj.Text)) {
                MessageBox.Show("O CNPJ informado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_cpf.Text.Replace(" ", "").Replace(".", "").Replace("-", "").Length > 0 && !Validacao.Validacao.IsCpf(mtx_cpf.Text)) {
                MessageBox.Show("O CPF informado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                bool bOK = true;

                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("UPDATE Fornecedores SET CPF = @CPF, CNPJ = @CNPJ, Nome = @Nome, Telefone = @Telefone, Descricao = @Descricao WHERE Registro=@Registro", conn);

                comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                comm.Parameters["@Registro"].Value = Convert.ToInt32(tbx_registro.Text);

                if (mtx_cpf.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Length == 11) {
                    comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CPF"].Value = mtx_cpf.Text;
                }
                else {
                    comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CPF"].Value = "";
                }

                if (mtx_cnpj.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Replace("/", "").Length == 14) {
                    comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CNPJ"].Value = mtx_cnpj.Text;
                }
                else {
                    comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CNPJ"].Value = "";
                }

                comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Nome"].Value = tbx_nome.Text;

                comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Telefone"].Value = mtx_telefone.Text;

                comm.Parameters.Add("@Descricao", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Descricao"].Value = tbx_produto.Text;

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
                        MessageBox.Show("Fornecedor alterado com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            tbx_nome.Text = "";
            mtx_cpf.Text = "";
            mtx_cnpj.Text = "";
            mtx_telefone.Text = "";
            tbx_produto.Text = "";
            if (tbx_registro.Text.Length == 0) {
                MessageBox.Show("Digite o Registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(tbx_registro.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                SqlConnection conn;
                SqlCommand comm = null;
                SqlDataReader reader;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;
                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("SELECT Registro, CPF, CNPJ, Nome, Telefone, Descricao FROM Fornecedores WHERE Registro = @Registro", conn);
                comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                comm.Parameters["@Registro"].Value = tbx_registro.Text;
                
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
                            tbx_nome.Text = reader["Nome"].ToString().Trim();
                            mtx_cpf.Text = reader["CPF"].ToString();
                            mtx_cnpj.Text = reader["CNPJ"].ToString();
                            mtx_telefone.Text = reader["Telefone"].ToString();
                            tbx_produto.Text = reader["Descricao"].ToString().Trim();

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
    }
}
