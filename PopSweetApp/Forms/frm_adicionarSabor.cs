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
    public partial class frm_adicionarSabor : UserControl
    {
        public frm_adicionarSabor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (tbx_sabor.Text.Length == 0) {
                MessageBox.Show("Preencha o nome do sabor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja cadastrar esse sabor?", "Cadastro de sabor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                bool sucessoCadastro = false;
                SqlConnection conn;
                SqlCommand comm = null;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("INSERT INTO Sabores (Sabor) VALUES (@Sabor)", conn);

                comm.Parameters.Add("@Sabor", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Sabor"].Value = tbx_sabor.Text;

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
                        MessageBox.Show("Sabor cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
        }
    }
}
