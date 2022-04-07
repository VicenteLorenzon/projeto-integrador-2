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
    public partial class frm_pesquisaFornecedor : UserControl {
        public frm_pesquisaFornecedor() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbx_filtro.SelectedIndex = 1;
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e) {
            if (cbx_filtro.SelectedIndex == 0 && !int.TryParse(mtx_termo.Text, out _)) {
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
                    comm = new SqlCommand("SELECT Registro, CPF, CNPJ, Nome, Telefone, Descricao FROM Fornecedores WHERE Registro = @Registro", conn);
                    comm.Parameters.Add("@Registro", System.Data.SqlDbType.Int);
                    comm.Parameters["@Registro"].Value = mtx_termo.Text;
                    pesquisaOK = true;
                }
                else if (cbx_filtro.SelectedIndex == 1) {
                    comm = new SqlCommand("SELECT Registro, CPF, CNPJ, Nome, Telefone, Descricao FROM Fornecedores where Nome LIKE '%" + mtx_termo.Text + "%'", conn);
                    pesquisaOK = true; 
                }
                else if (cbx_filtro.SelectedIndex == 3) {
                    comm = new SqlCommand("SELECT Registro, CPF, CNPJ, Nome, Telefone, Descricao FROM Fornecedores where CPF = @CPF", conn);
                    comm.Parameters.Add("@CPF", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CPF"].Value = mtx_termo.Text;
                    pesquisaOK = true;
                }
                else if (cbx_filtro.SelectedIndex == 2) {
                    comm = new SqlCommand("SELECT Registro, CPF, CNPJ, Nome, Telefone, Descricao FROM Fornecedores where CNPJ = @CNPJ", conn);
                    comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.NVarChar);
                    comm.Parameters["@CNPJ"].Value = mtx_termo.Text;
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
                                try {
                                    row.Cells[1].Value = reader.GetString(1).Trim();
                                }
                                catch {
                                    row.Cells[1].Value = null;
                                }
                                try {
                                    row.Cells[2].Value = reader.GetString(2).Trim();
                                }
                                catch {
                                    row.Cells[2].Value = null;
                                }
                                row.Cells[3].Value = reader.GetString(3).Trim();
                                row.Cells[4].Value = reader.GetString(4).Trim();
                                row.Cells[5].Value = reader.GetString(5).Trim();
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

        private void cbx_filtro_SelectedIndexChanged(object sender, EventArgs e) {
            if(cbx_filtro.SelectedIndex == 2) {
                mtx_termo.Mask = "99,999,999/9999-99";
            }
            else if (cbx_filtro.SelectedIndex == 3) {
                mtx_termo.Mask = "999,999,999-99";
            }
            else {
                mtx_termo.Mask = "";
            }
        }
    }
}
