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
    public partial class frm_rTodasEntradas : Form {
        public frm_rTodasEntradas() {
            InitializeComponent();
        }

        private void frm_rTodasEntradas_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'PopSweetDataSet.Entradas' table. You can move, or remove it, as needed.
            this.EntradasTableAdapter.Fill(this.PopSweetDataSet.Entradas);

        }
    }
}
