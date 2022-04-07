using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PopSweetApp
{
    public partial class frm_adicionarProduto : UserControl
    {
        public frm_adicionarProduto()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_adicionar_Click(object sender, EventArgs e) {
            if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (num_saboresPermitidos.Value == 0) {
                MessageBox.Show("A quantidade de sabores permitidos não pode ser 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja cadastrar esse produto?", "Cadastro de produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                bool sucessoCadastro = false;
                SqlConnection conn;
                SqlCommand comm = null;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("INSERT INTO Produtos (Produto, Preco, Quant_sabores) VALUES (@Produto, @Preco, @Quant_sabores)", conn);

                comm.Parameters.Add("@Produto", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Produto"].Value = tbx_nome.Text;

                comm.Parameters.Add("@Preco", System.Data.SqlDbType.Float);
                comm.Parameters["@Preco"].Value = num_preco.Value;

                comm.Parameters.Add("@Quant_sabores", System.Data.SqlDbType.TinyInt);
                comm.Parameters["@Quant_sabores"].Value = num_saboresPermitidos.Value;

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
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }
    }
}
