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
    class ClassProducto
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_Conexion"].ConnectionString);

        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion{ get; set; }
        public int Valor { get; set; }
        public String Cantidad { get; set; }
          public ClassProducto(int codigo, string nombre, string descripcion, int Valor, string cantidad)
        {
           this. Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Valor = Valor;
            this.Cantidad = cantidad;
           }

        public ClassProducto()
        {
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarporCodigo(int Codigo)
        {
            var tabla = new DataTable();
            try
            {
               using(var adaptador = new SqlDataAdapter("SP_ConsultarProductos",Connection))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@Codigo",Codigo);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);

                }
              
            }
            catch ( SqlException e){

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

            }

            return tabla;
          }

        public bool Eliminar(int codigo)
        {
            Boolean Estado;
            try
            {
                using (var command = new SqlCommand(" SP_EliminarProductos", Connection))
                {

                    command.Parameters.AddWithValue("@Codigo",Codigo);
                    command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    command.ExecuteNonQuery();
                    Estado = true;
                    System.Windows.Forms.MenssagBox.Show("El articulo se elimino exitosamente");
                    Connection.Close();
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MenssagBox.Show(e.Message);
                Estado = false;
            }

            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }

            }
            return Estado;

        }

        public DataTable listar()
        {
            var tabla =new DataTable();
            try {
                using(var adaptador=new SqlDataAdapter("SP_ListarProductos", Connection))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }

            } catch(SqlException e)
            {
              System.Windows.Forms.MenssagBox.Show(e.Message);

            }
            return tabla;

        }

        public int Registrar()
        {
            int Estado=0;
            try {
                using (var command = new SqlCommand(" SP_RegistrarProductos", Connection)){

                    command.Parameters.AddWithValue("@Codigo", this.Codigo);
                    command.Parameters.AddWithValue("@Nombre", this.Nombre);
                    command.Parameters.AddWithValue("@Descripcion",this.Descripcion);
                    command.Parameters.AddWithValue("@Valor",this.Valor);
                    command.Parameters.AddWithValue("@Cantidad",this.Cantidad);
                    command.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            } catch(SqlException e){
                System.Windows.Forms.MenssagBox.Show(e.Message);
                Estado =1;
            }
            
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                 }

             }
            return Estado;

        }

        public DataTable ListarClientes()
        {
            throw new NotImplementedException();
        }

        public int ConsultarPrecio()
        {
            throw new NotImplementedException();
        }

        public DataTable listarProductos()
        {
            throw new NotImplementedException();
        }
    }
}
