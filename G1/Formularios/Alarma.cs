using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Alarma : Form
    {
        Boolean bandera = false;
        public Alarma()
        {
            InitializeComponent();
            ListarAlertas();
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
            Persistencia pd2 = new Persistencia();
            DataTable tableAlarmasViejas = pd2.BuscarDatos("alertasViejas");
            try
            {
                dataGridView2.RowCount = 1;
                for (int j = 0; j < dsTiposAlarmas.Rows.Count; j++)
                {
                    dataGridView2.Rows.Add(

                            tableAlarmasViejas.Rows[j][0].ToString(),
                            tableAlarmasViejas.Rows[j][1].ToString(),
                            tableAlarmasViejas.Rows[j][2].ToString(),
                            tableAlarmasViejas.Rows[j][3].ToString()
                          );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay alarmas viejas");
            }


        }

        private void ActualizaAlarma_Click(object sender, EventArgs e)
        {
            AlarmasViejas();
            bandera = true;

        }

        public void AlarmasViejas()
        {

            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool check = (bool)dataGridView1.Rows[i].Cells[4].Value;

                if (check == true)
                {
                    string[] alarmaVieja = {dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    dataGridView1.Rows[i].Cells[3].Value.ToString() };
                    string[] columnas2 = { "TipoCultivo", "NombreAlerta", "FechaAlerta", "FinAlerta" };
                    Persistencia pdviejo = new Persistencia(4, columnas2,"alertasViejas");
                    pdviejo.CargaDatos(alarmaVieja, 4, columnas2);
                    Persistencia pd = new Persistencia();
                    DataTable dsTiposAlarmasVieja = pd.BuscarDatos("alertasViejas");
                    try
                    {
                        //dataGridView1.RowCount = 1;
                        for (int j = 0; j < dsTiposAlarmasVieja.Rows.Count; j++)
                        {
                            dataGridView2.Rows.Add(

                                    dsTiposAlarmasVieja.Rows[j][0].ToString(),
                                    dsTiposAlarmasVieja.Rows[j][1].ToString(),
                                    dsTiposAlarmasVieja.Rows[j][2].ToString(),
                                    dsTiposAlarmasVieja.Rows[j][3].ToString()
                                  );
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No hay alarmas viejas");
                    }
                    DataTable borraAlarma = pd.BuscarDatos("alertas");
                    borraAlarma.Rows.RemoveAt(i);
                    dataGridView1.Rows.RemoveAt(i);
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
            Seguimiento seg = new Seguimiento();
            string[] columnas2 = { "TipoCultivo", "NombreAlerta", "FechaAlerta", "FinAlerta" };
            Persistencia pd2 = new Persistencia(4, columnas2, "alertas");
            Persistencia pd3 = new Persistencia();
            DataTable dtCultivos = pd3.BuscarDatos("cultivos");

            //cantidad de dias para agregarle a la alarma segun corresponda
            int cantidad = CantidadDias(EncuentraCultivo(comboBoxCultivo.SelectedItem.ToString(),dtCultivos),dtCultivos, comboBoxAlarma.SelectedItem.ToString());

            DateTime despues = new DateTime();
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

        //Busca en el xml de cultivo el nombre del cultivo y retorna la pocision para ser usada en otro metodo

        private int EncuentraCultivo(string nombre, DataTable tabla)
        {
            int num = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (nombre.Equals(tabla.Rows[i][0]))
                {
                    num = i;
                }
            }
            return num;
        }

        // Busca en el xml de cultivos la cantidad de dias segun el tipo de alerta elegido

        private int CantidadDias(int num, DataTable tabla, string Tipoalerta)
        {
            int num2 = lugarTabla(tabla, Tipoalerta);
            String pepe = tabla.Rows[num][num2].ToString();
            int dias = int.Parse(pepe);
            return dias;
        }

        //Busca en el xml de cultivos la pocision del tipo de alerta "raleo" , "riego, "cocecha", "siembra",
        //para luego ser usada para obtener la cantidad de dias
        //para mi el error esta aca ya que creo que no estoy buscando en los nombres de las columnas sino
        //adentro de la misma tabla

        private int lugarTabla(DataTable tabla, string Tipoalerta)
        {
            int lugar = 0;
            if (tabla.Rows[0][3].ToString().Equals(Tipoalerta))
            {
                lugar = 3;
                return lugar;
            }
            if (tabla.Rows[0][4].ToString().Equals(Tipoalerta))
            {
                lugar = 4;
                return lugar;
            }
            if (tabla.Rows[0][5].ToString().Equals(Tipoalerta))
            {
                lugar = 5;
                return lugar;
            }
                return lugar;
        }
    }
}





