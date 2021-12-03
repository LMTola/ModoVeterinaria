
namespace Presentacion
{
    partial class FrmPaciente
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
            this.chkPez = new System.Windows.Forms.CheckBox();
            this.chkPajaro = new System.Windows.Forms.CheckBox();
            this.chkHamsters = new System.Windows.Forms.CheckBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.chkPerro = new System.Windows.Forms.CheckBox();
            this.chkGato = new System.Windows.Forms.CheckBox();
            this.lblMascota = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblNombreMacota = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblbuscarpropietario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(184, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(243, 35);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar:";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // chkPez
            // 
            this.chkPez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPez.AutoSize = true;
            this.chkPez.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPez.Location = new System.Drawing.Point(295, 155);
            this.chkPez.Name = "chkPez";
            this.chkPez.Size = new System.Drawing.Size(44, 17);
            this.chkPez.TabIndex = 57;
            this.chkPez.Text = "Pez";
            this.chkPez.UseVisualStyleBackColor = true;
            // 
            // chkPajaro
            // 
            this.chkPajaro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPajaro.AutoSize = true;
            this.chkPajaro.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPajaro.Location = new System.Drawing.Point(233, 156);
            this.chkPajaro.Name = "chkPajaro";
            this.chkPajaro.Size = new System.Drawing.Size(56, 17);
            this.chkPajaro.TabIndex = 56;
            this.chkPajaro.Text = "Pajaro";
            this.chkPajaro.UseVisualStyleBackColor = true;
            // 
            // chkHamsters
            // 
            this.chkHamsters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHamsters.AutoSize = true;
            this.chkHamsters.ForeColor = System.Drawing.SystemColors.Control;
            this.chkHamsters.Location = new System.Drawing.Point(157, 156);
            this.chkHamsters.Name = "chkHamsters";
            this.chkHamsters.Size = new System.Drawing.Size(70, 17);
            this.chkHamsters.TabIndex = 55;
            this.chkHamsters.Text = "Hamsters";
            this.chkHamsters.UseVisualStyleBackColor = true;
            // 
            // lblEspecie
            // 
            this.lblEspecie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEspecie.Location = new System.Drawing.Point(69, 130);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 54;
            this.lblEspecie.Text = "Especie:";
            // 
            // chkPerro
            // 
            this.chkPerro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPerro.AutoSize = true;
            this.chkPerro.ForeColor = System.Drawing.SystemColors.Control;
            this.chkPerro.Location = new System.Drawing.Point(100, 156);
            this.chkPerro.Name = "chkPerro";
            this.chkPerro.Size = new System.Drawing.Size(51, 17);
            this.chkPerro.TabIndex = 53;
            this.chkPerro.Text = "Perro";
            this.chkPerro.UseVisualStyleBackColor = true;
            // 
            // chkGato
            // 
            this.chkGato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkGato.AutoSize = true;
            this.chkGato.ForeColor = System.Drawing.SystemColors.Control;
            this.chkGato.Location = new System.Drawing.Point(44, 156);
            this.chkGato.Name = "chkGato";
            this.chkGato.Size = new System.Drawing.Size(49, 17);
            this.chkGato.TabIndex = 52;
            this.chkGato.Text = "Gato";
            this.chkGato.UseVisualStyleBackColor = true;
            // 
            // lblMascota
            // 
            this.lblMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMascota.AutoSize = true;
            this.lblMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMascota.Location = new System.Drawing.Point(181, 25);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(59, 13);
            this.lblMascota.TabIndex = 51;
            this.lblMascota.Text = "MASCOTA";
            this.lblMascota.Click += new System.EventHandler(this.lblMascota_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRaza.Location = new System.Drawing.Point(122, 101);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(184, 20);
            this.txtRaza.TabIndex = 50;
            // 
            // lblRaza
            // 
            this.lblRaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaza.AutoSize = true;
            this.lblRaza.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRaza.Location = new System.Drawing.Point(69, 104);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 49;
            this.lblRaza.Text = "Raza:";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreMascota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreMascota.Location = new System.Drawing.Point(122, 75);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(184, 20);
            this.txtNombreMascota.TabIndex = 48;
            // 
            // lblNombreMacota
            // 
            this.lblNombreMacota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreMacota.AutoSize = true;
            this.lblNombreMacota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreMacota.Location = new System.Drawing.Point(69, 78);
            this.lblNombreMacota.Name = "lblNombreMacota";
            this.lblNombreMacota.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMacota.TabIndex = 47;
            this.lblNombreMacota.Text = "Nombre:";
            // 
            // lblPropietario
            // 
            this.lblPropietario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPropietario.Location = new System.Drawing.Point(435, 25);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(80, 13);
            this.lblPropietario.TabIndex = 58;
            this.lblPropietario.Text = "PROPIETARIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 133);
            this.dataGridView1.TabIndex = 59;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(394, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 61;
            // 
            // lblbuscarpropietario
            // 
            this.lblbuscarpropietario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblbuscarpropietario.AutoSize = true;
            this.lblbuscarpropietario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbuscarpropietario.Location = new System.Drawing.Point(341, 74);
            this.lblbuscarpropietario.Name = "lblbuscarpropietario";
            this.lblbuscarpropietario.Size = new System.Drawing.Size(43, 13);
            this.lblbuscarpropietario.TabIndex = 60;
            this.lblbuscarpropietario.Text = "Buscar:";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblbuscarpropietario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.chkPez);
            this.Controls.Add(this.chkPajaro);
            this.Controls.Add(this.chkHamsters);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.chkPerro);
            this.Controls.Add(this.chkGato);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.lblNombreMacota);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.Load += new System.EventHandler(this.FrmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkPez;
        private System.Windows.Forms.CheckBox chkPajaro;
        private System.Windows.Forms.CheckBox chkHamsters;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.CheckBox chkPerro;
        private System.Windows.Forms.CheckBox chkGato;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblNombreMacota;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblbuscarpropietario;
    }
}