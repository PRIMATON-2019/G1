using System;
using System.Windows.Forms;

namespace G1.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 formu2 = new Form2();
            formu2.Show();
            this.Hide();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFrutasHortalizas_Click(object sender, EventArgs e)
        {
            Form3 formu3 = new Form3();
            formu3.Show();
            this.Hide();
        }

        private void BtnHojas_Click(object sender, EventArgs e)
        {
            Form4 formu4 = new Form4();
            formu4.Show();
            this.Hide();
        }

        private void BtnSemilla_Click(object sender, EventArgs e)
        {

        }
    }
}
