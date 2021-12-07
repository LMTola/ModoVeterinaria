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
    public partial class FrmTurno : Form
    {
        public FrmTurno()
        {
            InitializeComponent();
        }

        private void FrmTurnoMedico_Load(object sender, EventArgs e)
        {

        }

        private void lblSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void list_Mascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list_Mascota.DataSource = listMascota;
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recibir parametro cbTipoServicio_ a pantalla btnConsultaMedica
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            //listTurno.Add(Servicio);
        }

        

        private void txtBusquedaMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaTurno_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
