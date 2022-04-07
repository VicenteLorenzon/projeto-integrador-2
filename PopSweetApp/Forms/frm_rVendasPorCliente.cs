using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PopSweetApp {
    public partial class frm_rVendasPorCliente : Form {
        public frm_rVendasPorCliente() {
            InitializeComponent();
        }

        private void frm_verRelatorios_Load(object sender, EventArgs e) {

            try {
                this.VendasPorClienteTableAdapter.Fill(this.PopSweetDataSet.VendasPorCliente);
            }

            catch { }

            this.reportViewer1.RefreshReport();
        }
    }
}
