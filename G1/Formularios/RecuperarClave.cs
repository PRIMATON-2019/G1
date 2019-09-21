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
            if (txtCorreo.Text !="" && txtApellido.Text !="" && TxtNombre.Text !="")
            {
                //Leer XML, buscar usuario y devolver clave.
                Persistencia pd = new Persistencia();
                string[] datos = new string[] { "usuario", "apellido", "nombre", "genero" };
               
                string[,] datosEncontrados = pd.BuscarDatos(datos, "usuarios");
                if (txtCorreo.Text == datosEncontrados[0,0] 
                    && txtApellido.Text == datosEncontrados[0,1] 
                    && TxtNombre.Text == datosEncontrados[0,2])
                {
                    lblClave.Text = datosEncontrados[0, 4];
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos");
            }
        }
    }
}
