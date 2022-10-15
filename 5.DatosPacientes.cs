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
    public partial class frmDatosPacientes : Form
    {
        public frmDatosPacientes()
        {
            InitializeComponent();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Contains("@" ))
            {
                
                    MessageBox.Show("Correo válido");
                    MessageBox.Show("Información guardada exitosamente");
                    this.Hide();//ocultar éste fomrmulario
                    MenúPrincipal frm = new MenúPrincipal();//cargar fomrumlario 2
                    frm.Show(); //mostrar form2
                
            }
            else
            {
                MessageBox.Show("Correo inválido");
            }
            
        }

        private void btnAtrás_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            frmDatosPaciente frm = new frmDatosPaciente();//cargar fomrumlario 2
            frm.Show(); //mostrar form2
        }


        private void mskTeléfonoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mskTélefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
