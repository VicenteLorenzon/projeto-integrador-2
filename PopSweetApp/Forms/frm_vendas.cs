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
    public partial class txb_valor : UserControl {
        int saboresPermitidos = 0;
        float valorFinal = 0;
        bool registroEncontrado = false;
        bool vendaHabilitada = false;

        List<String> carrinhoSabores = new List<String>();
        List<String> carrinhoProdutos = new List<String>();
        List<float> carrinhoPrecos = new List<float>();


        public txb_valor() {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frm_vendas_Load(object sender, EventArgs e) {
            btn_consultar.Enabled = false;
            tbx_registro.Enabled = false;
            tbx_nome.Enabled = true;
            mtx_CEP.Enabled = true;
            mtx_telefone.Enabled = true;
            chb_clienteCadastrado.Checked = false;

            SqlConnection conn;
            SqlCommand comm, comm2;
            SqlDataReader reader, reader2;

            string connectionString = Properties.Settings.Default.PopSweetConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Sabor FROM Sabores", conn);
            comm2 = new SqlCommand("SELECT Produto FROM produtos", conn);

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
                    while (reader.Read()) {
                        clb_selecionarSabores.Items.Add(reader.GetString(0).Trim());
                    }
                    reader.Close();

                    reader2 = comm2.ExecuteReader();
                    while (reader2.Read()) {
                        cbx_selecionarProduto.Items.Add(reader2.GetString(0).Trim());
                    }
                    reader2.Close();

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

        private void chb_clienteCadastrado_CheckedChanged(object sender, EventArgs e) {
            tbx_registro.Text = "";
            tbx_nome.Text = "";
            mtx_CEP.Text = "";
            mtx_telefone.Text = "";
            if (chb_clienteCadastrado.Checked) {
                btn_consultar.Enabled = true;
                tbx_registro.Enabled = true;
                tbx_nome.Enabled = false;
                mtx_CEP.Enabled = false;
                mtx_telefone.Enabled = false;
            }
            else {
                btn_consultar.Enabled = false;
                tbx_registro.Enabled = false;
                tbx_nome.Enabled = true;
                mtx_CEP.Enabled = true;
                mtx_telefone.Enabled = true;
            }
        }

        private void pbx_fecharAba_Click(object sender, EventArgs e) {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            tbx_nome.Text = "";
            mtx_CEP.Text = "";
            mtx_telefone.Text = "";
            if (tbx_registro.Text == "") {
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
                            registroEncontrado = true;

                        }
                        else {
                            registroEncontrado = false;
                            MessageBox.Show("Registro não encontrado",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            tbx_nome.Text = "";
                            mtx_CEP.Text = "";
                            mtx_telefone.Text = "";
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

        private void btn_vender_Click(object sender, EventArgs e) {
            int registroCliente = 0;
            if (carrinhoProdutos.Count == 0) {
                MessageBox.Show("O carrinho está vazio. Adicione produtos primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vendaHabilitada = false;
            }
            else if (cbx_entrega.SelectedIndex == -1) {
                MessageBox.Show("Selecione o tipo de entrega", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vendaHabilitada = false;
            }
            else if (cbx_formaPagamento.SelectedIndex == -1) {
                MessageBox.Show("Selecione a forma de pagamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vendaHabilitada = false;
            }
            else {
                if (!chb_clienteCadastrado.Checked) {
                    if (tbx_nome.Text.Length == 0) {
                        MessageBox.Show("Preencha o nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vendaHabilitada = false;
                    }
                    else if (mtx_telefone.Text.Length < 13) {
                        MessageBox.Show("Preencha todos os dígitos do telefone", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vendaHabilitada = false;
                    }
                    else {
                        SqlConnection conn;
                        SqlCommand comm, comm2;
                        SqlDataReader reader;

                        string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                        conn = new SqlConnection(connectionString);

                        comm = new SqlCommand("INSERT INTO Clientes (Nome, Telefone, CEP) VALUES (@Nome, @Telefone, @CEP)", conn);
                        comm2 = new SqlCommand("SELECT MAX(Registro) FROM Clientes");

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
                                    "Erro ao abrir a conexão com a base de dados!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }

                            try {
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception error) {
                                MessageBox.Show(error.Message,
                                    "Erro ao executar o comando SQL",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            try {
                                reader = comm2.ExecuteReader();
                                if (reader.Read()) {
                                    registroCliente = reader.GetInt32(0);
                                    vendaHabilitada = true;
                                }
                            }
                            catch { }
                        }

                        catch { }
                        finally {
                            conn.Close();
                        }
                    }
                }

                else {
                    if (!int.TryParse(tbx_registro.Text, out _)) {
                        MessageBox.Show("O registro só pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vendaHabilitada = false;
                    }
                    else if (tbx_registro.Text == "") {
                        MessageBox.Show("Digite o registro do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vendaHabilitada = false;
                    }
                    else if (!registroEncontrado) {
                        MessageBox.Show("Cheque a validade do registro do cliente com o botão 'Consultar'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        vendaHabilitada = false;
                    }
                    else {
                        registroCliente = Convert.ToInt32(tbx_registro.Text);
                        vendaHabilitada = true;
                    }
                }
            }
            if (vendaHabilitada) {
                SqlConnection conn;
                SqlCommand comm;

                string connectionString = Properties.Settings.Default.PopSweetConnectionString;

                conn = new SqlConnection(connectionString);

                string comando = "";
                for (int i=0; i < carrinhoProdutos.Count(); i++) {
                    comando += "INSERT INTO Vendas (Valor,Cliente,Produto,Sabores,Data,Tipo_venda,Forma_pag) VALUES ("+carrinhoPrecos[i]+",@Cliente,"+"'"+carrinhoProdutos[i]+"'"+","+"'"+carrinhoSabores[i]+"'"+",@Data,@Tipo_venda,@Forma_pag); ";
                }
                comm = new SqlCommand(comando, conn);

                comm.Parameters.Add("@Valor", System.Data.SqlDbType.Float);
                comm.Parameters["@Valor"].Value = valorFinal;

                comm.Parameters.Add("@Cliente", System.Data.SqlDbType.Int);
                comm.Parameters["@Cliente"].Value = registroCliente;

                comm.Parameters.Add("@Data", System.Data.SqlDbType.Date);
                comm.Parameters["@Data"].Value = DateTime.Now.Date;

                comm.Parameters.Add("@Tipo_venda", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Tipo_venda"].Value = cbx_entrega.SelectedItem.ToString();

                comm.Parameters.Add("@Forma_pag", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Forma_pag"].Value = cbx_formaPagamento.SelectedItem.ToString();

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
                    MessageBox.Show("Venda efetuada com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    mtx_CEP.Text = "";
                    mtx_telefone.Text = "";
                    tbx_nome.Text = "";
                    tbx_registro.Text = "";
                    registroCliente = 0;
                    valorFinal = 0;
                    registroEncontrado = false;
                    vendaHabilitada = false;
                    carrinhoProdutos.Clear();
                    carrinhoSabores.Clear();
                    carrinhoPrecos.Clear();
                    lbl_valorFinal.Text = "R$ " + valorFinal.ToString();
                    lbl_produtoFinal.Text = "Carrinho:";
                }
                
            }
        }
    
        

        private void btn_adicionarProduto_Click(object sender, EventArgs e) {
            if (cbx_selecionarProduto.SelectedItem == null) {
                MessageBox.Show("Selecione o produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clb_selecionarSabores.CheckedItems.Count > saboresPermitidos) {
                MessageBox.Show("Esse produto aceita apenas "+saboresPermitidos+" sabores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clb_selecionarSabores.CheckedItems.Count == 0) {
                MessageBox.Show("Selecione pelo menos um sabor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                carrinhoProdutos.Add(cbx_selecionarProduto.Text);
                String sabores = "";
                foreach (var i in clb_selecionarSabores.CheckedItems) {
                    sabores += i.ToString() + ", ";         
                }
                sabores = sabores.Trim().Trim(',');
                carrinhoSabores.Add(sabores);
                carrinhoPrecos.Add(Convert.ToSingle(num_preco.Value));
                lbl_produtoFinal.Text += "\n   -" + carrinhoProdutos.Last();
                lbl_produtoFinal.Text += "\n       " + carrinhoSabores.Last();
                valorFinal += Convert.ToSingle(num_preco.Value);
                lbl_valorFinal.Text = "R$ " + valorFinal.ToString();
                clb_selecionarSabores.ClearSelected();
            }

        }

        private void cbx_selecionarProduto_SelectedIndexChanged(object sender, EventArgs e) {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = Properties.Settings.Default.PopSweetConnectionString;
            conn = new SqlConnection(connectionString);
            comm = new SqlCommand("SELECT Produto, Quant_sabores, Preco FROM Produtos WHERE Produto = @Produto", conn);

            comm.Parameters.Add("@Produto", SqlDbType.NVarChar);
            comm.Parameters["@Produto"].Value = cbx_selecionarProduto.SelectedItem.ToString();

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
                        num_preco.Value = Convert.ToDecimal(reader["Preco"]);
                        saboresPermitidos = Convert.ToInt32(reader["Quant_sabores"]);
                        lbl_saboresSelecionados.Text = "Sabores: " + clb_selecionarSabores.CheckedItems.Count + "/" + saboresPermitidos;
                        if (clb_selecionarSabores.CheckedItems.Count > saboresPermitidos) {
                            lbl_saboresSelecionados.ForeColor = Color.Red;
                        }
                        else {
                            lbl_saboresSelecionados.ForeColor = Color.Black;
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

        private void clb_selecionarSabores_MouseUp(object sender, MouseEventArgs e) {
            lbl_saboresSelecionados.Text = "Sabores: " + clb_selecionarSabores.CheckedItems.Count + "/" + saboresPermitidos;
            if (clb_selecionarSabores.CheckedItems.Count > saboresPermitidos) {
                lbl_saboresSelecionados.ForeColor = Color.Red;
            }
            else {
                lbl_saboresSelecionados.ForeColor = Color.Black;
            }
        }

        private void btn_limparCarrinho_Click(object sender, EventArgs e) {
            carrinhoProdutos.Clear();
            carrinhoSabores.Clear();
            carrinhoPrecos.Clear();
            valorFinal = 0;
            lbl_valorFinal.Text = "R$ " + valorFinal.ToString();
            lbl_produtoFinal.Text = "Carrinho:";
        }

        private void tbx_registro_TextChanged(object sender, EventArgs e) {
            registroEncontrado = false;
        }
    }
}
