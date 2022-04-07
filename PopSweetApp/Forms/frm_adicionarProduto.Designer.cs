
namespace PopSweetApp
{
    partial class frm_adicionarProduto
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
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_quantSabores = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.num_saboresPermitidos = new System.Windows.Forms.NumericUpDown();
            this.num_preco = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_saboresPermitidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 88);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(261, 26);
            this.tbx_nome.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(204, 306);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(121, 44);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(65, 66);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_quantSabores
            // 
            this.lbl_quantSabores.AutoSize = true;
            this.lbl_quantSabores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantSabores.Location = new System.Drawing.Point(65, 135);
            this.lbl_quantSabores.Name = "lbl_quantSabores";
            this.lbl_quantSabores.Size = new System.Drawing.Size(271, 19);
            this.lbl_quantSabores.TabIndex = 6;
            this.lbl_quantSabores.Text = "Quantidade de sabores permitidos";
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preco.Location = new System.Drawing.Point(65, 204);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(54, 19);
            this.lbl_preco.TabIndex = 8;
            this.lbl_preco.Text = "Preço";
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1047, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // num_saboresPermitidos
            // 
            this.num_saboresPermitidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_saboresPermitidos.Location = new System.Drawing.Point(69, 157);
            this.num_saboresPermitidos.Name = "num_saboresPermitidos";
            this.num_saboresPermitidos.Size = new System.Drawing.Size(50, 26);
            this.num_saboresPermitidos.TabIndex = 24;
            // 
            // num_preco
            // 
            this.num_preco.DecimalPlaces = 2;
            this.num_preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_preco.Location = new System.Drawing.Point(69, 226);
            this.num_preco.Name = "num_preco";
            this.num_preco.Size = new System.Drawing.Size(93, 26);
            this.num_preco.TabIndex = 25;
            // 
            // frm_adicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.num_preco);
            this.Controls.Add(this.num_saboresPermitidos);
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_quantSabores);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_adicionarProduto";
            this.Size = new System.Drawing.Size(1090, 827);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_saboresPermitidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_preco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_quantSabores;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.NumericUpDown num_saboresPermitidos;
        private System.Windows.Forms.NumericUpDown num_preco;
    }
}
