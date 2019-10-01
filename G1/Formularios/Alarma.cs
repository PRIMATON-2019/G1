using System;
using G1.Clases;
using G1.Clases.Modelos;
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
    public partial class Alarma : Form
    {

        public Alarma()
        {
            InitializeComponent();
            Eventos event1 = new Eventos();
            //String nombre = event1.Detalles.informacion.Nombre;
            DateTime today = DateTime.Now;
            DateTime finishRiego = DateTime.Now;
            DateTime finishPoda = DateTime.Now;
            DateTime finishCocecha = DateTime.Now;

            //Ejemplos de nombres de productos

            if (event1.Detalles.informacion.Nombre == "zanahoria")
            {
                finishRiego = today.AddDays(3);
                finishPoda = today.AddDays(40);
                finishCocecha = today.AddDays(90);
            }
            if (event1.Detalles.informacion.Nombre == "papa")
            {

                finishRiego = today.AddDays(2);
                finishPoda = today.AddDays(54);
                finishCocecha = today.AddDays(105);

            }


            // EJEMPLOS DE CARGA
            for (int i = 0; i < cantidadDeEventos; i++)
            {

                dataGridView1.Rows.Add(event1.Detalles.informacion.Nombre, event1.Alertas[0].getTipeOfAlert(), event1.Fecha, finishRiego);
                dataGridView1.Rows.Add(event1.Detalles.informacion.Nombre, event1.Alertas[1].getTipeOfAlert(), event1.Fecha, finishPoda);
                dataGridView1.Rows.Add(event1.Detalles.informacion.Nombre, event1.Alertas[2].getTipeOfAlert(), event1.Fecha, finishCocecha);
                
            }

        }

        
        private void Bt_atras_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial();
            menu.Show();
            this.Hide();         
        }      
    }
}
