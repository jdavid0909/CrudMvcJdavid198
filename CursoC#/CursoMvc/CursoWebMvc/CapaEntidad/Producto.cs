using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }


        public string Description 
            { get; set; }

        public Marca marca { get; set; }

        public Categoria categoria { get; set; }

        public decimal Precio { get; set; }

        public int stock { get; set; }

        public string rutaImagen { get; set; }

        public string nombreImage { get; set; }

        public bool Activo { get; set; }


         }
}
