﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Carrito
    {

        public int IdCarrito { get; set; }

        public Cliente Cliente { get; set; }

        public Producto producto { get; set; }  

        public int cantidad { get; set; }   

    }
}
