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
            // EJEMPLOS DE CARGA
            dataGridView1.Rows.Add("a", "poda", DateTime.Now, DateTime.Now);
            dataGridView1.Rows.Add("b", "poda1", DateTime.Now, DateTime.Now);
        }

        
        private void Bt_atras_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial();
            menu.Show();
            this.Hide();         
        }      
    }
}
