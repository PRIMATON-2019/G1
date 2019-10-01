using G1.Formularios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace G1
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.button1, "Muestra el calendario lunar con su repectiva guia para sembrar");
            this.ttmensaje.SetToolTip(this.button2, "Informacion de cada semilla recomendad para plantar ");
            this.ttmensaje.SetToolTip(this.button3, "Progama alarmas para recordar Actividades en tu Huerta ");
            this.ttmensaje.SetToolTip(this.button2, "Informacion de cada semilla recomendada para plantar ");
            this.ttmensaje.SetToolTip(this.btnSeguimiento, "Realiza seguimiento de tu Cosecha ");
            this.ttmensaje.SetToolTip(this.pictureBox2, "Cerrar");
            this.ttmensaje.SetToolTip(this.btnRestaurar, "Restaurar");
            this.ttmensaje.SetToolTip(this.btnMininizar, "Minimizar");




        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void BtnMininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void BtnSeguimiento_Click(object sender, EventArgs e)
        {
            //btnSeguimiento.Visible = true;
            Seguimiento formSeguimiento = new Seguimiento();
            formSeguimiento.ShowDialog();


        }

        private void Btnopcion1_Click(object sender, EventArgs e)
        {
            btnSeguimiento.Visible = false;
        }

        private void Btnopcion2_Click(object sender, EventArgs e)
        {
            btnSeguimiento.Visible = false;
        }

        private void Btnopcion3_Click(object sender, EventArgs e)
        {
            btnSeguimiento.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Semillas semillas = new Semillas();
            semillas.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Alarma alarma = new Alarma();
            alarma.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calendario calendario = new Calendario();
            calendario.Show();
            this.Hide();
        }

        private void UcCalendario2_Load(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            cal.Show();
        }

        private void Ttmensaje_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
