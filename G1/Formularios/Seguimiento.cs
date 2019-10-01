using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Seguimiento : Form
    {
        public Seguimiento()
        {
            InitializeComponent();
        }

        private void BtnNuevoEvento_Click(object sender, EventArgs e)
        {
            cbUsuarios.Enabled = true;
            cbTipoCultivo.Enabled = true;
            cbTipoEvento.Enabled = true;
            dtpFechaEvento.Enabled = true;


            Persistencia pd = new Persistencia();
            DataTable ds = pd.BuscarDatos("Usuarios");
            DataTable dsTiposCultivos = pd.BuscarDatos("Cultivos");
            cbUsuarios.Items.Clear();
            if (ds != null)
            {
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    cbUsuarios.Items.Add(ds.Rows[j][1].ToString() + ", " + ds.Rows[j][2]);
                }
            }
            if (dsTiposCultivos != null)
            {
                cbTipoCultivo.Items.Clear();
                for (int j = 0; j < dsTiposCultivos.Rows.Count; j++)
                {
                    cbTipoCultivo.Items.Add(
                        dsTiposCultivos.Rows[j][0].ToString()
                      );
                }
            }
        }

        private void BtnAgregarEvento_Click(object sender, EventArgs e)
        {
            string[] columnas = { "TipoEvento", "Fecha", "TipoCultivo", "Responsable" };

            Persistencia pd = new Persistencia(4, columnas, "cultivos");
            string[] datos = {cbTipoEvento.Text,
                dtpFechaEvento.Value.ToString(),
                cbTipoCultivo.Text,
                cbUsuarios.Text
            };
            pd.CargaDatos(datos, 4, columnas);

            cbUsuarios.Enabled = false;
            cbTipoCultivo.Enabled = false;
            cbTipoEvento.Enabled = false;
            dtpFechaEvento.Enabled = false;
            ListarEventos();
            if (cbAlarmas.Checked)
            {
                MessageBox.Show ("Se generaron las alarmas correspondientes");
                //TODO: Agregar alarmas correspondientes.
            }


        }

        private void Seguimiento_Load(object sender, EventArgs e)
        {
            ListarEventos();

        }

        public void ListarEventos()
        {
            Persistencia pd = new Persistencia();
            //DataTable ds = pd.BuscarDatos("Usuarios");
            DataTable dsTiposCultivos = pd.BuscarDatos("Cultivos");
            // cbUsuarios.Items.Clear();

            dataGridView1.RowCount = 1; 
            for (int j = 0; j < dsTiposCultivos.Rows.Count; j++)
            {
                dataGridView1.Rows.Add(

                        dsTiposCultivos.Rows[j][0].ToString(),
                        dsTiposCultivos.Rows[j][1].ToString(),
                        dsTiposCultivos.Rows[j][2].ToString(),
                        dsTiposCultivos.Rows[j][3].ToString()
                      );
            }
        }
    }
}