using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naturvida
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.ShowDialog();
        }

        private void tlMenu_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
