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
    public partial class frm_adicionarEmpresas : UserControl
    {
        public frm_adicionarEmpresas()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void bt_cadastrar_Click(object sender, EventArgs e) {
            if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_cpfcnpj.Text.Length < mtx_cpfcnpj.Mask.Length) {
                MessageBox.Show("Preencha todos os dígitos do CPF/CNPJ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbt_pessoaFisica.Checked && !Validacao.Validacao.IsCpf(mtx_cpfcnpj.Text)) {
                MessageBox.Show("O CPF informado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbt_pessoaJuridica.Checked && !Validacao.Validacao.IsCnpj(mtx_cpfcnpj.Text)) {
                MessageBox.Show("O CNPJ informado é inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_telefone.Text.Length < 13) {
                MessageBox.Show("Preencha todos os dígitos do telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja cadastrar o fornecedor com estas informações?", "Cadastro de fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                bool sucessoCadastro = false;
                SqlConnection conn;
                SqlCommand comm = null;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                if (rbt_pessoaFisica.Checked) {
                    comm = new SqlCommand("INSERT INTO Fornecedores (CPF, Nome, Telefone, Descricao) VALUES (@CPF, @Nome, @Telefone, @Descricao)", conn);

                    comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CPF"].Value = mtx_cpfcnpj.Text;

                    comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Nome"].Value = tbx_nome.Text;

                    comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Telefone"].Value = mtx_telefone.Text;

                    comm.Parameters.Add("@Descricao", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Descricao"].Value = tbx_produto.Text;
                }
                else if (rbt_pessoaJuridica.Checked) {
                    comm = new SqlCommand("INSERT INTO Fornecedores (CNPJ, Nome, Telefone, Descricao) VALUES (@CNPJ, @Nome, @Telefone, @Descricao)", conn);

                    comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CNPJ"].Value = mtx_cpfcnpj.Text;

                    comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Nome"].Value = tbx_nome.Text;

                    comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Telefone"].Value = mtx_telefone.Text;

                    comm.Parameters.Add("@Descricao", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@Descricao"].Value = tbx_produto.Text;
                }

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
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }

        private void rbt_pessoaFisica_CheckedChanged(object sender, EventArgs e) {
            if (rbt_pessoaFisica.Checked) {
                mtx_cpfcnpj.Mask = "999,999,999-99";
            }
            else {
                mtx_cpfcnpj.Mask = "99,999,999/9999-99";
            }
        }
    }
}
