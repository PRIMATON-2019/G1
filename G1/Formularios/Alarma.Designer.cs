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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_atras = new System.Windows.Forms.Button();
            this.ActualizaAlarma = new System.Windows.Forms.Button();
            this.comboBoxCultivo = new System.Windows.Forms.ComboBox();
            this.comboBoxAlarma = new System.Windows.Forms.ComboBox();
            this.btnAgregarAlarma = new System.Windows.Forms.Button();
            this.textBoxDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(666, 203);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(43, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(614, 160);
            this.dataGridView2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(140, 254);
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
            this.button2.Location = new System.Drawing.Point(140, 12);
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
            this.bt_atras.Click += new System.EventHandler(this.Bt_atras_Click_1);
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
            // comboBoxCultivo
            // 
            this.comboBoxCultivo.FormattingEnabled = true;
            this.comboBoxCultivo.Items.AddRange(new object[] {
            "Manzana",
            "Pera",
            "Banana"});
            this.comboBoxCultivo.Location = new System.Drawing.Point(61, 486);
            this.comboBoxCultivo.Name = "comboBoxCultivo";
            this.comboBoxCultivo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCultivo.TabIndex = 16;
            // 
            // comboBoxAlarma
            // 
            this.comboBoxAlarma.FormattingEnabled = true;
            this.comboBoxAlarma.Items.AddRange(new object[] {
            "Riego",
            "Fertilización",
            "Raleo",
            "Cocecha"});
            this.comboBoxAlarma.Location = new System.Drawing.Point(265, 486);
            this.comboBoxAlarma.Name = "comboBoxAlarma";
            this.comboBoxAlarma.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlarma.TabIndex = 17;
            // 
            // btnAgregarAlarma
            // 
            this.btnAgregarAlarma.Location = new System.Drawing.Point(679, 482);
            this.btnAgregarAlarma.Name = "btnAgregarAlarma";
            this.btnAgregarAlarma.Size = new System.Drawing.Size(109, 24);
            this.btnAgregarAlarma.TabIndex = 18;
            this.btnAgregarAlarma.Text = "Agregar alarma";
            this.btnAgregarAlarma.UseVisualStyleBackColor = true;
            this.btnAgregarAlarma.Click += new System.EventHandler(this.BtnAgregarAlarma_Click);
            // 
            // textBoxDias
            // 
            this.textBoxDias.Location = new System.Drawing.Point(466, 486);
            this.textBoxDias.Name = "textBoxDias";
            this.textBoxDias.Size = new System.Drawing.Size(125, 20);
            this.textBoxDias.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantidad de dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo alarma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo cultivo";
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
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 135;
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
            this.col_inicio.Width = 135;
            // 
            // col_fin
            // 
            this.col_fin.Frozen = true;
            this.col_fin.HeaderText = "Fin";
            this.col_fin.MinimumWidth = 6;
            this.col_fin.Name = "col_fin";
            this.col_fin.Width = 135;
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Width = 55;
            // 
            // Alarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(814, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDias);
            this.Controls.Add(this.btnAgregarAlarma);
            this.Controls.Add(this.comboBoxAlarma);
            this.Controls.Add(this.comboBoxCultivo);
            this.Controls.Add(this.ActualizaAlarma);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Alarma";
            this.Text = "Alarma";
            this.Load += new System.EventHandler(this.Alarma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Button ActualizaAlarma;
        private System.Windows.Forms.ComboBox comboBoxCultivo;
        private System.Windows.Forms.ComboBox comboBoxAlarma;
        private System.Windows.Forms.Button btnAgregarAlarma;
        private System.Windows.Forms.TextBox textBoxDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}