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
    public partial class frm_pesquisaCliente : UserControl {
        public frm_pesquisaCliente() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbx_filtro.SelectedIndex = 1;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e) {
            if (cbx_filtro.SelectedIndex == 0 && !int.TryParse(txb_termo.Text, out _)) {
                MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                SqlConnection conn;
                SqlCommand comm = null;
                SqlDataReader reader;

                bool pesquisaOK = false;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;
                conn = new SqlConnection(connectionString);

                if (cbx_filtro.SelectedIndex == 0) {
                    comm = new SqlCommand("SELECT Registro, Nome, Telefone, CEP FROM Clientes WHERE Registro = @Registro", conn);
                    comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                    comm.Parameters["@Registro"].Value = txb_termo.Text;
                    pesquisaOK = true;
                }
                else if (cbx_filtro.SelectedIndex == 1) {
                    comm = new SqlCommand("SELECT Registro, Nome, Telefone, CEP FROM Clientes where Nome LIKE '%" + txb_termo.Text + "%'", conn);
                    pesquisaOK = true;
                }
                if (pesquisaOK) {
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
                            dgv_clientes.Rows.Clear();
                            reader = comm.ExecuteReader();
                            while (reader.Read()) {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dgv_clientes);
                                row.Cells[0].Value = reader.GetInt32(0);
                                row.Cells[1].Value = reader.GetString(1).Trim();
                                row.Cells[2].Value = reader.GetString(2).Trim();
                                row.Cells[3].Value = reader.GetString(3).Trim();
                                dgv_clientes.Rows.Add(row);
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
}
