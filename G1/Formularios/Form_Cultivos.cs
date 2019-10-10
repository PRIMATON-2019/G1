﻿using G1.Clases;
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

        private void BtnAgregarEvento_Click(object sender, EventArgs e)
        {
            string[] columnas = {
                "Nombre",
                "TipoCultivo",
                "Riego",
                "Raleo",
                "Fertilizacion",
                "Cosecha",
                "Observaciones"
            };

            Persistencia pd = new Persistencia(7, columnas, "cultivos");
            string[] datos = {
                txtNombre.Text,
                comboBox1.Text,
                txtRiego.Text,
                txtRaleo.Text,
                txtFertilizo.Text,
                txtCosecho.Text,
                txtDescripción.Text
            };
            pd.CargaDatos(datos, 7, columnas);
        }
    }
}
