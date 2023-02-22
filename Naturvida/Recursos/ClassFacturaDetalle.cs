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
    class ClassFacturaDetalle
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);
        public int Numero{get; set;}
        public int Producto { get; set; }
        public int Cantidad { get; set; }

        public ClassFacturaDetalle(int numero, int producto, int cantidad)
        {
            this.Numero = numero;
            this.Producto = producto;
            this.Cantidad = cantidad;
        }

        public bool Registrar()
        {
            bool i =false;
            try{
                using (var Command = new SqlCommand("SP_RegistrarFacturaDetalles", Connection))
                {
                    Command.Parameters.AddWithValue("@Numero",this.Numero);
                    Command.Parameters.AddWithValue("@Producto",this.Producto);
                    Command.Parameters.AddWithValue("@Cantidad",this.Cantidad);
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                    i = true;
                }
            } catch (SqlException e){

                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
               if (Connection.State==ConnectionState.Open)
                {
                    Connection.Close();

                }

               

            }

            return false;

        }













    }
}
