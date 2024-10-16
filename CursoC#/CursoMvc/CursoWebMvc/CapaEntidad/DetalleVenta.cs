using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {

        public int IdDetalleVenta { get; set; }

        public int idVenta { get; set; }

        public Producto producto { get; set; }

        public int cantidad { get; set; }

        public decimal total { get; set; }

        public string idtransaccion { get; set; }



    }
}
