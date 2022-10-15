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
    public partial class frmDatosPaciente : Form
    {
        public frmDatosPaciente()
        {
            InitializeComponent();
        }
        //Verificar que el usuario ingrese una fecha mayor a la fecha actual
        void ValidaciónFecha()
        {
           
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            MenúPrincipal frm = new MenúPrincipal();//cargar fomrumlario 2
            frm.Show(); //mostrar form2

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            if (fechaActual < dtpFechaNacimiento.Value.AddYears(edad)) edad--;
            txtEdad.Text = edad.ToString();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtpFechaNacimiento.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede ser superior a la actual. Por favor vuelva a ingresar los datos", "error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ValidaciónFecha();
            }
            else
            {
                this.Hide();//ocultar éste fomrmulario
                frmDatosPacientes frm = new frmDatosPacientes();
                frm.Show(); //mostrar form2

            }
 
        }

        private void txtNúmerodeIdentificación_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { }
            public class MiNumero

        {

            int a;

            public MiNumero()

            {

                a = 1;

            }

            public MiNumero(int x)

            {

                a = x + 1;

            }

            public int Resultado()

            {

                return a;

            }

          }

       }

 }
