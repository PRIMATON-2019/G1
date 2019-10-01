using G1.Clases;
using G1.Clases.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Form_Seguimiento : Form
    {
        public Form_Seguimiento()
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
            Alerta[] alertas = new Alerta[2];
            Usuario user = new Usuario();
            

            alertas[0].Id = 1;
            alertas[0].NombreAlerta = "Riego";
            alertas[0].TipoAlerta = 1;
            alertas[0].FechaAlerta = DateTime.Now;
            alertas[0].Usuarios = user;

            alertas[1].Id = 2;
            alertas[1].NombreAlerta = "Poda";
            alertas[1].TipoAlerta = 2;
            alertas[1].FechaAlerta = DateTime.Now;
            alertas[1].Usuarios = user;

            alertas[2].Id = 3;
            alertas[2].NombreAlerta = "Cocecha";
            alertas[2].TipoAlerta = 3;
            alertas[2].FechaAlerta = DateTime.Now;
            alertas[2].Usuarios = user;


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
            Form_Seguimiento_Load(sender, e);



        }

        private void Form_Seguimiento_Load(object sender, EventArgs e)
        {
            Persistencia pd = new Persistencia();
            //DataTable ds = pd.BuscarDatos("Usuarios");
            DataTable dsTiposCultivos = pd.BuscarDatos("Cultivos");
            // cbUsuarios.Items.Clear();

            //Comento este ciclo for por que tira error fuera de rango.
/*
            for (int j = 0; j < dsTiposCultivos.Rows.Count; j++)
            {
                dataGridView1.Rows.Add(

                        dsTiposCultivos.Rows[j][0].ToString(),
                        dsTiposCultivos.Rows[j][1].ToString(),
                        dsTiposCultivos.Rows[j][2].ToString(),
                        dsTiposCultivos.Rows[j][3].ToString()



                      );
            }*/
        }
    }
}

