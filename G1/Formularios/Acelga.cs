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
    public partial class Acelga : Form
    {
        public Acelga()
        {
            InitializeComponent();
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
         //   label1.ForeColor=
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Frutas_Y_Hortalizas fth = new Frutas_Y_Hortalizas();
            fth.Show();
            this.Hide();
        }
    }
}
