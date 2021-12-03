
namespace Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelTurnoSubMenu = new System.Windows.Forms.Panel();
            this.btnBuscarTurno = new System.Windows.Forms.Button();
            this.btnPeluqueria = new System.Windows.Forms.Button();
            this.btnConsultaMedica = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.panelPacienteSubMenu = new System.Windows.Forms.Panel();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.btnHistoriaclinica = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panelClienteSubMenu = new System.Windows.Forms.Panel();
            this.btnAgendaCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelusuario = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelTurnoSubMenu.SuspendLayout();
            this.panelPacienteSubMenu.SuspendLayout();
            this.panelClienteSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelusuario.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelTurnoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTurno);
            this.panelSideMenu.Controls.Add(this.panelPacienteSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPaciente);
            this.panelSideMenu.Controls.Add(this.panelClienteSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCliente);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 591);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTurnoSubMenu
            // 
            this.panelTurnoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelTurnoSubMenu.Controls.Add(this.btnBuscarTurno);
            this.panelTurnoSubMenu.Controls.Add(this.btnPeluqueria);
            this.panelTurnoSubMenu.Controls.Add(this.btnConsultaMedica);
            this.panelTurnoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTurnoSubMenu.Location = new System.Drawing.Point(0, 461);
            this.panelTurnoSubMenu.Name = "panelTurnoSubMenu";
            this.panelTurnoSubMenu.Size = new System.Drawing.Size(233, 130);
            this.panelTurnoSubMenu.TabIndex = 7;
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarTurno.FlatAppearance.BorderSize = 0;
            this.btnBuscarTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBuscarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBuscarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTurno.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarTurno.Location = new System.Drawing.Point(0, 80);
            this.btnBuscarTurno.Name = "btnBuscarTurno";
            this.btnBuscarTurno.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarTurno.Size = new System.Drawing.Size(233, 40);
            this.btnBuscarTurno.TabIndex = 2;
            this.btnBuscarTurno.Text = "Buscar Turno";
            this.btnBuscarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTurno.UseVisualStyleBackColor = true;
            this.btnBuscarTurno.Click += new System.EventHandler(this.btnBuscarTurno_Click);
            // 
            // btnPeluqueria
            // 
            this.btnPeluqueria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeluqueria.FlatAppearance.BorderSize = 0;
            this.btnPeluqueria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPeluqueria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnPeluqueria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeluqueria.ForeColor = System.Drawing.Color.Silver;
            this.btnPeluqueria.Location = new System.Drawing.Point(0, 40);
            this.btnPeluqueria.Name = "btnPeluqueria";
            this.btnPeluqueria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPeluqueria.Size = new System.Drawing.Size(233, 40);
            this.btnPeluqueria.TabIndex = 1;
            this.btnPeluqueria.Text = "Peluqueria";
            this.btnPeluqueria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeluqueria.UseVisualStyleBackColor = true;
            this.btnPeluqueria.Click += new System.EventHandler(this.btnPeluqueria_Click);
            // 
            // btnConsultaMedica
            // 
            this.btnConsultaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaMedica.FlatAppearance.BorderSize = 0;
            this.btnConsultaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConsultaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnConsultaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaMedica.ForeColor = System.Drawing.Color.Silver;
            this.btnConsultaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnConsultaMedica.Name = "btnConsultaMedica";
            this.btnConsultaMedica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultaMedica.Size = new System.Drawing.Size(233, 40);
            this.btnConsultaMedica.TabIndex = 0;
            this.btnConsultaMedica.Text = "Consulta Medica";
            this.btnConsultaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaMedica.UseVisualStyleBackColor = true;
            this.btnConsultaMedica.Click += new System.EventHandler(this.btnConsultaMedica_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.ForeColor = System.Drawing.Color.Silver;
            this.btnTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.Location = new System.Drawing.Point(0, 416);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTurno.Size = new System.Drawing.Size(233, 45);
            this.btnTurno.TabIndex = 6;
            this.btnTurno.Text = "  Turnos";
            this.btnTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // panelPacienteSubMenu
            // 
            this.panelPacienteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPacienteSubMenu.Controls.Add(this.btnBuscarPaciente);
            this.panelPacienteSubMenu.Controls.Add(this.btnHistoriaclinica);
            this.panelPacienteSubMenu.Controls.Add(this.btnNuevoPaciente);
            this.panelPacienteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPacienteSubMenu.Location = new System.Drawing.Point(0, 284);
            this.panelPacienteSubMenu.Name = "panelPacienteSubMenu";
            this.panelPacienteSubMenu.Size = new System.Drawing.Size(233, 132);
            this.panelPacienteSubMenu.TabIndex = 4;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btnBuscarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPaciente.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(0, 80);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarPaciente.Size = new System.Drawing.Size(233, 40);
            this.btnBuscarPaciente.TabIndex = 2;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // btnHistoriaclinica
            // 
            this.btnHistoriaclinica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoriaclinica.FlatAppearance.BorderSize = 0;
            this.btnHistoriaclinica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnHistoriaclinica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnHistoriaclinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoriaclinica.ForeColor = System.Drawing.Color.Silver;
            this.btnHistoriaclinica.Location = new System.Drawing.Point(0, 40);
            this.btnHistoriaclinica.Name = "btnHistoriaclinica";
            this.btnHistoriaclinica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHistoriaclinica.Size = new System.Drawing.Size(233, 40);
            this.btnHistoriaclinica.TabIndex = 1;
            this.btnHistoriaclinica.Text = "Historial Clinico";
            this.btnHistoriaclinica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoriaclinica.UseVisualStyleBackColor = true;
            this.btnHistoriaclinica.Click += new System.EventHandler(this.btnHistoriaclinica_Click);
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPaciente.FlatAppearance.BorderSize = 0;
            this.btnNuevoPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNuevoPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNuevoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPaciente.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevoPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoPaciente.Size = new System.Drawing.Size(233, 40);
            this.btnNuevoPaciente.TabIndex = 0;
            this.btnNuevoPaciente.Text = "Nuevo Paciente";
            this.btnNuevoPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.ForeColor = System.Drawing.Color.Silver;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 239);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPaciente.Size = new System.Drawing.Size(233, 45);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "  Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // panelClienteSubMenu
            // 
            this.panelClienteSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelClienteSubMenu.Controls.Add(this.btnAgendaCliente);
            this.panelClienteSubMenu.Controls.Add(this.btnNuevoCliente);
            this.panelClienteSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteSubMenu.Location = new System.Drawing.Point(0, 150);
            this.panelClienteSubMenu.Name = "panelClienteSubMenu";
            this.panelClienteSubMenu.Size = new System.Drawing.Size(233, 89);
            this.panelClienteSubMenu.TabIndex = 2;
            // 
            // btnAgendaCliente
            // 
            this.btnAgendaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgendaCliente.FlatAppearance.BorderSize = 0;
            this.btnAgendaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAgendaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAgendaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendaCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnAgendaCliente.Location = new System.Drawing.Point(0, 40);
            this.btnAgendaCliente.Name = "btnAgendaCliente";
            this.btnAgendaCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgendaCliente.Size = new System.Drawing.Size(233, 40);
            this.btnAgendaCliente.TabIndex = 1;
            this.btnAgendaCliente.Text = "Agenda de Clientes";
            this.btnAgendaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendaCliente.UseVisualStyleBackColor = true;
            this.btnAgendaCliente.Click += new System.EventHandler(this.btnAgendaCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNuevoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevoCliente.Size = new System.Drawing.Size(233, 40);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 102);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(233, 48);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "  Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelusuario
            // 
            this.panelusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelusuario.Controls.Add(this.Dashboard);
            this.panelusuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelusuario.Location = new System.Drawing.Point(250, 470);
            this.panelusuario.Name = "panelusuario";
            this.panelusuario.Size = new System.Drawing.Size(784, 130);
            this.panelusuario.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.Dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dashboard.AutoSize = true;
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.ForeColor = System.Drawing.Color.Silver;
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(3, 6);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(221, 45);
            this.Dashboard.TabIndex = 11;
            this.Dashboard.Text = " Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(784, 470);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.ErrorImage = null;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(65, 46);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(650, 350);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelusuario);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1050, 639);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelTurnoSubMenu.ResumeLayout(false);
            this.panelPacienteSubMenu.ResumeLayout(false);
            this.panelClienteSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelusuario.ResumeLayout(false);
            this.panelusuario.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        //private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelClienteSubMenu;
        private System.Windows.Forms.Button btnAgendaCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelTurnoSubMenu;
        private System.Windows.Forms.Button btnBuscarTurno;
        private System.Windows.Forms.Button btnPeluqueria;
        private System.Windows.Forms.Button btnConsultaMedica;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Panel panelPacienteSubMenu;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button btnHistoriaclinica;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelusuario;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Dashboard;
 
    }
}