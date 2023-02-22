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
    class ClassFactura
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente { get; set; }
        public  int ValorTotal { get; set; }
        public int Vendedor { get; set; }
        public int UltimaFactura { get; set; }

        public ClassFactura(DateTime fecha,int cliente, int valorTotal, int vendedor)
        {
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.ValorTotal = valorTotal;
            this.Vendedor = vendedor;
          }
        public int Registrar()
        {
          
            try

            {
                using (var Command = new SqlCommand("SP_RegistrarFactura", Connection))
                {
                    Command.Parameters.AddWithValue("@Fecha", this.Fecha);
                    Command.Parameters.AddWithValue("@Cliente", this.Cliente);
                    Command.Parameters.AddWithValue("@ValorTotal", this.ValorTotal);
                    Command.Parameters.AddWithValue("@Vendedor", this.Vendedor);
                    Command.Parameters.Add("@UltimaFactura", SqlDbType.Int).Direction = ParameterDirection.Output;
                    Command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    Command.ExecuteNonQuery();
                    UltimaFactura = Convert.ToInt32(Command.Parameters["@UltimaFactura"].Value.ToString());
                    Connection.Close();
                }


            } catch (SqlException e){
                System.Windows.Forms.MessageBox.Show(e.Message);
                return UltimaFactura;

            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();

                }
              

            }
            return UltimaFactura;



        }


        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable listar()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarporCodigo(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarClientes()
        {
            throw new NotImplementedException();
        }

        public int ConsultarPrecio()
        {
            throw new NotImplementedException();
        }

        public DataTable listarProducto()
        {
            throw new NotImplementedException();
        }
    }
}
