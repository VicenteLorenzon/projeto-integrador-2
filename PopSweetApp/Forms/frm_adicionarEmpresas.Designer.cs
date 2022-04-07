
namespace PopSweetApp
{
    partial class frm_adicionarEmpresas
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
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpfcnpj = new System.Windows.Forms.Label();
            this.rbt_pessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbt_pessoaJuridica = new System.Windows.Forms.RadioButton();
            this.mtx_cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_razaoSocial = new System.Windows.Forms.Label();
            this.tbx_produto = new System.Windows.Forms.TextBox();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(206, 338);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(116, 60);
            this.bt_cadastrar.TabIndex = 15;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_telefone.Location = new System.Drawing.Point(69, 205);
            this.mtx_telefone.Mask = "(99)99999-9999";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(130, 26);
            this.mtx_telefone.TabIndex = 13;
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.Location = new System.Drawing.Point(65, 242);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(71, 19);
            this.lbl_produto.TabIndex = 11;
            this.lbl_produto.Text = "Produto";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(65, 183);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(74, 19);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_cpfcnpj
            // 
            this.lbl_cpfcnpj.AutoSize = true;
            this.lbl_cpfcnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpfcnpj.Location = new System.Drawing.Point(65, 65);
            this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
            this.lbl_cpfcnpj.Size = new System.Drawing.Size(90, 19);
            this.lbl_cpfcnpj.TabIndex = 9;
            this.lbl_cpfcnpj.Text = "CPF/CNPJ";
            // 
            // rbt_pessoaFisica
            // 
            this.rbt_pessoaFisica.AutoSize = true;
            this.rbt_pessoaFisica.Checked = true;
            this.rbt_pessoaFisica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_pessoaFisica.Location = new System.Drawing.Point(242, 78);
            this.rbt_pessoaFisica.Name = "rbt_pessoaFisica";
            this.rbt_pessoaFisica.Size = new System.Drawing.Size(120, 22);
            this.rbt_pessoaFisica.TabIndex = 16;
            this.rbt_pessoaFisica.TabStop = true;
            this.rbt_pessoaFisica.Text = "Pessoa física";
            this.rbt_pessoaFisica.UseVisualStyleBackColor = true;
            this.rbt_pessoaFisica.CheckedChanged += new System.EventHandler(this.rbt_pessoaFisica_CheckedChanged);
            // 
            // rbt_pessoaJuridica
            // 
            this.rbt_pessoaJuridica.AutoSize = true;
            this.rbt_pessoaJuridica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_pessoaJuridica.Location = new System.Drawing.Point(242, 101);
            this.rbt_pessoaJuridica.Name = "rbt_pessoaJuridica";
            this.rbt_pessoaJuridica.Size = new System.Drawing.Size(133, 22);
            this.rbt_pessoaJuridica.TabIndex = 17;
            this.rbt_pessoaJuridica.Text = "Pessoa jurídica";
            this.rbt_pessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // mtx_cpfcnpj
            // 
            this.mtx_cpfcnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_cpfcnpj.Location = new System.Drawing.Point(69, 87);
            this.mtx_cpfcnpj.Mask = "999,999,999-99";
            this.mtx_cpfcnpj.Name = "mtx_cpfcnpj";
            this.mtx_cpfcnpj.Size = new System.Drawing.Size(167, 26);
            this.mtx_cpfcnpj.TabIndex = 18;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 146);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(330, 26);
            this.tbx_nome.TabIndex = 19;
            // 
            // lbl_razaoSocial
            // 
            this.lbl_razaoSocial.AutoSize = true;
            this.lbl_razaoSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razaoSocial.Location = new System.Drawing.Point(65, 124);
            this.lbl_razaoSocial.Name = "lbl_razaoSocial";
            this.lbl_razaoSocial.Size = new System.Drawing.Size(156, 19);
            this.lbl_razaoSocial.TabIndex = 20;
            this.lbl_razaoSocial.Text = "Nome/Razão social";
            // 
            // tbx_produto
            // 
            this.tbx_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_produto.Location = new System.Drawing.Point(69, 264);
            this.tbx_produto.Name = "tbx_produto";
            this.tbx_produto.Size = new System.Drawing.Size(194, 26);
            this.tbx_produto.TabIndex = 21;
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1155, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 22;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // frm_adicionarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.tbx_produto);
            this.Controls.Add(this.lbl_razaoSocial);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.mtx_cpfcnpj);
            this.Controls.Add(this.rbt_pessoaJuridica);
            this.Controls.Add(this.rbt_pessoaFisica);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cpfcnpj);
            this.Name = "frm_adicionarEmpresas";
            this.Size = new System.Drawing.Size(1198, 843);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpfcnpj;
        private System.Windows.Forms.RadioButton rbt_pessoaFisica;
        private System.Windows.Forms.RadioButton rbt_pessoaJuridica;
        private System.Windows.Forms.MaskedTextBox mtx_cpfcnpj;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_razaoSocial;
        private System.Windows.Forms.TextBox tbx_produto;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
    }
}
