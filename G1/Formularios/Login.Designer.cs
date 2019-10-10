using G1.Clases;

namespace G1.Formularios
{
    public partial class Login
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
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btni18n = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblRecuperarContrasena = new System.Windows.Forms.LinkLabel();
            this.llNuevoUsuario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(12, 19);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(166, 24);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(16, 46);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(463, 29);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.Text = "admin@admin.com";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(12, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(153, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btni18n
            // 
            this.btni18n.BackColor = System.Drawing.Color.YellowGreen;
            this.btni18n.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btni18n.ForeColor = System.Drawing.Color.Black;
            this.btni18n.Location = new System.Drawing.Point(344, 194);
            this.btni18n.Name = "btni18n";
            this.btni18n.Size = new System.Drawing.Size(135, 41);
            this.btni18n.TabIndex = 4;
            this.btni18n.Text = "English";
            this.btni18n.UseVisualStyleBackColor = false;
            this.btni18n.Click += new System.EventHandler(this.BtnI8N_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(16, 115);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(463, 29);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "admin";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 88);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(106, 24);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Contraseña";
            // 
            // lblRecuperarContrasena
            // 
            this.lblRecuperarContrasena.AutoSize = true;
            this.lblRecuperarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContrasena.Location = new System.Drawing.Point(12, 147);
            this.lblRecuperarContrasena.Name = "lblRecuperarContrasena";
            this.lblRecuperarContrasena.Size = new System.Drawing.Size(197, 24);
            this.lblRecuperarContrasena.TabIndex = 5;
            this.lblRecuperarContrasena.TabStop = true;
            this.lblRecuperarContrasena.Text = "Recuperar contraseña";
            this.lblRecuperarContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRecuperarContrasena_LinkClicked);
            // 
            // llNuevoUsuario
            // 
            this.llNuevoUsuario.AutoSize = true;
            this.llNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llNuevoUsuario.Location = new System.Drawing.Point(324, 147);
            this.llNuevoUsuario.Name = "llNuevoUsuario";
            this.llNuevoUsuario.Size = new System.Drawing.Size(155, 24);
            this.llNuevoUsuario.TabIndex = 6;
            this.llNuevoUsuario.TabStop = true;
            this.llNuevoUsuario.Text = "No tengo usuario";
            this.llNuevoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(491, 247);
            this.Controls.Add(this.llNuevoUsuario);
            this.Controls.Add(this.lblRecuperarContrasena);
            this.Controls.Add(this.btni18n);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btni18n;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.LinkLabel lblRecuperarContrasena;
        private System.Windows.Forms.LinkLabel llNuevoUsuario;
    }
}