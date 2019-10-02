using G1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Form_Cultivos : Form
    {
        public Form_Cultivos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] columnas = { "Nombre", "TipoCultivo", "Familia", "Subfamilia", "Genero" };

            Persistencia pd = new Persistencia(5, columnas, "cultivos");
            string[] datos = {
                "NombreCultivo",
                "TipoCultivo",
                "Familia",
                "Subfamilia",
                "Genero"
            };
            pd.CargaDatos(datos, 5, columnas);
        }

    }
}
