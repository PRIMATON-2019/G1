using System;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Semillas : Form
    {
        public Semillas()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Flores formu2 = new Flores();
            formu2.Show();
            this.Hide();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFrutasHortalizas_Click(object sender, EventArgs e)
        {
            Frutas_Y_Hortalizas formu3 = new Frutas_Y_Hortalizas();
            formu3.Show();
            this.Hide();
        }

        private void BtnHojas_Click(object sender, EventArgs e)
        {
            Hojas formu4 = new Hojas();
            formu4.Show();
            this.Hide();
        }

        private void BtnSemilla_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MenuInicial menu = new MenuInicial();
            menu.Show();
            this.Hide();
        }
    }
}
