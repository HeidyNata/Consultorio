using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void AgendamientodeCitas_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            frmAgendamiento frm = new frmAgendamiento();//cargar fomrumlario 3
            frm.Show(); //mostrar form3
   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                

        private void btnBeneficiospromocionales_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            Form6 frm = new Form6();//cargar fomrumlario 6
            frm.Show(); //mostrar form6

        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            Tratamiento frm = new Tratamiento();//cargar fomrumlario 5
            frm.Show(); //mostrar form3

        }

        private void btnInformaciónbasicadeusuarios_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            frmDatosPaciente frm = new frmDatosPaciente();//cargar fomrumlario 4
            frm.Show(); //mostrar form4
        }
    }
}
