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

    public partial class frm_rHistoricoCliente : Form {

        int registro = 0;
        public frm_rHistoricoCliente(int reg) {
            InitializeComponent();
            registro = reg;
        }

        private void frm_rHistoricoCliente_Load(object sender, EventArgs e) {
            try {
                this.VendasTableAdapter.Fill(this.PopSweetDataSet.Vendas);
                this.VendasBindingSource.Filter = "Registro = " + registro.ToString();
            }
            catch { }
            this.reportViewer1.RefreshReport();

        }
    }
}
