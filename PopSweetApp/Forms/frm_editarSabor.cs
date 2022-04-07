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
    public partial class frm_editarSabor : UserControl
    {
        public frm_editarSabor()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void bt_excluir_Click(object sender, EventArgs e) {
            if (cbx_selecaoSabor.SelectedItem == null) {
                MessageBox.Show("Selecione um sabor válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja mesmo deletar este sabor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                bool bOK = true;

                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                comm = new SqlCommand("DELETE FROM Sabores WHERE Sabor = @Sabor", conn);

                comm.Parameters.Add("@Sabor", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Sabor"].Value = cbx_selecaoSabor.SelectedItem.ToString();

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
                        MessageBox.Show("Sabor deletado com sucesso!",
                            "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void cbx_selecaoSabor_DropDown(object sender, EventArgs e) {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.PopSweetConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Sabor FROM Sabores", conn);

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
                    cbx_selecaoSabor.Items.Clear();
                    reader = comm.ExecuteReader();
                    while (reader.Read()) {
                        cbx_selecaoSabor.Items.Add(reader.GetString(0));
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
