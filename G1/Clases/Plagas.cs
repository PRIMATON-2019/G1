﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Plagas
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public Pesticidas pesticida { get; set; }
    }
}