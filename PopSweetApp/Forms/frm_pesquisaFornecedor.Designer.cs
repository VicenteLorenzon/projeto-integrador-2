
namespace PopSweetApp {
    partial class frm_pesquisaFornecedor {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.lbl_pesquisarpor = new System.Windows.Forms.Label();
            this.cbx_filtro = new System.Windows.Forms.ComboBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popSweetDataSet = new PopSweetApp.PopSweetDataSet();
            this.fornecedoresTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.FornecedoresTableAdapter();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.mtx_termo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(68, 151);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(162, 42);
            this.btn_pesquisar.TabIndex = 9;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // lbl_pesquisarpor
            // 
            this.lbl_pesquisarpor.AutoSize = true;
            this.lbl_pesquisarpor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisarpor.Location = new System.Drawing.Point(64, 65);
            this.lbl_pesquisarpor.Name = "lbl_pesquisarpor";
            this.lbl_pesquisarpor.Size = new System.Drawing.Size(122, 19);
            this.lbl_pesquisarpor.TabIndex = 7;
            this.lbl_pesquisarpor.Text = "Pesquisar por:";
            // 
            // cbx_filtro
            // 
            this.cbx_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filtro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filtro.FormattingEnabled = true;
            this.cbx_filtro.Items.AddRange(new object[] {
            "Registro",
            "Nome",
            "CNPJ",
            "CPF"});
            this.cbx_filtro.Location = new System.Drawing.Point(68, 87);
            this.cbx_filtro.Name = "cbx_filtro";
            this.cbx_filtro.Size = new System.Drawing.Size(162, 26);
            this.cbx_filtro.TabIndex = 6;
            this.cbx_filtro.SelectedIndexChanged += new System.EventHandler(this.cbx_filtro_SelectedIndexChanged);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.CPF,
            this.CNPJ,
            this.Nome,
            this.Telefone,
            this.Descricao});
            this.dgv_clientes.Location = new System.Drawing.Point(68, 249);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_clientes.Size = new System.Drawing.Size(843, 277);
            this.dgv_clientes.TabIndex = 5;
            // 
            // Registro
            // 
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Width = 80;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Width = 120;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.popSweetDataSet;
            // 
            // popSweetDataSet
            // 
            this.popSweetDataSet.DataSetName = "PopSweetDataSet";
            this.popSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1123, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // mtx_termo
            // 
            this.mtx_termo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_termo.Location = new System.Drawing.Point(68, 119);
            this.mtx_termo.Name = "mtx_termo";
            this.mtx_termo.Size = new System.Drawing.Size(226, 26);
            this.mtx_termo.TabIndex = 24;
            // 
            // frm_pesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtx_termo);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_pesquisarpor);
            this.Controls.Add(this.cbx_filtro);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "frm_pesquisaFornecedor";
            this.Size = new System.Drawing.Size(1166, 647);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label lbl_pesquisarpor;
        private System.Windows.Forms.ComboBox cbx_filtro;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private PopSweetDataSet popSweetDataSet;
        private PopSweetDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.MaskedTextBox mtx_termo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}
