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
    public partial class frm_alterarClientes : UserControl
    {
        public frm_alterarClientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            tbx_nome.Text = "";
            mtx_CEP.Text = "";
            mtx_telefone.Text = "";
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

                comm = new SqlCommand("SELECT Registro, Nome, Telefone, CEP FROM Clientes WHERE Registro = @Registro", conn);
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
                            tbx_nome.Text = reader["Nome"].ToString();
                            mtx_CEP.Text = reader["CEP"].ToString();
                            mtx_telefone.Text = reader["Telefone"].ToString();

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

   
        private void btn_alterar_Click(object sender, EventArgs e) {
            if (tbx_registro.Text.Length == 0) {
                MessageBox.Show("Digite o Registro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(tbx_registro.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbx_nome.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mtx_telefone.Text.Length < 13) {
                MessageBox.Show("Preencha todos os dígitos do telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                bool bOK = true;

                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("UPDATE Clientes SET Nome = @Nome, CEP = @CEP, Telefone = @Telefone WHERE Registro = @Registro", conn);

                comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                comm.Parameters["@Registro"].Value = Convert.ToInt32(tbx_registro.Text);

                comm.Parameters.Add("@Nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Nome"].Value = tbx_nome.Text;

                comm.Parameters.Add("@Telefone", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Telefone"].Value = mtx_telefone.Text;

                comm.Parameters.Add("@CEP", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@CEP"].Value = mtx_CEP.Text;

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
                        MessageBox.Show("Cliente alterado com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
