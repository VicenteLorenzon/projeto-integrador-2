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
    public partial class frm_rTodosClientes : Form {
        public frm_rTodosClientes() {
            InitializeComponent();
        }

        private void frm_rTodosClientes_Load(object sender, EventArgs e) {
            try {
            this.ClientesTableAdapter.Fill(this.PopSweetDataSet.Clientes);
            }
            catch { }

        }
    }
}
