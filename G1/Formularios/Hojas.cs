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
    public partial class Hojas : Form
    {
        public Hojas()
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Semillas sm = new Semillas();
            sm.Show();
            this.Hide();
        }
    }
}
