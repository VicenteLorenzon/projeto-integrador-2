
namespace PopSweetApp
{
    partial class frm_alterarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alterarClientes));
            this.mtx_CEP = new System.Windows.Forms.MaskedTextBox();
            this.mtx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.tbx_registro = new System.Windows.Forms.TextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // mtx_CEP
            // 
            this.mtx_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_CEP.Location = new System.Drawing.Point(69, 272);
            this.mtx_CEP.Mask = "99999-999";
            this.mtx_CEP.Name = "mtx_CEP";
            this.mtx_CEP.Size = new System.Drawing.Size(94, 26);
            this.mtx_CEP.TabIndex = 14;
            // 
            // mtx_telefone
            // 
            this.mtx_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtx_telefone.Location = new System.Drawing.Point(69, 209);
            this.mtx_telefone.Mask = "(99)99999-9999";
            this.mtx_telefone.Name = "mtx_telefone";
            this.mtx_telefone.Size = new System.Drawing.Size(130, 26);
            this.mtx_telefone.TabIndex = 13;
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEP.Location = new System.Drawing.Point(65, 250);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(43, 19);
            this.lbl_CEP.TabIndex = 11;
            this.lbl_CEP.Text = "CEP";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(65, 187);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(74, 19);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "Telefone";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(65, 124);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(65, 65);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(74, 19);
            this.lbl_registro.TabIndex = 16;
            this.lbl_registro.Text = "Registro";
            // 
            // tbx_registro
            // 
            this.tbx_registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_registro.Location = new System.Drawing.Point(69, 88);
            this.tbx_registro.Name = "tbx_registro";
            this.tbx_registro.Size = new System.Drawing.Size(70, 26);
            this.tbx_registro.TabIndex = 17;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(171, 88);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(111, 26);
            this.btn_consultar.TabIndex = 18;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(69, 358);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(116, 60);
            this.btn_alterar.TabIndex = 19;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(69, 146);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(276, 26);
            this.tbx_nome.TabIndex = 12;
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = ((System.Drawing.Image)(resources.GetObject("pbx_fecharAba.Image")));
            this.pbx_fecharAba.Location = new System.Drawing.Point(788, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // frm_alterarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.tbx_registro);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.mtx_CEP);
            this.Controls.Add(this.mtx_telefone);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_alterarClientes";
            this.Size = new System.Drawing.Size(831, 592);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtx_CEP;
        private System.Windows.Forms.MaskedTextBox mtx_telefone;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.TextBox tbx_registro;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
    }
}
