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
    public partial class Principal : Form
    {
        String usuario = "Misael";
        String contraseña = "45678";

        public Principal()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if(texuser.Text==usuario && texpasswor.Text == contraseña){
                Alerta.Visible = false;
                frmMenu Menu = new frmMenu();
                Menu.ShowDialog();
            }
            else
            {
                Alerta.Visible = true;
            }
        }

        private void texuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
