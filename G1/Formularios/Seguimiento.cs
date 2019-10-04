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

        private void BtnAgregarEvento_Click(object sender, EventArgs e)
        {
            string[] columnas = { "Fecha", "TipoCultivo", "Responsable", "TipoEvento" };

            Persistencia pd = new Persistencia(4, columnas, "eventos");
            string[] datos = {
                dtpFechaEvento.Value.ToString(),
                cbTipoCultivo.Text,
                cbUsuarios.Text,
                cbTipoEvento.Text
            };
            pd.CargaDatos(datos, 4, columnas);


            if (cbAlarmas.Checked)
            {
                string[] columnas2 = {"TipoCultivo" , "Nombre de alerta", "Fecha alerta","Fin alerta"};
                Persistencia pd2 = new Persistencia(4, columnas2, "alertas");
                DateTime DateRiego = new DateTime();
                DateTime DateRaleo = new DateTime();
                DateTime DateSiembra = new DateTime();
                DateRiego = DateTime.Now.AddDays(3);
                DateRaleo = dtpFechaEvento.Value.AddDays(43);
                DateSiembra = dtpFechaEvento.Value.AddDays(90);

                string[] alarma1 =
                {
                    cbTipoCultivo.Text,
                    "Riego",
                    dtpFechaEvento.Value.ToString(),
                    DateRiego.ToString(),
                };
                string[] alarma2 =
{
                    cbTipoCultivo.Text,
                    "Raleo",
                    dtpFechaEvento.Value.ToString(),
                    DateRaleo.ToString(),
                };
                string[] alarma3 =
{
                    cbTipoCultivo.Text,
                    "Siembra",
                    dtpFechaEvento.Value.ToString(),
                    DateSiembra.ToString(),
                };

                pd2.CargaDatos(alarma1, 4, columnas2);
                pd2.CargaDatos(alarma2, 4, columnas2);
                pd2.CargaDatos(alarma3, 4, columnas2);

                MessageBox.Show("Se generaron las alarmas correspondientes");
                //TODO: Agregar alarmas correspondientes.
            }
            ListarEventos();


        }

        private void Seguimiento_Load(object sender, EventArgs e)
        {
            ListarEventos();
            Persistencia pd = new Persistencia();
            DataTable ds = pd.BuscarDatos("usuarios");
            cbUsuarios.Items.Clear();
            if (ds != null)
            {
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    cbUsuarios.Items.Add(ds.Rows[j][1].ToString() + ", " + ds.Rows[j][2]);
                }
            }
            Persistencia pdCultivos = new Persistencia();
            DataTable dsCultivos = pdCultivos.BuscarDatos("eventos");
            cbUsuarios.Items.Clear();
            if (dsCultivos != null)
            {
                for (int j = 0; j < dsCultivos.Rows.Count; j++)
                {
                    cbUsuarios.Items.Add(dsCultivos.Rows[j][1].ToString() + ", " + dsCultivos.Rows[j][2]);
                }
            }
            Persistencia persist = new Persistencia();
            DataTable dsTiposCultivos = persist.BuscarDatos("cultivos");
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

        public void ListarEventos()
        {
            Persistencia pd = new Persistencia();
            DataTable dsTiposCultivos = pd.BuscarDatos("eventos");
            try
            {
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
            catch (Exception)
            {
                // MessageBox.Show("No se pueden generar eventos sin antes cargar Cultivos");             
            }
        }
    }
}