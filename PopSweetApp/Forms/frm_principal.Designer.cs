
namespace PopSweetApp
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnu_principal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_adicionarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_adicionarSabor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editarSabor = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_adicionarTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editarTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_adicionarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_editarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.enrtadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeUmClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalGastoTodosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasPorFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_principal = new System.Windows.Forms.TabControl();
            this.mnu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_principal
            // 
            this.mnu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.enrtadasToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.pesquisaToolStripMenuItem});
            this.mnu_principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_principal.Name = "mnu_principal";
            this.mnu_principal.Size = new System.Drawing.Size(800, 24);
            this.mnu_principal.TabIndex = 0;
            this.mnu_principal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_adicionarCliente,
            this.tsm_editarCliente});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsm_adicionarCliente
            // 
            this.tsm_adicionarCliente.Name = "tsm_adicionarCliente";
            this.tsm_adicionarCliente.Size = new System.Drawing.Size(125, 22);
            this.tsm_adicionarCliente.Text = "Adicionar";
            this.tsm_adicionarCliente.Click += new System.EventHandler(this.tsm_adicionarCliente_Click);
            // 
            // tsm_editarCliente
            // 
            this.tsm_editarCliente.Name = "tsm_editarCliente";
            this.tsm_editarCliente.Size = new System.Drawing.Size(125, 22);
            this.tsm_editarCliente.Text = "Editar";
            this.tsm_editarCliente.Click += new System.EventHandler(this.tsm_editarCliente_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saboresToolStripMenuItem,
            this.tipoToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_adicionarSabor,
            this.tsm_editarSabor});
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saboresToolStripMenuItem.Text = "Sabores";
            // 
            // tsm_adicionarSabor
            // 
            this.tsm_adicionarSabor.Name = "tsm_adicionarSabor";
            this.tsm_adicionarSabor.Size = new System.Drawing.Size(125, 22);
            this.tsm_adicionarSabor.Text = "Adicionar";
            this.tsm_adicionarSabor.Click += new System.EventHandler(this.tsm_adicionarSabor_Click);
            // 
            // tsm_editarSabor
            // 
            this.tsm_editarSabor.Name = "tsm_editarSabor";
            this.tsm_editarSabor.Size = new System.Drawing.Size(125, 22);
            this.tsm_editarSabor.Text = "Editar";
            this.tsm_editarSabor.Click += new System.EventHandler(this.tsm_editarSabor_Click);
            // 
            // tipoToolStripMenuItem
            // 
            this.tipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_adicionarTipo,
            this.tsm_editarTipo});
            this.tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            this.tipoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tipoToolStripMenuItem.Text = "Tipo";
            // 
            // tsm_adicionarTipo
            // 
            this.tsm_adicionarTipo.Name = "tsm_adicionarTipo";
            this.tsm_adicionarTipo.Size = new System.Drawing.Size(125, 22);
            this.tsm_adicionarTipo.Text = "Adicionar";
            this.tsm_adicionarTipo.Click += new System.EventHandler(this.tsm_adicionarTipo_Click);
            // 
            // tsm_editarTipo
            // 
            this.tsm_editarTipo.Name = "tsm_editarTipo";
            this.tsm_editarTipo.Size = new System.Drawing.Size(125, 22);
            this.tsm_editarTipo.Text = "Editar";
            this.tsm_editarTipo.Click += new System.EventHandler(this.tsm_editarTipo_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_adicionarFornecedor,
            this.tsm_editarFornecedor});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores ";
            // 
            // tsm_adicionarFornecedor
            // 
            this.tsm_adicionarFornecedor.Name = "tsm_adicionarFornecedor";
            this.tsm_adicionarFornecedor.Size = new System.Drawing.Size(125, 22);
            this.tsm_adicionarFornecedor.Text = "Adicionar";
            this.tsm_adicionarFornecedor.Click += new System.EventHandler(this.tsm_adicionarFornecedor_Click);
            // 
            // tsm_editarFornecedor
            // 
            this.tsm_editarFornecedor.Name = "tsm_editarFornecedor";
            this.tsm_editarFornecedor.Size = new System.Drawing.Size(125, 22);
            this.tsm_editarFornecedor.Text = "Editar";
            this.tsm_editarFornecedor.Click += new System.EventHandler(this.tsm_editarFornecedor_Click);
            // 
            // enrtadasToolStripMenuItem
            // 
            this.enrtadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem});
            this.enrtadasToolStripMenuItem.Name = "enrtadasToolStripMenuItem";
            this.enrtadasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.enrtadasToolStripMenuItem.Text = "Entradas";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.entradasToolStripMenuItem.Text = "Entrada de nota";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.entradasToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.saídasToolStripMenuItem.Text = "Saídas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendaToolStripMenuItem.Text = "Vendas";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasPorDataToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendasPorDataToolStripMenuItem
            // 
            this.vendasPorDataToolStripMenuItem.Name = "vendasPorDataToolStripMenuItem";
            this.vendasPorDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasPorDataToolStripMenuItem.Text = "Vendas por data";
            this.vendasPorDataToolStripMenuItem.Click += new System.EventHandler(this.vendasPorDataToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsClientesToolStripMenuItem,
            this.comprasDeUmClienteToolStripMenuItem,
            this.totalGastoTodosClientesToolStripMenuItem});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // todosOsClientesToolStripMenuItem
            // 
            this.todosOsClientesToolStripMenuItem.Name = "todosOsClientesToolStripMenuItem";
            this.todosOsClientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.todosOsClientesToolStripMenuItem.Text = "Todos os clientes";
            this.todosOsClientesToolStripMenuItem.Click += new System.EventHandler(this.todosOsClientesToolStripMenuItem_Click);
            // 
            // comprasDeUmClienteToolStripMenuItem
            // 
            this.comprasDeUmClienteToolStripMenuItem.Name = "comprasDeUmClienteToolStripMenuItem";
            this.comprasDeUmClienteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.comprasDeUmClienteToolStripMenuItem.Text = "Histórico de compras de cliente";
            this.comprasDeUmClienteToolStripMenuItem.Click += new System.EventHandler(this.comprasDeUmClienteToolStripMenuItem_Click);
            // 
            // totalGastoTodosClientesToolStripMenuItem
            // 
            this.totalGastoTodosClientesToolStripMenuItem.Name = "totalGastoTodosClientesToolStripMenuItem";
            this.totalGastoTodosClientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.totalGastoTodosClientesToolStripMenuItem.Text = "Total gasto todos clientes";
            this.totalGastoTodosClientesToolStripMenuItem.Click += new System.EventHandler(this.totalGastoTodosClientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosFornecedoresToolStripMenuItem,
            this.entradasPorDataToolStripMenuItem,
            this.entradasPorFornecedorToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // todosFornecedoresToolStripMenuItem
            // 
            this.todosFornecedoresToolStripMenuItem.Name = "todosFornecedoresToolStripMenuItem";
            this.todosFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.todosFornecedoresToolStripMenuItem.Text = "Todos fornecedores";
            this.todosFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.todosFornecedoresToolStripMenuItem_Click);
            // 
            // entradasPorDataToolStripMenuItem
            // 
            this.entradasPorDataToolStripMenuItem.Name = "entradasPorDataToolStripMenuItem";
            this.entradasPorDataToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.entradasPorDataToolStripMenuItem.Text = "Entradas por data";
            this.entradasPorDataToolStripMenuItem.Click += new System.EventHandler(this.entradasPorDataToolStripMenuItem_Click);
            // 
            // entradasPorFornecedorToolStripMenuItem
            // 
            this.entradasPorFornecedorToolStripMenuItem.Name = "entradasPorFornecedorToolStripMenuItem";
            this.entradasPorFornecedorToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.entradasPorFornecedorToolStripMenuItem.Text = "Histórico de entradas do fornecedor";
            this.entradasPorFornecedorToolStripMenuItem.Click += new System.EventHandler(this.entradasPorFornecedorToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem1});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // tbc_principal
            // 
            this.tbc_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_principal.Location = new System.Drawing.Point(0, 24);
            this.tbc_principal.Name = "tbc_principal";
            this.tbc_principal.SelectedIndex = 0;
            this.tbc_principal.Size = new System.Drawing.Size(800, 426);
            this.tbc_principal.TabIndex = 1;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbc_principal);
            this.Controls.Add(this.mnu_principal);
            this.MainMenuStrip = this.mnu_principal;
            this.Name = "frm_principal";
            this.Text = "Pop Sweet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnu_principal.ResumeLayout(false);
            this.mnu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_principal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrtadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.TabControl tbc_principal;
        private System.Windows.Forms.ToolStripMenuItem tsm_adicionarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsm_editarCliente;
        private System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_adicionarSabor;
        private System.Windows.Forms.ToolStripMenuItem tsm_editarSabor;
        private System.Windows.Forms.ToolStripMenuItem tsm_adicionarTipo;
        private System.Windows.Forms.ToolStripMenuItem tsm_editarTipo;
        private System.Windows.Forms.ToolStripMenuItem tsm_adicionarFornecedor;
        private System.Windows.Forms.ToolStripMenuItem tsm_editarFornecedor;
        private System.Windows.Forms.ToolStripMenuItem vendasPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeUmClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalGastoTodosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasPorFornecedorToolStripMenuItem;
    }
}

