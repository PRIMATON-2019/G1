using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Alarma : Form
    {
        public Alarma()
        {
            InitializeComponent();
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
                            dsTiposAlarmas.Rows[j][3].ToString(),
                            false
                          );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron generar las alertas");
            }
        }

        private void ActualizaAlarma_Click(object sender, EventArgs e)
        {
            AlarmasViejas();
        }

        public void AlarmasViejas()
        {

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool check = (bool)dataGridView1.Rows[i].Cells[4].Value;

                if (check == true)
                {
                    string[] alarmaVieja = {
                        dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        dataGridView1.Rows[i].Cells[3].Value.ToString() };

                        dataGridView2.Rows.Add(alarmaVieja);
                        dataGridView1.Rows.RemoveAt(i);

                    string[] columnas2 = { "TipoCultivo", "NombreAlerta", "FechaAlerta", "FinAlerta" };
                    Persistencia pdviejo = new Persistencia(4, columnas2, "alertasViejas");
                    pdviejo.CargaDatos(alarmaVieja, 4, columnas2);
                    Persistencia pd = new Persistencia("alertas");
                    DataTable borraAlarma = pd.BuscarDatos("alertas");
                    borraAlarma.Rows.RemoveAt(i);
                    pd.GrabarArchivo();
                }
            }

        }

        private void Bt_atras_Click_1(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial();
            menu.Show();
            this.Hide();
        }

        private void BtnAgregarAlarma_Click(object sender, EventArgs e)
        {
            DateTime ahora = new DateTime();
            ahora = DateTime.Now;
            string[] columnas2 = { "TipoCultivo", "NombreAlerta", "FechaAlerta", "FinAlerta" };
            Persistencia pd2 = new Persistencia(4, columnas2, "alertas");
            DateTime despues = new DateTime();
            int cantidad = int.Parse(textBoxDias.Text);
            despues = DateTime.Now.AddDays(cantidad);
            string[] alarmanueva =
                {
                    comboBoxCultivo.SelectedItem.ToString(),
                    comboBoxAlarma.SelectedItem.ToString(),
                    ahora.ToString(),
                    despues.ToString()
                };
            pd2.CargaDatos(alarmanueva, 4, columnas2);
            ListarAlertas();
        }

        private void Alarma_Load(object sender, EventArgs e)
        {
            ListarAlertas();

            Persistencia pd2 = new Persistencia();
            DataTable tableAlarmasViejas = pd2.BuscarDatos("alertasViejas");          
                dataGridView2.RowCount = 1;
            if (tableAlarmasViejas != null)
            {


                for (int j = 0; j < tableAlarmasViejas.Rows.Count; j++)
                {
                    dataGridView2.Rows.Add(

                            tableAlarmasViejas.Rows[j][0].ToString(),
                            tableAlarmasViejas.Rows[j][1].ToString(),
                            tableAlarmasViejas.Rows[j][2].ToString(),
                            tableAlarmasViejas.Rows[j][3].ToString()
                          );
                }
            }

            Persistencia pd = new Persistencia();
            DataTable ds = pd.BuscarDatos("cultivos");
            comboBoxCultivo.Items.Clear();
            if (ds != null)
            {
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    comboBoxCultivo.Items.Add(ds.Rows[j][0].ToString());
                }
            }
        }
    }
}





