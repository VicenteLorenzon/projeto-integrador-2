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
    public partial class frm_pesquisaClienteRelatorio : Form {
        public frm_pesquisaClienteRelatorio() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            frm_rHistoricoCliente r = new frm_rHistoricoCliente(Convert.ToInt32(tbx_pesquisa.Text));
            r.Show();
            this.Close();
        }
    }
}
