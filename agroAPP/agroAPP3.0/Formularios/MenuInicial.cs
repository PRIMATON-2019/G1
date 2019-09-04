using agroAPP3._0.Formularios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace agroAPP3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Form_Seguimiento formSeguimiento = new Form_Seguimiento();
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
            ABM_Semillas form_semillas = new ABM_Semillas();
        }
    }
}
