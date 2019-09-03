using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1.Clases.Modelos
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        // El tipo estaria dado por un indice, ej: 1- Arbol / 2 - Semilla / 3 - Fruto
        public int TipoProducto { get; set; }
        public string Descripcion { get; set; }

    }
}
