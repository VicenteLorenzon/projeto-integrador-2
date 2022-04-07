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
    public partial class frm_rTodasVendas : Form {
        public frm_rTodasVendas() {
            InitializeComponent();
        }

        private void frm_rTodasVendas_Load(object sender, EventArgs e) {
            try {
                this.VendasTableAdapter.Fill(this.PopSweetDataSet.Vendas);
            }
            catch { }

        }
    }
}
