
namespace Presentacion
{
    partial class Agendacliente
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
            this.lblagendaclientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblagendaclientes
            // 
            this.lblagendaclientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblagendaclientes.AutoSize = true;
            this.lblagendaclientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblagendaclientes.Location = new System.Drawing.Point(134, 30);
            this.lblagendaclientes.Name = "lblagendaclientes";
            this.lblagendaclientes.Size = new System.Drawing.Size(59, 13);
            this.lblagendaclientes.TabIndex = 37;
            this.lblagendaclientes.Text = "CLIENTES";
            // 
            // Agendacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(589, 311);
            this.Controls.Add(this.lblagendaclientes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Agendacliente";
            this.Text = "Agendacliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblagendaclientes;
    }
}