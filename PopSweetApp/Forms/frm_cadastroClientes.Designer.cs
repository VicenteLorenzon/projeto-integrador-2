
namespace PopSweetApp
{
    partial class frm_cadastroClientes
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtx_CEP = new System.Windows.Forms.MaskedTextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(65, 67);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(65, 130);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(74, 19);
            this.lbl_telefone.TabIndex = 1;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.Location = new System.Drawing.Point(65, 193);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(43, 19);
            this.lbl_CEP.TabIndex = 2;
            this.lbl_CEP.Text = "CEP";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 89);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(276, 26);
            this.tbx_nome.TabIndex = 3;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_telefone.Location = new System.Drawing.Point(69, 152);
            this.mtx_telefone.Mask = "(99)99999-9999";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(123, 26);
            this.mtx_telefone.TabIndex = 4;
            // 
            // mtx_CEP
            // 
            this.mtx_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_CEP.Location = new System.Drawing.Point(69, 215);
            this.mtx_CEP.Mask = "99999-999";
            this.mtx_CEP.Name = "mtx_CEP";
            this.mtx_CEP.Size = new System.Drawing.Size(85, 26);
            this.mtx_CEP.TabIndex = 5;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.Location = new System.Drawing.Point(229, 305);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(116, 60);
            this.bt_cadastrar.TabIndex = 8;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(672, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // frm_cadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.mtx_CEP);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_cadastroClientes";
            this.Size = new System.Drawing.Size(715, 485);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.MaskedTextBox mtx_CEP;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
    }
}
