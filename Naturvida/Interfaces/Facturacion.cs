using System;
using System.Linq;
using System.Windows.Forms;

namespace Naturvida
{
    public partial class Factura : Form
    {
        public object dgvFacturaDetalle { get; private set; }
        public object Rows { get; private set; }
        public Factura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            txtCantida.Text = "1";
            var Funciones = new Recursos.ClassFunciones();
            txtCliente.DataSource = Funciones.ListarClientes();
            txtCliente.DisplayMember = "Nombre_cli";
            txtCliente.ValueMember = "id_Cliente";

            txtVendedor.DataSource = Funciones.ListarClientes();
            txtVendedor.DisplayMember = "Idven";
            txtVendedor.ValueMember = "Usuarioven";

            txtArticulo.DataSource = Funciones.listarProducto();
            txtCliente.DisplayMember = "Nombre_pro";
            txtCliente.ValueMember = "Codigo_pro";
        }
        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            var Funciones = new Recursos.ClassFunciones();
            int Codigo = Convert.ToInt16(txarticulo.SelectedValue.ToString());
            String Articulo = txarticulo.Text;
            String Cantidad = txcantidad.Text;
            int valor = Funciones.ConsultarPrecio(Codigo); ;
            dgvFacturaDetalle.Rows.Add(Codigo, Articulo, Cantidad, valor);
            int NumeroFilas = dgvFacturaDetalle.Rows.Count;
            int ValorTotal = 0;

            if (NumeroFilas > 1)
            {
                for (int i = 0; i < (NumeroFilas - 1); i++)
                {
                    int Cant = Convert.ToInt16(dgvFacturaDetalle.Rows[i].cells[2].value.ToString());
                    int Val = Convert.ToInt16(dgvFacturaDetalle.Rows[i].Cells[3].value.toString());
                    ValorTotal = 0;
                }
                texTotalFac.Text = ValorTotal.ToString();
            }
            else
            {
                texTotalFac.Text = valor.ToString();
            }
        }
        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butTerminarFac_Click(object sender, EventArgs e)
        {

            int NumeroFila = dgvFacturaDetalle.Rows.count;
            DateTime date = txFecha.Value;
            int Cliente = Convert.ToInt16(txclient.SelectedValue.ToString());
            int Vendedor = Convert.ToInt16(txtVendedor.SelectedValue.ToString());
            int ValorToTal = Convert.ToInt16(texTotalFac.Text.ToString());
            var RegistrarFactura = new Recursos.ClassFactura(date, Cliente, ValorToTal,Vendedor);
            int UltimaFactura = RegistrarFactura.Registrar();
            for (int i = 0; i < (NumeroFila - 1); i++)
            {
                int Articulo = Convert.ToInt16(dgvFacturaDetalle.Rows[i].cells[0].value.ToString());
                int Cantidad = Convert.ToInt16(dgvFacturaDetalle.Rows[i].cells[2].value.ToString());
                var AgregarProducto = new Recursos.ClassFacturaDetalle(UltimaFactura, Articulo, Cantidad);


            }
            System.Windows.Forms.MessageBox.Show("La factura se registro exitosamente");
        }





    }


}




     




