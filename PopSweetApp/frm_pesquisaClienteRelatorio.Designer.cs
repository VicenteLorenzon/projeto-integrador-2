
namespace PopSweetApp {
    partial class frm_pesquisaClienteRelatorio {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbx_pesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_pesquisa
            // 
            this.tbx_pesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_pesquisa.Location = new System.Drawing.Point(138, 42);
            this.tbx_pesquisa.Name = "tbx_pesquisa";
            this.tbx_pesquisa.Size = new System.Drawing.Size(60, 29);
            this.tbx_pesquisa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro do cliente:";
            // 
            // frm_pesquisaClienteRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_pesquisa);
            this.Name = "frm_pesquisaClienteRelatorio";
            this.Text = "Seleção de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}