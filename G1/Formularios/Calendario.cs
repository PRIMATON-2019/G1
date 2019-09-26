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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.panel7, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel8, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel9, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel20, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel25, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel24, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel23, "plantar raices");
            this.ttmensaje.SetToolTip(this.panel10, "plantar flores");
            this.ttmensaje.SetToolTip(this.panel18, "plantar flores");
            this.ttmensaje.SetToolTip(this.panel7, "plantar flores");
            this.ttmensaje.SetToolTip(this.panel22, "plantar flores");
            this.ttmensaje.SetToolTip(this.panel29, "plantar flores");
            this.ttmensaje.SetToolTip(this.panel11, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel12, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel16, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel15, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel28, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel34, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel33, "plantar hojas");
            this.ttmensaje.SetToolTip(this.panel13, "plantar Frutas y Hortalizas");
            this.ttmensaje.SetToolTip(this.panel21, "plantar Frutas y Hortalizas");
            this.ttmensaje.SetToolTip(this.panel26, "plantar Frutas y Hortalizas");
            this.ttmensaje.SetToolTip(this.panel32, "plantar Frutas y Hortalizas");
            this.ttmensaje.SetToolTip(this.panel31, "plantar Frutas y Hortalizas");
            this.ttmensaje.SetToolTip(this.panel14, "No se recomienda sembara nada este dia");
            this.ttmensaje.SetToolTip(this.panel35, "No se recomienda sembara nada este dia");
            this.ttmensaje.SetToolTip(this.panel14, "No se recomienda sembara nada este dia");
            this.ttmensaje.SetToolTip(this.panel30, "No se recomienda sembara nada este dia");
            this.ttmensaje.SetToolTip(this.panel43, "No se recomienda sembara nada este dia");
        }

        private void Ttmensaje_Popup(object sender, PopupEventArgs e)
        {
        
    }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
