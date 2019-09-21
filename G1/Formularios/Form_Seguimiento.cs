using G1.Clases;
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
            Persistencia pd = new Persistencia();
            DataSet ds = pd.BuscarDatos("usuarios");
            cbUsuarios.Items.Clear();
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                cbUsuarios.Items.Add(ds.Tables[0].Rows[j][1].ToString() + ", "+ ds.Tables[0].Rows[j][2]);

            }
        }
    }
}

