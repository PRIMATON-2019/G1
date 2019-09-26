using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class RecuperarClave : Form
    {
        public RecuperarClave()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" && txtApellido.Text != "" && TxtNombre.Text != "")
            {

                Persistencia pd = new Persistencia();
                DataTable ds = pd.BuscarDatos("usuarios");
                for (int j = 0; j < ds.Rows.Count; j++)
                {
                    string user = ds.Rows[j][0].ToString();
                    string apellido = ds.Rows[j][1].ToString();
                    string nombre = ds.Rows[j][2].ToString();
                    if (txtCorreo.Text.Equals(user)
                        && txtApellido.Text.Equals(apellido)
                        && TxtNombre.Text.Equals(nombre))
                    {
                        lblClave.Text = ds.Rows[j][4].ToString();
                    }
                }
            }

            else
            {
                MessageBox.Show("Debe completar los campos");
            }

        }
    }
}
