using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelClienteSubMenu.Visible = false;
            panelPacienteSubMenu.Visible = false;
            panelTurnoSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //private void btnDashboard_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new FrmPrincipal());
        //    //..
        //    //your codes
        //    //..
        //    hideSubMenu();
        //}
        private void btnCliente_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClienteSubMenu);
        }
        #region ClienteSubMenu
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new Frmcliente());

            hideSubMenu();
        }
        private void btnAgendaCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new Agendacliente());

            hideSubMenu();
        }
        #endregion

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPacienteSubMenu);
        }


        #region PacienteSubMenu
        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPaciente());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnHistoriaclinica_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHistoriaClinica());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBuscarPaciente());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion
        private void btnTurno_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTurnoSubMenu);
        }
        #region TurnoSubMenu
        private void btnConsultaMedica_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTurno());
            //enviar parametro cbTipoServicio_ a pantalla Turno
            hideSubMenu();
        }

        private void btnPeluqueria_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTurno());

            hideSubMenu();
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            //openChildForm(new FrmPrincipal());
            if (activeForm != null) activeForm.Close();

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
