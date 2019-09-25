namespace agroApp.Semillas
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSemilla = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFrutasHortalizas = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnSemilla);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 462);
            this.panel2.TabIndex = 1;
            // 
            // btnSemilla
            // 
            this.btnSemilla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSemilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemilla.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSemilla.Location = new System.Drawing.Point(52, 196);
            this.btnSemilla.Name = "btnSemilla";
            this.btnSemilla.Size = new System.Drawing.Size(108, 33);
            this.btnSemilla.TabIndex = 0;
            this.btnSemilla.Text = "Semillas";
            this.btnSemilla.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.btnRaiz);
            this.panel3.Controls.Add(this.btnHojas);
            this.panel3.Controls.Add(this.btnFrutasHortalizas);
            this.panel3.Controls.Add(this.button1);
            this.panel3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(200, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 462);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // btnFrutasHortalizas
            // 
            this.btnFrutasHortalizas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFrutasHortalizas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrutasHortalizas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnFrutasHortalizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrutasHortalizas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrutasHortalizas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFrutasHortalizas.Location = new System.Drawing.Point(245, 230);
            this.btnFrutasHortalizas.Name = "btnFrutasHortalizas";
            this.btnFrutasHortalizas.Size = new System.Drawing.Size(170, 33);
            this.btnFrutasHortalizas.TabIndex = 1;
            this.btnFrutasHortalizas.Text = "Frutas y Hortalizas";
            this.btnFrutasHortalizas.UseVisualStyleBackColor = false;
            this.btnFrutasHortalizas.Click += new System.EventHandler(this.BtnFrutasHortalizas_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHojas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHojas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnHojas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHojas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHojas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHojas.Location = new System.Drawing.Point(458, 230);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(170, 33);
            this.btnHojas.TabIndex = 2;
            this.btnHojas.Text = "Hojas";
            this.btnHojas.UseVisualStyleBackColor = false;
            this.btnHojas.Click += new System.EventHandler(this.BtnHojas_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRaiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaiz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRaiz.Location = new System.Drawing.Point(659, 230);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(170, 33);
            this.btnRaiz.TabIndex = 3;
            this.btnRaiz.Text = "Raices";
            this.btnRaiz.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(29, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Flores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::agroApp.Semillas.Properties.Resources._32325;
            this.pictureBox2.Location = new System.Drawing.Point(962, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::agroApp.Semillas.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSemilla;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button btnFrutasHortalizas;
        private System.Windows.Forms.Button button1;
    }
}

