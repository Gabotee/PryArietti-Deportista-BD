namespace PryArietti_Deportista_BD
{
    partial class FrmRegistroEntrenador
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
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.mrcEntrenador = new System.Windows.Forms.GroupBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.SsRegistroEntrenador = new System.Windows.Forms.StatusStrip();
            this.mrcEntrenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(266, 274);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 11;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // mrcEntrenador
            // 
            this.mrcEntrenador.Controls.Add(this.lstDeporte);
            this.mrcEntrenador.Controls.Add(this.txtProvincia);
            this.mrcEntrenador.Controls.Add(this.txtDireccion);
            this.mrcEntrenador.Controls.Add(this.txtApellido);
            this.mrcEntrenador.Controls.Add(this.txtNombre);
            this.mrcEntrenador.Controls.Add(this.txtCodigoEntrenador);
            this.mrcEntrenador.Controls.Add(this.lblDeporte);
            this.mrcEntrenador.Controls.Add(this.lblCodigoDeportista);
            this.mrcEntrenador.Controls.Add(this.lblProvincia);
            this.mrcEntrenador.Controls.Add(this.lblNombre);
            this.mrcEntrenador.Controls.Add(this.lblApellido);
            this.mrcEntrenador.Controls.Add(this.lblDireccion);
            this.mrcEntrenador.Location = new System.Drawing.Point(12, 12);
            this.mrcEntrenador.Name = "mrcEntrenador";
            this.mrcEntrenador.Size = new System.Drawing.Size(329, 256);
            this.mrcEntrenador.TabIndex = 10;
            this.mrcEntrenador.TabStop = false;
            this.mrcEntrenador.Text = "Registro Entrenador";
            this.mrcEntrenador.Enter += new System.EventHandler(this.mrcEntrenador_Enter);
            // 
            // lstDeporte
            // 
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Location = new System.Drawing.Point(138, 158);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(121, 21);
            this.lstDeporte.TabIndex = 13;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(138, 191);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(138, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 94);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(138, 30);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(69, 20);
            this.txtCodigoEntrenador.TabIndex = 7;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(25, 157);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(45, 13);
            this.lblDeporte.TabIndex = 6;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(25, 30);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoDeportista.TabIndex = 0;
            this.lblCodigoDeportista.Text = "Codigo";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(26, 192);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 5;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(25, 92);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 123);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // SsRegistroEntrenador
            // 
            this.SsRegistroEntrenador.Location = new System.Drawing.Point(0, 315);
            this.SsRegistroEntrenador.Name = "SsRegistroEntrenador";
            this.SsRegistroEntrenador.Size = new System.Drawing.Size(366, 22);
            this.SsRegistroEntrenador.TabIndex = 12;
            this.SsRegistroEntrenador.Text = "statusStrip1";
            // 
            // FrmRegistroEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 337);
            this.Controls.Add(this.SsRegistroEntrenador);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcEntrenador);
            this.Name = "FrmRegistroEntrenador";
            this.Text = "Registro Entrenador";
            this.Load += new System.EventHandler(this.FrmRegistroEntrenador_Load);
            this.mrcEntrenador.ResumeLayout(false);
            this.mrcEntrenador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.GroupBox mrcEntrenador;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.StatusStrip SsRegistroEntrenador;
    }
}