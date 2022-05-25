namespace GroupBoxNuevo
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.btnMensaje = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.txtContacto);
            this.grb1.Controls.Add(this.txtEmail);
            this.grb1.Controls.Add(this.txtNombre);
            this.grb1.Controls.Add(this.lblContacto);
            this.grb1.Controls.Add(this.lblEmail);
            this.grb1.Controls.Add(this.lblName);
            this.grb1.Location = new System.Drawing.Point(71, 52);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(373, 157);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Detalles de contacto";
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.btnSalir);
            this.grb2.Controls.Add(this.btnOK);
            this.grb2.Controls.Add(this.btnMensaje);
            this.grb2.Location = new System.Drawing.Point(71, 228);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(363, 100);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "Opciones";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(46, 102);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(67, 13);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "Contacto No";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(119, 99);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(100, 20);
            this.txtContacto.TabIndex = 5;
            // 
            // btnMensaje
            // 
            this.btnMensaje.Location = new System.Drawing.Point(39, 45);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Mensaje";
            this.btnMensaje.UseVisualStyleBackColor = true;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(144, 45);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(263, 45);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 355);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "frmGroupBox";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMensaje;
    }
}

