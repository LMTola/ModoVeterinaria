
namespace Presentacion
{
    partial class FrmTurno
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
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.txtBusquedaMascota = new System.Windows.Forms.TextBox();
            this.list_Mascota = new System.Windows.Forms.ListBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraTurno = new System.Windows.Forms.Label();
            this.lblDiaTurno = new System.Windows.Forms.Label();
            this.txtDiaTurno = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarTurno.Location = new System.Drawing.Point(134, 252);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(221, 47);
            this.btnGuardarTurno.TabIndex = 34;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeleccion.Location = new System.Drawing.Point(341, 53);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(116, 13);
            this.lblSeleccion.TabIndex = 35;
            this.lblSeleccion.Text = "Seleccionone Mascota";
            this.lblSeleccion.Click += new System.EventHandler(this.lblSeleccion_Click);
            // 
            // txtBusquedaMascota
            // 
            this.txtBusquedaMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBusquedaMascota.Location = new System.Drawing.Point(329, 78);
            this.txtBusquedaMascota.Name = "txtBusquedaMascota";
            this.txtBusquedaMascota.Size = new System.Drawing.Size(152, 20);
            this.txtBusquedaMascota.TabIndex = 36;
            this.txtBusquedaMascota.TextChanged += new System.EventHandler(this.txtBusquedaMascota_TextChanged);
            // 
            // list_Mascota
            // 
            this.list_Mascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.list_Mascota.FormattingEnabled = true;
            this.list_Mascota.Location = new System.Drawing.Point(329, 112);
            this.list_Mascota.Name = "list_Mascota";
            this.list_Mascota.Size = new System.Drawing.Size(151, 134);
            this.list_Mascota.TabIndex = 37;
            this.list_Mascota.SelectedIndexChanged += new System.EventHandler(this.list_Mascota_SelectedIndexChanged);
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Items.AddRange(new object[] {
            "Consulta Medica",
            "Peluqueria"});
            this.cbTipoServicio.Location = new System.Drawing.Point(46, 78);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(208, 21);
            this.cbTipoServicio.TabIndex = 38;
            this.cbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cbTipoServicio_SelectedIndexChanged);
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoServicio.Location = new System.Drawing.Point(109, 53);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServicio.TabIndex = 39;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // txtHora
            // 
            this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHora.Location = new System.Drawing.Point(216, 139);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(38, 20);
            this.txtHora.TabIndex = 41;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraTurno
            // 
            this.lblHoraTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoraTurno.AutoSize = true;
            this.lblHoraTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraTurno.Location = new System.Drawing.Point(188, 142);
            this.lblHoraTurno.Name = "lblHoraTurno";
            this.lblHoraTurno.Size = new System.Drawing.Size(30, 13);
            this.lblHoraTurno.TabIndex = 44;
            this.lblHoraTurno.Text = "Hora";
            // 
            // lblDiaTurno
            // 
            this.lblDiaTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiaTurno.AutoSize = true;
            this.lblDiaTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDiaTurno.Location = new System.Drawing.Point(43, 142);
            this.lblDiaTurno.Name = "lblDiaTurno";
            this.lblDiaTurno.Size = new System.Drawing.Size(23, 13);
            this.lblDiaTurno.TabIndex = 43;
            this.lblDiaTurno.Text = "Dia";
            // 
            // txtDiaTurno
            // 
            this.txtDiaTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDiaTurno.Location = new System.Drawing.Point(82, 139);
            this.txtDiaTurno.Name = "txtDiaTurno";
            this.txtDiaTurno.Size = new System.Drawing.Size(100, 20);
            this.txtDiaTurno.TabIndex = 40;
            this.txtDiaTurno.ValueChanged += new System.EventHandler(this.txtDiaTurno_ValueChanged);
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(589, 311);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHoraTurno);
            this.Controls.Add(this.lblDiaTurno);
            this.Controls.Add(this.txtDiaTurno);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.list_Mascota);
            this.Controls.Add(this.txtBusquedaMascota);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnGuardarTurno);
            this.Name = "FrmTurno";
            this.Text = "FrmTurno";
            this.Load += new System.EventHandler(this.FrmTurnoMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.TextBox txtBusquedaMascota;
        private System.Windows.Forms.ListBox list_Mascota;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label lblHoraTurno;
        private System.Windows.Forms.Label lblDiaTurno;
        private System.Windows.Forms.DateTimePicker txtDiaTurno;
    }
}