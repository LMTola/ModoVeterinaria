using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace Presentacion
{
    public partial class Frmcliente : Form
    {

        //protected string Nombre;
        //protected string Apellido;
        //protected double Telefono;
        //protected string Direccion;

        public Frmcliente()
        {
            InitializeComponent();
            PropietarioMascota cliente = new PropietarioMascota();
            Mascota mascota = new Mascota();
        }

        private void Frmcliente_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkHamsters_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMacota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombreMascota_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
