using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {

        public int idCliente {  get; set; }

        public string nombres { get; set; }

        public string apellidos { get; set; }

        public string correo { get; set; }

        public string clave { get; set; }

        public bool reestablecer {  get; set; }

    }
}
