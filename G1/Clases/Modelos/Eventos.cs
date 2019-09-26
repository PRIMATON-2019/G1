using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1.Clases.Modelos
{
    public class Eventos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Responsable { get; set; }
        public DetalleEventos Detalles { get; set; }
    }
}
