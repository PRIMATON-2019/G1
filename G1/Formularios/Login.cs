using G1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                btnAceptar.Text = "Accept";
                btnCancelar.Text = "Cancel";
            }
            else if (btni18n.Text == "Español")
            {
                lblCorreo.Text = "Correo electrónico";
                lblClave.Text = "Clave";
                lblRecuperarContrasena.Text = "Recuperar clave";
                btnAceptar.Text = "Aceptar";
                btnCancelar.Text = "Cancelar";
                btni18n.Text = "English";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Verificar usuario ingresado.
            if (txtCorreo.Text!="" && txtClave.Text!="")
            {
                //Leer archivo de DB, buscar usuario y comprobar clave
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

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AltaUsuarios altaUsuarios = new AltaUsuarios();
            altaUsuarios.ShowDialog();
        }
    }
}
