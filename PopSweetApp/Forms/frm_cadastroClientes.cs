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
    public partial class frm_cadastroClientes : UserControl
    {
        public frm_cadastroClientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void bt_cadastrar_Click(object sender, EventArgs e) {
            if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_telefone.Text.Length < 13) {
                MessageBox.Show("Preencha todos os dígitos do telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja cadastrar o cliente com estas informações?", "Cadastro de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                bool sucessoCadastro = false;
                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("INSERT INTO Clientes (Nome, Telefone, CEP, Data_cadastro) VALUES (@Nome, @Telefone, @CEP, @Data)", conn);

                comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Nome"].Value = tbx_nome.Text;

                comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Telefone"].Value = mtx_telefone.Text;

                comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CEP"].Value = mtx_CEP.Text;

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
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }
    }
}
