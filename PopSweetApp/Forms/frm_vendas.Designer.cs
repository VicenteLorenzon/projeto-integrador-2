
namespace PopSweetApp
{
    partial class txb_valor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.tbx_registro = new System.Windows.Forms.TextBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.mtx_CEP = new System.Windows.Forms.MaskedTextBox();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.chb_clienteCadastrado = new System.Windows.Forms.CheckBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_produtoFinal = new System.Windows.Forms.Label();
            this.btn_adicionarProduto = new System.Windows.Forms.Button();
            this.clb_selecionarSabores = new System.Windows.Forms.CheckedListBox();
            this.cbx_selecionarProduto = new System.Windows.Forms.ComboBox();
            this.popSweetDataSet = new PopSweetApp.PopSweetDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new PopSweetApp.PopSweetDataSetTableAdapters.TableAdapterManager();
            this.lbl_forma = new System.Windows.Forms.Label();
            this.lbl_entrega = new System.Windows.Forms.Label();
            this.cbx_formaPagamento = new System.Windows.Forms.ComboBox();
            this.cbx_entrega = new System.Windows.Forms.ComboBox();
            this.btn_vender = new System.Windows.Forms.Button();
            this.lbl_valorFinalTitulo = new System.Windows.Forms.Label();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            this.lbl_valorProduto = new System.Windows.Forms.Label();
            this.lbl_valorFinal = new System.Windows.Forms.Label();
            this.lbl_saboresSelecionados = new System.Windows.Forms.Label();
            this.btn_limparCarrinho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(191, 143);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(111, 26);
            this.btn_consultar.TabIndex = 27;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // tbx_registro
            // 
            this.tbx_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_registro.Location = new System.Drawing.Point(89, 143);
            this.tbx_registro.Name = "tbx_registro";
            this.tbx_registro.Size = new System.Drawing.Size(70, 26);
            this.tbx_registro.TabIndex = 26;
            this.tbx_registro.TextChanged += new System.EventHandler(this.tbx_registro_TextChanged);
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(85, 120);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(152, 19);
            this.lbl_registro.TabIndex = 25;
            this.lbl_registro.Text = "Registro do cliente";
            // 
            // mtx_CEP
            // 
            this.mtx_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_CEP.Location = new System.Drawing.Point(89, 327);
            this.mtx_CEP.Mask = "99999-999";
            this.mtx_CEP.Name = "mtx_CEP";
            this.mtx_CEP.Size = new System.Drawing.Size(94, 26);
            this.mtx_CEP.TabIndex = 24;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_telefone.Location = new System.Drawing.Point(89, 264);
            this.mtx_telefone.Mask = "(99)99999-9999";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(130, 26);
            this.mtx_telefone.TabIndex = 23;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(89, 201);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(276, 26);
            this.tbx_nome.TabIndex = 22;
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.Location = new System.Drawing.Point(85, 305);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(121, 19);
            this.lbl_CEP.TabIndex = 21;
            this.lbl_CEP.Text = "CEP do cliente";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(85, 242);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(152, 19);
            this.lbl_telefone.TabIndex = 20;
            this.lbl_telefone.Text = "Telefone do cliente";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(85, 179);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(132, 19);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Nome do cliente";
            // 
            // chb_clienteCadastrado
            // 
            this.chb_clienteCadastrado.AutoSize = true;
            this.chb_clienteCadastrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_clienteCadastrado.Location = new System.Drawing.Point(64, 65);
            this.chb_clienteCadastrado.Name = "chb_clienteCadastrado";
            this.chb_clienteCadastrado.Size = new System.Drawing.Size(188, 23);
            this.chb_clienteCadastrado.TabIndex = 29;
            this.chb_clienteCadastrado.Text = "Cliente já cadastrado";
            this.chb_clienteCadastrado.UseVisualStyleBackColor = true;
            this.chb_clienteCadastrado.CheckedChanged += new System.EventHandler(this.chb_clienteCadastrado_CheckedChanged);
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.Location = new System.Drawing.Point(411, 54);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(71, 19);
            this.lbl_produto.TabIndex = 31;
            this.lbl_produto.Text = "Produto";
            // 
            // lbl_produtoFinal
            // 
            this.lbl_produtoFinal.AutoSize = true;
            this.lbl_produtoFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produtoFinal.Location = new System.Drawing.Point(666, 201);
            this.lbl_produtoFinal.Name = "lbl_produtoFinal";
            this.lbl_produtoFinal.Size = new System.Drawing.Size(67, 16);
            this.lbl_produtoFinal.TabIndex = 35;
            this.lbl_produtoFinal.Text = "Carrinho:";
            // 
            // btn_adicionarProduto
            // 
            this.btn_adicionarProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarProduto.Location = new System.Drawing.Point(652, 90);
            this.btn_adicionarProduto.Name = "btn_adicionarProduto";
            this.btn_adicionarProduto.Size = new System.Drawing.Size(81, 59);
            this.btn_adicionarProduto.TabIndex = 36;
            this.btn_adicionarProduto.Text = "Adicionar ao carrinho";
            this.btn_adicionarProduto.UseVisualStyleBackColor = true;
            this.btn_adicionarProduto.Click += new System.EventHandler(this.btn_adicionarProduto_Click);
            // 
            // clb_selecionarSabores
            // 
            this.clb_selecionarSabores.CheckOnClick = true;
            this.clb_selecionarSabores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_selecionarSabores.FormattingEnabled = true;
            this.clb_selecionarSabores.Location = new System.Drawing.Point(411, 120);
            this.clb_selecionarSabores.Name = "clb_selecionarSabores";
            this.clb_selecionarSabores.Size = new System.Drawing.Size(235, 429);
            this.clb_selecionarSabores.TabIndex = 38;
            this.clb_selecionarSabores.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clb_selecionarSabores_MouseUp);
            // 
            // cbx_selecionarProduto
            // 
            this.cbx_selecionarProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_selecionarProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_selecionarProduto.FormattingEnabled = true;
            this.cbx_selecionarProduto.Location = new System.Drawing.Point(411, 90);
            this.cbx_selecionarProduto.Name = "cbx_selecionarProduto";
            this.cbx_selecionarProduto.Size = new System.Drawing.Size(235, 24);
            this.cbx_selecionarProduto.TabIndex = 39;
            this.cbx_selecionarProduto.SelectedIndexChanged += new System.EventHandler(this.cbx_selecionarProduto_SelectedIndexChanged);
            // 
            // popSweetDataSet
            // 
            this.popSweetDataSet.DataSetName = "PopSweetDataSet";
            this.popSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.popSweetDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.SaboresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PopSweetApp.PopSweetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendasTableAdapter = null;
            // 
            // lbl_forma
            // 
            this.lbl_forma.AutoSize = true;
            this.lbl_forma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forma.Location = new System.Drawing.Point(811, 58);
            this.lbl_forma.Name = "lbl_forma";
            this.lbl_forma.Size = new System.Drawing.Size(171, 19);
            this.lbl_forma.TabIndex = 40;
            this.lbl_forma.Text = "Forma de pagamento";
            // 
            // lbl_entrega
            // 
            this.lbl_entrega.AutoSize = true;
            this.lbl_entrega.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrega.Location = new System.Drawing.Point(1054, 58);
            this.lbl_entrega.Name = "lbl_entrega";
            this.lbl_entrega.Size = new System.Drawing.Size(69, 19);
            this.lbl_entrega.TabIndex = 41;
            this.lbl_entrega.Text = "Entrega";
            // 
            // cbx_formaPagamento
            // 
            this.cbx_formaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_formaPagamento.FormattingEnabled = true;
            this.cbx_formaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Cartão crédito",
            "Cartão débito",
            "Cheque"});
            this.cbx_formaPagamento.Location = new System.Drawing.Point(815, 80);
            this.cbx_formaPagamento.Name = "cbx_formaPagamento";
            this.cbx_formaPagamento.Size = new System.Drawing.Size(167, 21);
            this.cbx_formaPagamento.TabIndex = 42;
            // 
            // cbx_entrega
            // 
            this.cbx_entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_entrega.FormattingEnabled = true;
            this.cbx_entrega.Items.AddRange(new object[] {
            "Loja",
            "Delivery"});
            this.cbx_entrega.Location = new System.Drawing.Point(1058, 80);
            this.cbx_entrega.Name = "cbx_entrega";
            this.cbx_entrega.Size = new System.Drawing.Size(121, 21);
            this.cbx_entrega.TabIndex = 43;
            // 
            // btn_vender
            // 
            this.btn_vender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.Location = new System.Drawing.Point(1038, 486);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(141, 48);
            this.btn_vender.TabIndex = 44;
            this.btn_vender.Text = "Efetuar venda";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // lbl_valorFinalTitulo
            // 
            this.lbl_valorFinalTitulo.AutoSize = true;
            this.lbl_valorFinalTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorFinalTitulo.Location = new System.Drawing.Point(829, 486);
            this.lbl_valorFinalTitulo.Name = "lbl_valorFinalTitulo";
            this.lbl_valorFinalTitulo.Size = new System.Drawing.Size(90, 19);
            this.lbl_valorFinalTitulo.TabIndex = 46;
            this.lbl_valorFinalTitulo.Text = "Valor final:";
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1165, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 47;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_preco.Location = new System.Drawing.Point(558, 523);
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(88, 26);
            this.num_preco.TabIndex = 48;
            // 
            // lbl_valorProduto
            // 
            this.lbl_valorProduto.AutoSize = true;
            this.lbl_valorProduto.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_valorProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorProduto.Location = new System.Drawing.Point(558, 504);
            this.lbl_valorProduto.Name = "lbl_valorProduto";
            this.lbl_valorProduto.Size = new System.Drawing.Size(41, 16);
            this.lbl_valorProduto.TabIndex = 49;
            this.lbl_valorProduto.Text = "Valor:";
            // 
            // lbl_valorFinal
            // 
            this.lbl_valorFinal.AutoSize = true;
            this.lbl_valorFinal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorFinal.Location = new System.Drawing.Point(829, 510);
            this.lbl_valorFinal.Name = "lbl_valorFinal";
            this.lbl_valorFinal.Size = new System.Drawing.Size(55, 24);
            this.lbl_valorFinal.TabIndex = 50;
            this.lbl_valorFinal.Text = "R$ 0";
            // 
            // lbl_saboresSelecionados
            // 
            this.lbl_saboresSelecionados.AutoSize = true;
            this.lbl_saboresSelecionados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saboresSelecionados.Location = new System.Drawing.Point(652, 153);
            this.lbl_saboresSelecionados.Name = "lbl_saboresSelecionados";
            this.lbl_saboresSelecionados.Size = new System.Drawing.Size(82, 16);
            this.lbl_saboresSelecionados.TabIndex = 51;
            this.lbl_saboresSelecionados.Text = "Sabores: 0/0";
            // 
            // btn_limparCarrinho
            // 
            this.btn_limparCarrinho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparCarrinho.Location = new System.Drawing.Point(757, 198);
            this.btn_limparCarrinho.Name = "btn_limparCarrinho";
            this.btn_limparCarrinho.Size = new System.Drawing.Size(106, 23);
            this.btn_limparCarrinho.TabIndex = 52;
            this.btn_limparCarrinho.Text = "Limpar carrinho";
            this.btn_limparCarrinho.UseVisualStyleBackColor = true;
            this.btn_limparCarrinho.Click += new System.EventHandler(this.btn_limparCarrinho_Click);
            // 
            // txb_valor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_limparCarrinho);
            this.Controls.Add(this.lbl_saboresSelecionados);
            this.Controls.Add(this.lbl_valorFinal);
            this.Controls.Add(this.lbl_valorProduto);
            this.Controls.Add(this.num_preco);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.lbl_valorFinalTitulo);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.cbx_entrega);
            this.Controls.Add(this.cbx_formaPagamento);
            this.Controls.Add(this.lbl_entrega);
            this.Controls.Add(this.lbl_forma);
            this.Controls.Add(this.cbx_selecionarProduto);
            this.Controls.Add(this.clb_selecionarSabores);
            this.Controls.Add(this.btn_adicionarProduto);
            this.Controls.Add(this.lbl_produtoFinal);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.chb_clienteCadastrado);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.tbx_registro);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.mtx_CEP);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Name = "txb_valor";
            this.Size = new System.Drawing.Size(1208, 716);
            this.Load += new System.EventHandler(this.frm_vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox tbx_registro;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.MaskedTextBox mtx_CEP;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.CheckBox chb_clienteCadastrado;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_sabor;
        private System.Windows.Forms.Button btn_adicionarSabor;
        private System.Windows.Forms.Label lbl_produtoFinal;
        private System.Windows.Forms.Button btn_adicionarProduto;
        private System.Windows.Forms.Button btn_confirmarProduto;
        private System.Windows.Forms.CheckedListBox clb_selecionarSabores;
        private System.Windows.Forms.ComboBox cbx_selecionarProduto;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private PopSweetDataSet popSweetDataSet;
        private PopSweetDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private PopSweetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lbl_forma;
        private System.Windows.Forms.Label lbl_entrega;
        private System.Windows.Forms.ComboBox cbx_formaPagamento;
        private System.Windows.Forms.ComboBox cbx_entrega;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Label lbl_valorFinalTitulo;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.NumericUpDown num_preco;
        private System.Windows.Forms.Label lbl_valorProduto;
        private System.Windows.Forms.Label lbl_valorFinal;
        private System.Windows.Forms.Label lbl_saboresSelecionados;
        private System.Windows.Forms.Button btn_limparCarrinho;
    }
}
