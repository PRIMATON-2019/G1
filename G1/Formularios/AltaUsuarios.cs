using G1.Clases;
using G1.Clases.Modelos;
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
    public partial class AltaUsuarios : Form
    {
        public int genero { get; set; }
        public AltaUsuarios()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            //Valida los campos 
            if (true)
            {
                Usuario usuario = new Usuario();
                Persona persona = new Persona();

                usuario.NombreUsuario = txtCorreo.Text;
                usuario.Clave = txtClave.Text;
                persona.Apellido = txtApellido.Text;
                persona.Nombre = TxtNombre.Text;
                if (rbFemenino.Checked)
                {
                    genero = 1;
                }
                if (rbMasculino.Checked)
                {
                    genero = 2;
                }
                if (rbNoBinario.Checked)
                {
                    genero = 3;
                }
                persona.Genero = genero;
                usuario.Persona = persona;
                string[] columnas = { "usuario", "clave", "apellido", "nombre", "genero" };

                Persistencia db = new Persistencia(5, columnas, "Usuarios");
                string[] datos = {
                    usuario.NombreUsuario,
                    usuario.Clave,
                    usuario.Persona.Apellido,
                    usuario.Persona.Nombre,
                    usuario.Persona.Genero.ToString()
                };
                db.CargaDatos(datos, 5, columnas);
             
                MessageBox.Show("El usuario fue dado de alta correctamente.");



            }
        }
    }
}
