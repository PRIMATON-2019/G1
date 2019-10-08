using G1.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
        }

        private void BtnI8N_Click(object sender, EventArgs e)
        {
            if (btni18n.Text == "English")
            {
                lblCorreo.Text = "E-Mail";
                lblClave.Text = "Password";
                btni18n.Text = "Español";
                lblRecuperarContrasena.Text = "Password recovery";
                llNuevoUsuario.Text = "Sign Up";
                btnAceptar.Text = "Accept";
                btnCancelar.Text = "Cancel";
            }
            else if (btni18n.Text == "Español")
            {
                lblCorreo.Text = "Correo electrónico";
                lblClave.Text = "Clave";
                lblRecuperarContrasena.Text = "Recuperar clave";
                llNuevoUsuario.Text = "No tengo usuario";
                btnAceptar.Text = "Aceptar";
                btnCancelar.Text = "Cancelar";
                btni18n.Text = "English";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Verificar usuario ingresado.
            if (txtCorreo.Text != "" && txtClave.Text != "")
            {
                try
                {


                    Persistencia pd = new Persistencia();
                    DataTable ds = pd.BuscarDatos("usuarios");
                    for (int j = 0; j < ds.Rows.Count; j++)
                    {
                        string user = ds.Rows[j][0].ToString();
                        string pass = ds.Rows[j][4].ToString();
                        if (txtCorreo.Text.Equals(user)
                            && txtClave.Text.Equals(pass))
                        {
                            MenuInicial mi = new MenuInicial();
                            mi.Show();
                            this.Close();
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Debe generar antes un usuario.");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar campos

            txtCorreo.Text = "";
            txtClave.Text = "";
            txtCorreo.SelectAll();
        }

        private void LblRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarClave rc = new RecuperarClave();
            rc.Visible = true;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AltaUsuarios altaUsuarios = new AltaUsuarios();
            altaUsuarios.ShowDialog();
        }


    }
}
