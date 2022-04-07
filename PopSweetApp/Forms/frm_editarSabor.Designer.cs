
namespace PopSweetApp
{
    partial class frm_editarSabor
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
            this.cbx_selecaoSabor = new System.Windows.Forms.ComboBox();
            this.lbl_selecioneSabor = new System.Windows.Forms.Label();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.pbx_fecharAba = new System.Windows.Forms.PictureBox();
            this.popSweetDataSet = new PopSweetApp.PopSweetDataSet();
            this.saboresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saboresTableAdapter = new PopSweetApp.PopSweetDataSetTableAdapters.SaboresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saboresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_selecaoSabor
            // 
            this.cbx_selecaoSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_selecaoSabor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_selecaoSabor.FormattingEnabled = true;
            this.cbx_selecaoSabor.Location = new System.Drawing.Point(67, 86);
            this.cbx_selecaoSabor.Name = "cbx_selecaoSabor";
            this.cbx_selecaoSabor.Size = new System.Drawing.Size(253, 26);
            this.cbx_selecaoSabor.TabIndex = 0;
            this.cbx_selecaoSabor.DropDown += new System.EventHandler(this.cbx_selecaoSabor_DropDown);
            // 
            // lbl_selecioneSabor
            // 
            this.lbl_selecioneSabor.AutoSize = true;
            this.lbl_selecioneSabor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecioneSabor.Location = new System.Drawing.Point(63, 64);
            this.lbl_selecioneSabor.Name = "lbl_selecioneSabor";
            this.lbl_selecioneSabor.Size = new System.Drawing.Size(146, 19);
            this.lbl_selecioneSabor.TabIndex = 1;
            this.lbl_selecioneSabor.Text = "Selecione o sabor";
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(67, 166);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(105, 47);
            this.bt_excluir.TabIndex = 7;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // pbx_fecharAba
            // 
            this.pbx_fecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_fecharAba.Image = global::PopSweetApp.Properties.Resources.fechar_aba;
            this.pbx_fecharAba.Location = new System.Drawing.Point(1084, 3);
            this.pbx_fecharAba.Name = "pbx_fecharAba";
            this.pbx_fecharAba.Size = new System.Drawing.Size(40, 40);
            this.pbx_fecharAba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_fecharAba.TabIndex = 23;
            this.pbx_fecharAba.TabStop = false;
            this.pbx_fecharAba.Click += new System.EventHandler(this.pbx_fecharAba_Click);
            // 
            // popSweetDataSet
            // 
            this.popSweetDataSet.DataSetName = "PopSweetDataSet";
            this.popSweetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saboresBindingSource
            // 
            this.saboresBindingSource.DataMember = "Sabores";
            this.saboresBindingSource.DataSource = this.popSweetDataSet;
            // 
            // saboresTableAdapter
            // 
            this.saboresTableAdapter.ClearBeforeFill = true;
            // 
            // frm_editarSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_fecharAba);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.lbl_selecioneSabor);
            this.Controls.Add(this.cbx_selecaoSabor);
            this.Name = "frm_editarSabor";
            this.Size = new System.Drawing.Size(1127, 759);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fecharAba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSweetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saboresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_selecaoSabor;
        private System.Windows.Forms.Label lbl_selecioneSabor;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.PictureBox pbx_fecharAba;
        private System.Windows.Forms.BindingSource saboresBindingSource;
        private PopSweetDataSet popSweetDataSet;
        private PopSweetDataSetTableAdapters.SaboresTableAdapter saboresTableAdapter;
    }
}
