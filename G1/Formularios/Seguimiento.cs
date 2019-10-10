using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Seguimiento : Form
    {

        string riego;
        string raleo;
        string fertilizacion;
        string cosecha;
        public Seguimiento()
        {
            InitializeComponent();
        }

        private void BtnAgregarEvento_Click(object sender, EventArgs e)
        {
            Persistencia per = new Persistencia();
            DataTable dtCultivos = per.BuscarDatos("cultivos");
            try
            {
                for (int j = 0; j < dtCultivos.Rows.Count; j++)
                {
                    if (dtCultivos.Rows[j][0].ToString().Equals(cbTipoCultivo.Text))
                    {
                        riego = dtCultivos.Rows[j][2].ToString();
                        raleo = dtCultivos.Rows[j][3].ToString();
                        fertilizacion = dtCultivos.Rows[j][4].ToString();
                        cosecha = dtCultivos.Rows[j][5].ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se recuperaron los datos del cultivo seleccionado");
            }

            string[] columnas = { "Fecha", "TipoCultivo", "Responsable", "TipoEvento", "Riego", "Raleo", "Fertilización", "Cosecha" };

            Persistencia pd = new Persistencia(8, columnas, "eventos");
            string[] datos = {
                dtpFechaEvento.Value.ToString(),
                cbTipoCultivo.Text,
                cbUsuarios.Text,
                "Siembra", 
                riego,
                raleo,
                fertilizacion,
                cosecha
            };

            pd.CargaDatos(datos, 8, columnas);


            if (cbAlarmas.Checked)
            {

                string[] columnas2 = { "TipoCultivo", "NombreAlerta", "FechaAlerta", "FinAlerta" };
                Persistencia pd2 = new Persistencia(4, columnas2, "alertas");
                DateTime DateRiego = new DateTime();
                DateTime DateRaleo = new DateTime();
                DateTime DateSiembra = new DateTime();
                DateTime DateFertilizacion = new DateTime();
                DateRiego = dtpFechaEvento.Value.AddDays(Convert.ToInt32(riego));
                DateRaleo = dtpFechaEvento.Value.AddDays(Convert.ToInt32(raleo));
                DateFertilizacion = dtpFechaEvento.Value.AddDays(Convert.ToInt32(fertilizacion));
                DateSiembra = dtpFechaEvento.Value.AddDays(Convert.ToInt32(cosecha));

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
                    "Cosecha",
                    dtpFechaEvento.Value.ToString(),
                    DateSiembra.ToString(),
                };

                pd2.CargaDatos(alarma1, 4, columnas2);
                pd2.CargaDatos(alarma2, 4, columnas2);
                pd2.CargaDatos(alarma3, 4, columnas2);

                MessageBox.Show("Se generaron las alarmas correspondientes");
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
                            dsTiposCultivos.Rows[j][3].ToString(),
                            dsTiposCultivos.Rows[j][4].ToString(),
                            dsTiposCultivos.Rows[j][5].ToString(),
                            dsTiposCultivos.Rows[j][6].ToString(),
                            dsTiposCultivos.Rows[j][7].ToString()
                          );
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No se pueden generar eventos sin antes cargar Cultivos");             
            }
        }
    }
}