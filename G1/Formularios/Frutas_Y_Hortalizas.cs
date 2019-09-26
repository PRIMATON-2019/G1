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
    public partial class Frutas_Y_Hortalizas : Form
    {
        public Frutas_Y_Hortalizas()
        {
            InitializeComponent();
        }


        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Semillas formu1 = new Semillas();
            formu1.Show();
            this.Hide();

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Acelga formu5 = new Acelga();
            formu5.Show();
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Semillas sm = new Semillas();
            sm.Show();
            this.Hide();
        }
    }
}
