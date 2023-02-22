using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naturvida.Recursos
{
    class ClassFunciones
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);
        public DataTable listarProducto()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("Select Codigo_pro,Nombre_pro, from Tb_productos", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }

            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            return tabla;

        }
        public DataTable listarVendedores()
        {
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("Select id_ven,Usuarioven from Tb_Vendedores", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }

            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            return tabla;

        }
        public DataTable ListarClientes()
        {
            var tabla = new DataTable();
            try {
                using (var adaptador = new SqlDataAdapter("select id_cliente,Nombre_cli from Tb_Clientes", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);



                }
            } catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            return tabla;

        }

        public int ConsultarPrecio(int Codigo)
        {
            int precio = 0;
            var tabla = new DataTable();
            try
            {
                using (var adaptador = new SqlDataAdapter("select valor_pro, from Tb_Productos where Codigo_pro", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                    precio = Convert.ToInt16(tabla.Rows[0][0]);


                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            return precio;

        }


    }



    }


    

