using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }

        public int idCliente { get; set; }

        public int totalProducto { get; set; }

        public decimal MontoTotal { get; set; }

        public string contacto  { get; set; }

        public string IdDeistritro  { get; set; }

        public string telefono  { get; set; }

        public string dirreccion {  get; set; }

        public string fechaTexto { get; set; }

        public string idtransaccion { get; set; }


        public List<DetalleVenta> detalleVentas { get; set; }



    }
}
