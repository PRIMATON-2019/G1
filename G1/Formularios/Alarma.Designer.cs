namespace G1.Formularios
{
    partial class Alarma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActualizaAlarma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_prod,
            this.col_tipo,
            this.col_inicio,
            this.col_fin,
            this.Check});
            this.dataGridView1.Location = new System.Drawing.Point(33, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(656, 203);
            this.dataGridView1.TabIndex = 9;
            // 
            // col_prod
            // 
            this.col_prod.Frozen = true;
            this.col_prod.HeaderText = "Productos";
            this.col_prod.MinimumWidth = 6;
            this.col_prod.Name = "col_prod";
            this.col_prod.Width = 125;
            // 
            // col_tipo
            // 
            this.col_tipo.Frozen = true;
            this.col_tipo.HeaderText = "Tipo de Alarma";
            this.col_tipo.MinimumWidth = 6;
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.Width = 125;
            // 
            // col_inicio
            // 
            this.col_inicio.Frozen = true;
            this.col_inicio.HeaderText = "Inicio";
            this.col_inicio.MinimumWidth = 6;
            this.col_inicio.Name = "col_inicio";
            this.col_inicio.Width = 125;
            // 
            // col_fin
            // 
            this.col_fin.Frozen = true;
            this.col_fin.HeaderText = "Fin";
            this.col_fin.MinimumWidth = 6;
            this.col_fin.Name = "col_fin";
            this.col_fin.Width = 125;
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(33, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(564, 160);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Productos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Alarma";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inicio";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(91, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ultimas Alarmas";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(91, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(401, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Proximas Alarmas";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(662, 12);
            this.bt_atras.Name = "bt_atras";
            this.bt_atras.Size = new System.Drawing.Size(126, 27);
            this.bt_atras.TabIndex = 13;
            this.bt_atras.Text = "Atras";
            this.bt_atras.UseCompatibleTextRendering = true;
            this.bt_atras.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AccessibleName = "label1";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(509, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ULTIMAS ALARMAS";
            // 
            // ActualizaAlarma
            // 
            this.ActualizaAlarma.Location = new System.Drawing.Point(695, 123);
            this.ActualizaAlarma.Name = "ActualizaAlarma";
            this.ActualizaAlarma.Size = new System.Drawing.Size(93, 34);
            this.ActualizaAlarma.TabIndex = 15;
            this.ActualizaAlarma.Text = "Actualizar Alarmas";
            this.ActualizaAlarma.UseVisualStyleBackColor = true;
            this.ActualizaAlarma.Click += new System.EventHandler(this.ActualizaAlarma_Click);
            // 
            // Alarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1082, 661);
            this.Controls.Add(this.ActualizaAlarma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Alarma";
            this.Text = "Alarma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Button ActualizaAlarma;
    }
}