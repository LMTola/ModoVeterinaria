
namespace Presentacion
{
    partial class Frmcliente
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNombreMacota = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.cbMacota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(177, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(221, 47);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar:";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(19, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(76, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(18, 137);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTelefono.Location = new System.Drawing.Point(76, 134);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 20);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblNombreMacota
            // 
            this.lblNombreMacota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreMacota.AutoSize = true;
            this.lblNombreMacota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreMacota.Location = new System.Drawing.Point(306, 85);
            this.lblNombreMacota.Name = "lblNombreMacota";
            this.lblNombreMacota.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMacota.TabIndex = 27;
            this.lblNombreMacota.Text = "Nombre:";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreMascota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreMascota.Location = new System.Drawing.Point(359, 82);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(184, 20);
            this.txtNombreMascota.TabIndex = 28;
            this.txtNombreMascota.TextChanged += new System.EventHandler(this.txtNombreMascota_TextChanged);
            // 
            // lblRaza
            // 
            this.lblRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaza.AutoSize = true;
            this.lblRaza.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRaza.Location = new System.Drawing.Point(306, 111);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 29;
            this.lblRaza.Text = "Raza:";
            // 
            // txtRaza
            // 
            this.txtRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRaza.Location = new System.Drawing.Point(359, 108);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(184, 20);
            this.txtRaza.TabIndex = 30;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(19, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtApellido.Location = new System.Drawing.Point(76, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 20);
            this.txtApellido.TabIndex = 35;
            // 
            // lblcliente
            // 
            this.lblcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblcliente.AutoSize = true;
            this.lblcliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcliente.Location = new System.Drawing.Point(142, 37);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(52, 13);
            this.lblcliente.TabIndex = 36;
            this.lblcliente.Text = "CLIENTE";
            // 
            // lblMascota
            // 
            this.lblMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMascota.AutoSize = true;
            this.lblMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMascota.Location = new System.Drawing.Point(409, 37);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(59, 13);
            this.lblMascota.TabIndex = 38;
            this.lblMascota.Text = "MASCOTA";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDireccion.Location = new System.Drawing.Point(18, 163);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 39;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDireccion.Location = new System.Drawing.Point(76, 160);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 20);
            this.txtDireccion.TabIndex = 40;
            // 
            // lblEspecie
            // 
            this.lblEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEspecie.Location = new System.Drawing.Point(306, 137);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 43;
            this.lblEspecie.Text = "Especie:";
            // 
            // cbMacota
            // 
            this.cbMacota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMacota.FormattingEnabled = true;
            this.cbMacota.Items.AddRange(new object[] {
            "Gato",
            "Perro",
            "Hamster",
            "Pajaro",
            "Pez"});
            this.cbMacota.Location = new System.Drawing.Point(359, 137);
            this.cbMacota.Name = "cbMacota";
            this.cbMacota.Size = new System.Drawing.Size(184, 21);
            this.cbMacota.TabIndex = 48;
            this.cbMacota.SelectedIndexChanged += new System.EventHandler(this.cbMacota_SelectedIndexChanged);
            // 
            // Frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(589, 311);
            this.Controls.Add(this.cbMacota);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.lblNombreMacota);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Frmcliente";
            this.Text = "Frmcliente";
            this.Load += new System.EventHandler(this.Frmcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNombreMacota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.ComboBox cbMacota;
    }
}