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
            MessageBox.Show("Cultivo agregado");
            ListarEventos();
        }

        private void Form_Cultivos_Load(object sender, EventArgs e)
        {
            ListarEventos();
        }

        public void ListarEventos()
        {
            Persistencia pd = new Persistencia();
            DataTable dsTiposCultivos = pd.BuscarDatos("cultivos");
            try
            {
                dataGridView1.RowCount = 1;
                for (int j = 0; j < dsTiposCultivos.Rows.Count; j++)
                {
                    dataGridView1.Rows.Add(

                            dsTiposCultivos.Rows[j][0].ToString(),
                            dsTiposCultivos.Rows[j][1].ToString(),
                            dsTiposCultivos.Rows[j][2].ToString(),
                            dsTiposCultivos.Rows[j][3].ToString(),
                            dsTiposCultivos.Rows[j][4].ToString(),
                            dsTiposCultivos.Rows[j][5].ToString()
                          );
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fin de arreglo");
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
