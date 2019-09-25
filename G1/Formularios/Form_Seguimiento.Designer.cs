namespace G1.Formularios
{
    partial class Form_Seguimiento
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
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTipoEvento = new System.Windows.Forms.ComboBox();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoCultivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(114, 23);
            this.btnNuevoEvento.TabIndex = 0;
            this.btnNuevoEvento.Text = "Nuevo evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = true;
            this.btnNuevoEvento.Click += new System.EventHandler(this.BtnNuevoEvento_Click);
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Location = new System.Drawing.Point(704, 64);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarEvento.TabIndex = 1;
            this.btnAgregarEvento.Text = "Agregar avento";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.BtnAgregarEvento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de evento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 379);
            this.dataGridView1.TabIndex = 4;
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.Enabled = false;
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.Items.AddRange(new object[] {
            "Siembra",
            "Riego",
            "Fertilización",
            "Cosecha",
            "Raleo",
            "Curación"});
            this.cbTipoEvento.Location = new System.Drawing.Point(12, 66);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(135, 21);
            this.cbTipoEvento.TabIndex = 5;
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Enabled = false;
            this.dtpFechaEvento.Location = new System.Drawing.Point(153, 67);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEvento.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha del evento";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.Enabled = false;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Items.AddRange(new object[] {
            "Siembra",
            "Riego",
            "Fertilización",
            "Cosecha",
            "Raleo",
            "Curación"});
            this.cbUsuarios.Location = new System.Drawing.Point(525, 66);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(173, 21);
            this.cbUsuarios.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Cultivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quien realizo el evento";
            // 
            // cbTipoCultivo
            // 
            this.cbTipoCultivo.Enabled = false;
            this.cbTipoCultivo.FormattingEnabled = true;
            this.cbTipoCultivo.Location = new System.Drawing.Point(358, 66);
            this.cbTipoCultivo.Name = "cbTipoCultivo";
            this.cbTipoCultivo.Size = new System.Drawing.Size(161, 21);
            this.cbTipoCultivo.TabIndex = 8;
            // 
            // Form_Seguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTipoCultivo);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.dtpFechaEvento);
            this.Controls.Add(this.cbTipoEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.btnNuevoEvento);
            this.Name = "Form_Seguimiento";
            this.Text = "Form_Seguimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTipoEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCultivo;
    }
}