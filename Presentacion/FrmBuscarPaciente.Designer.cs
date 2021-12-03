
namespace Presentacion
{
    partial class FrmBuscarPaciente
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
            this.lblagendapaciente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblagendapaciente
            // 
            this.lblagendapaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblagendapaciente.AutoSize = true;
            this.lblagendapaciente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblagendapaciente.Location = new System.Drawing.Point(147, 21);
            this.lblagendapaciente.Name = "lblagendapaciente";
            this.lblagendapaciente.Size = new System.Drawing.Size(67, 13);
            this.lblagendapaciente.TabIndex = 39;
            this.lblagendapaciente.Text = "PACIENTES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 253);
            this.dataGridView1.TabIndex = 38;
            // 
            // FrmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(589, 311);
            this.Controls.Add(this.lblagendapaciente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBuscarPaciente";
            this.Text = "FrmBuscarPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblagendapaciente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}