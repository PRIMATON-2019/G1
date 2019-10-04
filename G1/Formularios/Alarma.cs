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
            ListarAlertas();
        }

        private void Bt_atras_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial();
            menu.Show();
            this.Hide();
        }

        private void Alarma_Load(object sender, EventArgs e)
        {

        }


        public void ListarAlertas()
        {
            Persistencia pd = new Persistencia();
            DataTable dsTiposAlarmas = pd.BuscarDatos("alertas");
            try
            {
                dataGridView1.RowCount = 1;
                for (int j = 0; j < dsTiposAlarmas.Rows.Count; j++)
                {
                    dataGridView1.Rows.Add(

                            dsTiposAlarmas.Rows[j][0].ToString(),
                            dsTiposAlarmas.Rows[j][1].ToString(),
                            dsTiposAlarmas.Rows[j][2].ToString(),
                            dsTiposAlarmas.Rows[j][3].ToString()
                          );
                }
            }
            catch (Exception)
            {
                 MessageBox.Show("No se pudieron generar las alertas");             
            }

	}

    }
    }


            
        

