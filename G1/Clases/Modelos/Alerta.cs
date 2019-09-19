using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1.Clases.Modelos
{
    public class Alerta
    {
        public int Id { get; set; }
        public int TipoAlerta { get; set; }
        public string NombreAlerta { get; set; }
        public DateTime FechaAlerta { get; set; }
        public Usuario Usuarios { get; set; }
    }
}
