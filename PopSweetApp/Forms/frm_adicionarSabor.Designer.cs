
namespace PopSweetApp
{
    partial class frm_adicionarSabor
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_sabor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(65, 65);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_sabor
            // 
            this.tbx_sabor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sabor.Location = new System.Drawing.Point(68, 101);
            this.tbx_sabor.Name = "tbx_sabor";
            this.tbx_sabor.Size = new System.Drawing.Size(261, 26);
            this.tbx_sabor.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1160, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // frm_adicionarSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.tbx_sabor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nome);
            this.Name = "frm_adicionarSabor";
            this.Size = new System.Drawing.Size(1203, 838);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_sabor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
    }
}
