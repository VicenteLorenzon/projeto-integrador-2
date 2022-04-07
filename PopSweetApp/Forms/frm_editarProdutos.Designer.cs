
namespace PopSweetApp
{
    partial class frm_editarProdutos
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
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.lbl_selecioneProduto = new System.Windows.Forms.Label();
            this.cbx_selecaoProduto = new System.Windows.Forms.ComboBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_quantSabores = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.num_quantSabores = new System.Windows.Forms.NumericUpDown();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantSabores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(69, 372);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(105, 47);
            this.bt_excluir.TabIndex = 13;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(217, 372);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(105, 47);
            this.bt_alterar.TabIndex = 12;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // lbl_selecioneProduto
            // 
            this.lbl_selecioneProduto.AutoSize = true;
            this.lbl_selecioneProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecioneProduto.Location = new System.Drawing.Point(65, 65);
            this.lbl_selecioneProduto.Name = "lbl_selecioneProduto";
            this.lbl_selecioneProduto.Size = new System.Drawing.Size(163, 19);
            this.lbl_selecioneProduto.TabIndex = 9;
            this.lbl_selecioneProduto.Text = "Selecione o produto";
            // 
            // cbx_selecaoProduto
            // 
            this.cbx_selecaoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_selecaoProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_selecaoProduto.FormattingEnabled = true;
            this.cbx_selecaoProduto.Location = new System.Drawing.Point(69, 87);
            this.cbx_selecaoProduto.Name = "cbx_selecaoProduto";
            this.cbx_selecaoProduto.Size = new System.Drawing.Size(261, 26);
            this.cbx_selecaoProduto.TabIndex = 8;
            this.cbx_selecaoProduto.DropDown += new System.EventHandler(this.cbx_selecaoProduto_DropDown);
            this.cbx_selecaoProduto.SelectedIndexChanged += new System.EventHandler(this.cbx_selecaoProduto_SelectedIndexChanged);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(65, 277);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(54, 19);
            this.lbl_preco.TabIndex = 18;
            this.lbl_preco.Text = "Preço";
            // 
            // lbl_quantSabores
            // 
            this.lbl_quantSabores.AutoSize = true;
            this.lbl_quantSabores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantSabores.Location = new System.Drawing.Point(65, 208);
            this.lbl_quantSabores.Name = "lbl_quantSabores";
            this.lbl_quantSabores.Size = new System.Drawing.Size(271, 19);
            this.lbl_quantSabores.TabIndex = 16;
            this.lbl_quantSabores.Text = "Quantidade de sabores permitidos";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 161);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(261, 26);
            this.tbx_nome.TabIndex = 15;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(65, 139);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 14;
            this.lbl_nome.Text = "Nome";
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(652, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // num_quantSabores
            // 
            this.num_quantSabores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_quantSabores.Location = new System.Drawing.Point(69, 231);
            this.num_quantSabores.Name = "num_quantSabores";
            this.num_quantSabores.Size = new System.Drawing.Size(56, 26);
            this.num_quantSabores.TabIndex = 24;
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_preco.Location = new System.Drawing.Point(69, 299);
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(93, 26);
            this.num_preco.TabIndex = 26;
            // 
            // frm_editarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num_preco);
            this.Controls.Add(this.num_quantSabores);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_quantSabores);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.lbl_selecioneProduto);
            this.Controls.Add(this.cbx_selecaoProduto);
            this.Name = "frm_editarProdutos";
            this.Size = new System.Drawing.Size(695, 539);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantSabores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Label lbl_selecioneProduto;
        private System.Windows.Forms.ComboBox cbx_selecaoProduto;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_quantSabores;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.NumericUpDown num_quantSabores;
        private System.Windows.Forms.NumericUpDown num_preco;
    }
}
