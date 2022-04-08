
namespace PopSweetApp
{
    partial class frm_editarEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editarEmpresas));
            this.tbx_produto = new System.Windows.Forms.TextBox();
            this.lbl_razaoSocial = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.mtx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.tbx_registro = new System.Windows.Forms.TextBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.mtx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_produto
            // 
            this.tbx_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_produto.Location = new System.Drawing.Point(69, 324);
            this.tbx_produto.Name = "tbx_produto";
            this.tbx_produto.Size = new System.Drawing.Size(194, 26);
            this.tbx_produto.TabIndex = 32;
            // 
            // lbl_razaoSocial
            // 
            this.lbl_razaoSocial.AutoSize = true;
            this.lbl_razaoSocial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_razaoSocial.Location = new System.Drawing.Point(65, 184);
            this.lbl_razaoSocial.Name = "lbl_razaoSocial";
            this.lbl_razaoSocial.Size = new System.Drawing.Size(156, 19);
            this.lbl_razaoSocial.TabIndex = 31;
            this.lbl_razaoSocial.Text = "Nome/Razão social";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 206);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(330, 26);
            this.tbx_nome.TabIndex = 30;
            // 
            // mtx_cpf
            // 
            this.mtx_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_cpf.Location = new System.Drawing.Point(69, 147);
            this.mtx_cpf.Mask = "999,999,999-99";
            this.mtx_cpf.Name = "mtx_cpf";
            this.mtx_cpf.Size = new System.Drawing.Size(130, 26);
            this.mtx_cpf.TabIndex = 29;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_telefone.Location = new System.Drawing.Point(69, 265);
            this.mtx_telefone.Mask = "(99)99999-9999";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(130, 26);
            this.mtx_telefone.TabIndex = 25;
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_produto.Location = new System.Drawing.Point(65, 302);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(71, 19);
            this.lbl_produto.TabIndex = 24;
            this.lbl_produto.Text = "Produto";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(65, 243);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(74, 19);
            this.lbl_telefone.TabIndex = 23;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(65, 125);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(42, 19);
            this.lbl_cpf.TabIndex = 22;
            this.lbl_cpf.Text = "CPF";
            // 
            // tbx_registro
            // 
            this.tbx_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_registro.Location = new System.Drawing.Point(69, 86);
            this.tbx_registro.Name = "tbx_registro";
            this.tbx_registro.Size = new System.Drawing.Size(67, 26);
            this.tbx_registro.TabIndex = 34;
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(65, 64);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(74, 19);
            this.lbl_registro.TabIndex = 33;
            this.lbl_registro.Text = "Registro";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(69, 408);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(116, 60);
            this.btn_alterar.TabIndex = 36;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(165, 86);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(111, 26);
            this.btn_consultar.TabIndex = 37;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = ((System.Drawing.Image)(resources.GetObject("pbx_fecharAba.Image")));
            this.pbx_fecharAba.Location = new System.Drawing.Point(760, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 38;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // mtx_cnpj
            // 
            this.mtx_cnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_cnpj.Location = new System.Drawing.Point(232, 147);
            this.mtx_cnpj.Mask = "99,999,999/9999-99";
            this.mtx_cnpj.Name = "mtx_cnpj";
            this.mtx_cnpj.Size = new System.Drawing.Size(155, 26);
            this.mtx_cnpj.TabIndex = 40;
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpj.Location = new System.Drawing.Point(228, 125);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(53, 19);
            this.lbl_cnpj.TabIndex = 39;
            this.lbl_cnpj.Text = "CNPJ";
            // 
            // frm_editarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtx_cnpj);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.tbx_registro);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.tbx_produto);
            this.Controls.Add(this.lbl_razaoSocial);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.mtx_cpf);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_cpf);
            this.Name = "frm_editarEmpresas";
            this.Size = new System.Drawing.Size(803, 597);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_produto;
        private System.Windows.Forms.Label lbl_razaoSocial;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.MaskedTextBox mtx_cpf;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox tbx_registro;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.MaskedTextBox mtx_cnpj;
        private System.Windows.Forms.Label lbl_cnpj;
    }
}
