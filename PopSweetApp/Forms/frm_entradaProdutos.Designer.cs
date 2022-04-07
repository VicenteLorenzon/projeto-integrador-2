
namespace PopSweetApp {
    partial class frm_entradaProdutos {
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
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.tbx_registo = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.tbx_cpfcnpj = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpfcnpj = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(229, 303);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(116, 60);
            this.btn_finalizar.TabIndex = 15;
            this.btn_finalizar.Text = "Confirmar entrada";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // tbx_registo
            // 
            this.tbx_registo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_registo.Location = new System.Drawing.Point(69, 87);
            this.tbx_registo.Name = "tbx_registo";
            this.tbx_registo.Size = new System.Drawing.Size(70, 26);
            this.tbx_registo.TabIndex = 12;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(65, 191);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(48, 19);
            this.lbl_preco.TabIndex = 11;
            this.lbl_preco.Text = "Valor";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(65, 128);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(175, 19);
            this.lbl_descricao.TabIndex = 10;
            this.lbl_descricao.Text = "Descrição do produto";
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(65, 65);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(186, 19);
            this.lbl_registro.TabIndex = 9;
            this.lbl_registro.Text = "Registro do fornecedor";
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_descricao.Location = new System.Drawing.Point(69, 150);
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.Size = new System.Drawing.Size(276, 26);
            this.tbx_descricao.TabIndex = 16;
            // 
            // tbx_cpfcnpj
            // 
            this.tbx_cpfcnpj.Enabled = false;
            this.tbx_cpfcnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cpfcnpj.Location = new System.Drawing.Point(380, 87);
            this.tbx_cpfcnpj.Name = "tbx_cpfcnpj";
            this.tbx_cpfcnpj.Size = new System.Drawing.Size(182, 26);
            this.tbx_cpfcnpj.TabIndex = 19;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Enabled = false;
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(622, 87);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(287, 26);
            this.tbx_nome.TabIndex = 20;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(618, 65);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 21;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_cpfcnpj
            // 
            this.lbl_cpfcnpj.AutoSize = true;
            this.lbl_cpfcnpj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpfcnpj.Location = new System.Drawing.Point(376, 65);
            this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
            this.lbl_cpfcnpj.Size = new System.Drawing.Size(90, 19);
            this.lbl_cpfcnpj.TabIndex = 22;
            this.lbl_cpfcnpj.Text = "CPF/CNPJ";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(145, 87);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(106, 26);
            this.btn_confirmar.TabIndex = 23;
            this.btn_confirmar.Text = "Conferir";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(919, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 24;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_preco.Location = new System.Drawing.Point(69, 214);
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(102, 26);
            this.num_preco.TabIndex = 25;
            // 
            // frm_entradaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num_preco);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.lbl_cpfcnpj);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_cpfcnpj);
            this.Controls.Add(this.tbx_descricao);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.tbx_registo);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_registro);
            this.Name = "frm_entradaProdutos";
            this.Size = new System.Drawing.Size(962, 582);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.TextBox tbx_registo;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.TextBox tbx_cpfcnpj;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpfcnpj;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.NumericUpDown num_preco;
    }
}
