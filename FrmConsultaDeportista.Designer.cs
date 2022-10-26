namespace PryArietti_Deportista_BD
{
    partial class FrmConsultaDeportista
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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dgvMostrarDeportistas = new System.Windows.Forms.DataGridView();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.lblDatosDeportista = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDeportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(52, 397);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 10;
            this.cmdVolver.Text = "Volver ";
            this.cmdVolver.UseVisualStyleBackColor = true;
            // 
            // dgvMostrarDeportistas
            // 
            this.dgvMostrarDeportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDeportistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.ColumnaNombres,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMostrarDeportistas.Location = new System.Drawing.Point(33, 40);
            this.dgvMostrarDeportistas.Name = "dgvMostrarDeportistas";
            this.dgvMostrarDeportistas.Size = new System.Drawing.Size(442, 336);
            this.dgvMostrarDeportistas.TabIndex = 9;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(400, 397);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 8;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // lblDatosDeportista
            // 
            this.lblDatosDeportista.AutoSize = true;
            this.lblDatosDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDeportista.Location = new System.Drawing.Point(17, 17);
            this.lblDatosDeportista.Name = "lblDatosDeportista";
            this.lblDatosDeportista.Size = new System.Drawing.Size(146, 20);
            this.lblDatosDeportista.TabIndex = 7;
            this.lblDatosDeportista.Text = "Datos Deportista";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo Deportista";
            this.Column6.Name = "Column6";
            // 
            // ColumnaNombres
            // 
            this.ColumnaNombres.HeaderText = "Nombres";
            this.ColumnaNombres.Name = "ColumnaNombres";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellido ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Direccion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deporte";
            this.Column5.Name = "Column5";
            // 
            // FrmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 436);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.dgvMostrarDeportistas);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.lblDatosDeportista);
            this.Name = "FrmConsultaDeportista";
            this.Text = "Consulta Deportista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDeportistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.DataGridView dgvMostrarDeportistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Label lblDatosDeportista;
    }
}