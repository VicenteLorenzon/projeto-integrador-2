
namespace PopSweetApp {
    partial class frm_pesquisaCliente {
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
            this.cbx_filtro = new System.Windows.Forms.ComboBox();
            this.lbl_pesquisarpor = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_termo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_filtro
            // 
            this.cbx_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_filtro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filtro.FormattingEnabled = true;
            this.cbx_filtro.Items.AddRange(new object[] {
            "Registro",
            "Nome"});
            this.cbx_filtro.Location = new System.Drawing.Point(69, 88);
            this.cbx_filtro.Name = "cbx_filtro";
            this.cbx_filtro.Size = new System.Drawing.Size(162, 26);
            this.cbx_filtro.TabIndex = 1;
            // 
            // lbl_pesquisarpor
            // 
            this.lbl_pesquisarpor.AutoSize = true;
            this.lbl_pesquisarpor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisarpor.Location = new System.Drawing.Point(65, 66);
            this.lbl_pesquisarpor.Name = "lbl_pesquisarpor";
            this.lbl_pesquisarpor.Size = new System.Drawing.Size(122, 19);
            this.lbl_pesquisarpor.TabIndex = 2;
            this.lbl_pesquisarpor.Text = "Pesquisar por:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(69, 152);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(162, 42);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1082, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.Nome,
            this.Telefone,
            this.CEP});
            this.dgv_clientes.Location = new System.Drawing.Point(69, 250);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_clientes.Size = new System.Drawing.Size(462, 277);
            this.dgv_clientes.TabIndex = 0;
            // 
            // Registro
            // 
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Width = 60;
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
            this.Telefone.Width = 90;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 70;
            // 
            // txb_termo
            // 
            this.txb_termo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_termo.Location = new System.Drawing.Point(69, 120);
            this.txb_termo.Name = "txb_termo";
            this.txb_termo.Size = new System.Drawing.Size(214, 26);
            this.txb_termo.TabIndex = 25;
            // 
            // frm_pesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_termo);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.lbl_pesquisarpor);
            this.Controls.Add(this.cbx_filtro);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "frm_pesquisaCliente";
            this.Size = new System.Drawing.Size(1125, 620);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_filtro;
        private System.Windows.Forms.Label lbl_pesquisarpor;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.TextBox txb_termo;
    }
}
