namespace G1
{
    partial class MenuInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.panelArriba = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMininizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnAlarmas = new System.Windows.Forms.Button();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.btnCultivos = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelArriba.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMininizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelArriba
            // 
            this.panelArriba.BackColor = System.Drawing.Color.Chocolate;
            this.panelArriba.Controls.Add(this.panel4);
            this.panelArriba.Controls.Add(this.btncerrar);
            this.panelArriba.Controls.Add(this.panel1);
            this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(1100, 47);
            this.panelArriba.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chocolate;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1100, 47);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Chocolate;
            this.panel6.Controls.Add(this.btnRestaurar);
            this.panel6.Controls.Add(this.btnMininizar);
            this.panel6.Controls.Add(this.btnMaximizar);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1100, 47);
            this.panel6.TabIndex = 1;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel6_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1026, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(28, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnMininizar
            // 
            this.btnMininizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMininizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMininizar.Image")));
            this.btnMininizar.Location = new System.Drawing.Point(992, 3);
            this.btnMininizar.Name = "btnMininizar";
            this.btnMininizar.Size = new System.Drawing.Size(28, 35);
            this.btnMininizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMininizar.TabIndex = 2;
            this.btnMininizar.TabStop = false;
            this.btnMininizar.Click += new System.EventHandler(this.BtnMininizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1026, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1060, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(203, 79);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1060, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 79);
            this.panel5.TabIndex = 0;
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1060, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(28, 35);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnCalendario
            // 
            this.btnCalendario.AutoSize = true;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendario.Location = new System.Drawing.Point(16, 269);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(160, 33);
            this.btnCalendario.TabIndex = 1;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.BtnCalendario_Click);
            // 
            // btnAlarmas
            // 
            this.btnAlarmas.FlatAppearance.BorderSize = 0;
            this.btnAlarmas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAlarmas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAlarmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlarmas.Location = new System.Drawing.Point(16, 230);
            this.btnAlarmas.Name = "btnAlarmas";
            this.btnAlarmas.Size = new System.Drawing.Size(160, 33);
            this.btnAlarmas.TabIndex = 4;
            this.btnAlarmas.Text = "Alarmas";
            this.btnAlarmas.UseVisualStyleBackColor = true;
            this.btnAlarmas.Click += new System.EventHandler(this.BtnAlarmas_Click);
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.FlatAppearance.BorderSize = 0;
            this.btnSeguimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSeguimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeguimiento.Location = new System.Drawing.Point(12, 191);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(160, 33);
            this.btnSeguimiento.TabIndex = 6;
            this.btnSeguimiento.Text = "Seguimiento";
            this.btnSeguimiento.UseVisualStyleBackColor = true;
            this.btnSeguimiento.Click += new System.EventHandler(this.BtnSeguimiento_Click);
            // 
            // btnCultivos
            // 
            this.btnCultivos.FlatAppearance.BorderSize = 0;
            this.btnCultivos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCultivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCultivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCultivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCultivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCultivos.Location = new System.Drawing.Point(12, 152);
            this.btnCultivos.Name = "btnCultivos";
            this.btnCultivos.Size = new System.Drawing.Size(160, 33);
            this.btnCultivos.TabIndex = 8;
            this.btnCultivos.Text = "Cultivos";
            this.btnCultivos.UseVisualStyleBackColor = true;
            this.btnCultivos.Click += new System.EventHandler(this.BtnCultivos_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(172, 47);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(928, 573);
            this.panelPrincipal.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Chocolate;
            this.panel8.Location = new System.Drawing.Point(0, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 425);
            this.panel8.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnCultivos);
            this.panel2.Controls.Add(this.btnSeguimiento);
            this.panel2.Controls.Add(this.btnAlarmas);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.btnCalendario);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 573);
            this.panel2.TabIndex = 1;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelArriba.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMininizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.Button btnSeguimiento;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnAlarmas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMininizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCultivos;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
    }
}

