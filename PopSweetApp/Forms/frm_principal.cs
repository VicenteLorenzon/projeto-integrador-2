using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopSweetApp
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void tsm_adicionarCliente_Click(object sender, EventArgs e) {
            frm_cadastroClientes uc = new frm_cadastroClientes();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Cadastro de cliente";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_editarCliente_Click(object sender, EventArgs e) {
            frm_alterarClientes uc = new frm_alterarClientes();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Edição de cliente";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_adicionarSabor_Click(object sender, EventArgs e) {
            frm_adicionarSabor uc = new frm_adicionarSabor();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Cadastro de sabor";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_editarSabor_Click(object sender, EventArgs e) {
            frm_editarSabor uc = new frm_editarSabor();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Edição de Sabor";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_adicionarTipo_Click(object sender, EventArgs e) {
            frm_adicionarProduto uc = new frm_adicionarProduto();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Cadastro de produto";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_editarTipo_Click(object sender, EventArgs e) {
            frm_editarProdutos uc = new frm_editarProdutos();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Edição de produto";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_adicionarFornecedor_Click(object sender, EventArgs e) {
            frm_adicionarEmpresas uc = new frm_adicionarEmpresas();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Cadastro de fornecedor";
            tbc_principal.Controls.Add(tab);
        }

        private void tsm_editarFornecedor_Click(object sender, EventArgs e) {
            frm_editarEmpresas uc = new frm_editarEmpresas();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Edição de Fornecedor";
            tbc_principal.Controls.Add(tab);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e) {
            txb_valor uc = new txb_valor();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Efetivação de venda";
            tbc_principal.Controls.Add(tab);
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_entradaProdutos uc = new frm_entradaProdutos();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Entrada de produtos";
            tbc_principal.Controls.Add(tab);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_pesquisaCliente uc = new frm_pesquisaCliente();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Pesquisa de clientes";
            tbc_principal.Controls.Add(tab);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e) {
            frm_pesquisaFornecedor uc = new frm_pesquisaFornecedor();
            TabPage tab = new TabPage();
            tab.Controls.Add(uc);
            tab.Text = "Pesquisa de fornecedores";
            tbc_principal.Controls.Add(tab);
        }

        private void totalGastoTodosClientesToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_rVendasPorCliente f = new frm_rVendasPorCliente();
            f.Show();
        }

        private void vendasPorDataToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_rTodasVendas f = new frm_rTodasVendas();
            f.Show();
        }

        private void todosOsClientesToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_rTodosClientes f = new frm_rTodosClientes();
            f.Show();
        }

        private void comprasDeUmClienteToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_pesquisaClienteRelatorio f = new frm_pesquisaClienteRelatorio();
            f.ShowDialog();
        }

        private void todosFornecedoresToolStripMenuItem_Click(object sender, EventArgs e) {
            frm_rTodosFornecedores f = new frm_rTodosFornecedores();
            f.Show();
        }

        private void entradasPorDataToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void entradasPorFornecedorToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }
    }
}
