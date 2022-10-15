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
    public partial class frmAgendamiento : Form
    {
        public frmAgendamiento()
        {
            InitializeComponent();
        }

        //Verificar que el usuario ingrese una fecha mayor a la fecha actual
       
        void ValidarFecha()
        {}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtpFecha.Value.Date <= hoy)
            {
                MessageBox.Show("Fecha inválida, no puedes seleccionar una fecha pasada", "error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ValidarFecha();
            }
            else
            {
                MessageBox.Show("Información guardada exitosamente");
                this.Hide();//Ocultar este formulario
                MenúPrincipal frm = new MenúPrincipal();// Cargar formulario 2
                frm.Show();//Mostar form2 

            }

            
            
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            MenúPrincipal frm = new MenúPrincipal();//cargar fomrumlario 2
            frm.Show(); //mostrar form2
        }

        private void txtIdentificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
