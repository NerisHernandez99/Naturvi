using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naturvida.Recursos
{
    interface InFunciones
    {
        bool Registrar();
        bool Actualizar();
        bool Eliminar(int id);
         DataTable listar();
        DataTable BuscarporCodigo(int id);
        DataTable ListarClientes();
        int ConsultarPrecio();
        DataTable listarProductos();
    }
}
