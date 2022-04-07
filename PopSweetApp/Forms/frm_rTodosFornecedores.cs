using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopSweetApp {
    public partial class frm_rTodosFornecedores : Form {
        public frm_rTodosFornecedores() {
            InitializeComponent();
        }

        private void frm_rTodosFornecedores_Load(object sender, EventArgs e) {
            try {
                this.FornecedoresTableAdapter.Fill(this.PopSweetDataSet.Fornecedores);
            }
            catch { }

            this.reportViewer1.RefreshReport();
        }
    }
}
