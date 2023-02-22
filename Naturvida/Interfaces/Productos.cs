using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Naturvida
{
    public partial class frmProductos : Form
    {
      
       

        public object Rows { get; private set; }

        public frmProductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void texcan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void ingrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIngresar.Visible = true;
            Tabla1.Visible = false;
            panelModific.Visible = false;
            paneliminar.Visible = false;

        }

        private void panelModific_Paint(object sender, PaintEventArgs e)
        {

        }

        private void consultrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIngresar.Visible = false;
            Tabla1.Visible = true;
            panelModific.Visible = false;
            paneliminar.Visible = false;
        }

        private void modificarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIngresar.Visible = false;
            Tabla1.Visible = false;
            panelModific.Visible = true;
            paneliminar.Visible = false;

            var Funciones = new Recursos.ClassFunciones();
            txtProduc.DataSource= Funciones.listarProducto();
            txtProduc.DisplayMember="Nombre_pro,";
            txtProduc.ValueMember="Codigo_pro";
        }

        private void eliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paneIngresar.Visible = false;
            Tabla1.Visible = false;
            panelModific.Visible = false;
            paneliminar.Visible = true;

            var Funciones = new Recursos.ClassFunciones();
            txtProduc.DataSource = Funciones.listarProducto();
            txtProduc.DisplayMember = "Nombre_pro,";
            txtProduc.ValueMember = "Codigo_pro";

          
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            var RegistrarProductos = new Recursos.ClassProducto(
               Convert.ToInt16(texcodi.Text.Trim()),
               TxNombre.Text,
               texdescripcion.Text,
               Convert.ToInt16(texvalor.Text.Trim()),
               textCantidad.Text.Trim()
                 );
            RegistrarProductos.Registrar();
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            texcodi.Clear();
            TxNombre.Clear();
            texdescripcion.Clear();
            txvalor.Clear();
            textCantidad.Clear();
        }


        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            var ConsultarProductos = new Recursos.ClassProducto();
            int Codigo = Convert.ToInt16(txtProduc.SelectedValue.ToString());
            var Tabla = ConsultarProductos.BuscarporCodigo(Codigo);
            var NumeroFilas = Tabla.Rows.Count;
            if(NumeroFilas> 0)
            {
              for ( int i = 0;i < NumeroFilas; i++)
                {
                   
                    String Nombre = Tabla.Rows[i][1].ToString();
                    String Descripcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();

                    texdescripcion.Text = Descripcion;
                    txvalor.Text = Valor;
                    textCantidad.Text = Cantidad;
                    TxNombre.Text=Nombre;



                }



            }



            
        }




        private void texvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void texcodi_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void frmProductos_Load(object sender, EventArgs e)
        {
            var Funciones = new Recursos.ClassFunciones();
            txtProduc.DataSource = Funciones.listarProducto();
            txtProduc.DisplayMember ="Nombre_pro";
        }

        private void Bteliminar_Click(object sender, EventArgs e)
        {
            var EliminarProducto = new Recursos.ClassProducto();
            int Codigo = Convert.ToInt16(comProducto.SelectedValue.ToString());
            EliminarProducto.Eliminar(Codigo);
        }

        
        

        private void cambios_Click(object sender, EventArgs e)
        {

            var ActualizarProducto = new Recursos.ClassProducto(
                Convert.ToInt16(txtProduc.SelectedValue.ToString()),
                txtProduc.Text,
                texdescrip.Text,
                Convert.ToInt16(texvalor.Text.Trim()),
               textCantidad.Text.Trim()

               );
            ActualizarProducto.Actualizar();
        }
       

    }


  }

