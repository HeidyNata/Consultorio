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
    public partial class Tratamiento : Form
    {
        public Tratamiento()
        {
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Información guardada exitosamente");
            this.Hide();//ocultar éste fomrmulario
            MenúPrincipal frm = new MenúPrincipal();//cargar fomrumlario 2
            frm.Show(); //mostrar form2

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar éste fomrmulario
            MenúPrincipal frm = new MenúPrincipal();//cargar fomrumlario 2
            frm.Show(); //mostrar form2
        }

        private void cmbNombreTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index;
            index = cmbNombreTratamiento.SelectedIndex.ToString();
            switch (index)
            {
                case "0": txtDescripción.Text = ("Procesos de corrección de la posición de los dientes para mejorar la estética, la oclusión y la funcionalidad de los mismos.");
                    txtCostosAproximidos.Text = ("$250.000 - 1.500.000");
                    txtCuidadosEspeciales.Text = (" 1. No hay que comer frutos secos, chicle y dulces.\n 2.Cepillar los dientes inmediatamente después de cada comida\n3.Completar la limpieza con hilo dental");
                    pbxRelacionadas.Image = Properties.Resources.Ortodoncia1;
                    break;
                   
                case "1": txtDescripción.Text = ("Es una raíz artificial que se inserta dentro del hueso y se comporta de manera similar a la raíz natural.");
                    txtCostosAproximidos.Text = ("$3.900.000");
                    txtCuidadosEspeciales.Text = ("1.Tomar alimentos fríos, semifríos y blandos durante las primeras 24 h después de la intervención.\n  2. Evite cualquier esfuerzo físico durante las primeras 24-48h\n 3.No hacer enjuagues, ni escupir, ni cepillarse durante las primeras 24 horas. ");
                    pbxRelacionadas.Image = Properties.Resources.Implantes;
                    break;

                case "2": txtDescripción.Text = ("El objetivo es mantener la belleza natural de los dientes y conseguir una sonrisa más bonita y armónica, mediante tratamientos sencillos, indoloros y de corta duración.");
                    txtCostosAproximidos.Text = ("$1.900.000");
                    txtCuidadosEspeciales.Text = ("1.Reducir en lo posible los alimentos y bebidas que puedan provocar tinciones como el café o el té en el caso utilizar carillas de resina.\n Evitar alimentos duros o pegajosos. Tampoco es aconsejable morder objetos que puedan provocar una fractura.");
                    pbxRelacionadas.Image = Properties.Resources.Estética_Dental;
                    break;

                case "3": txtDescripción.Text = ("Tratamiento de odontología estética que tiene por objetivo eliminar las manchas dentales y hacer que la dentición adquiera una tonalidad más blanca y brillante");
                    txtCostosAproximidos.Text = ("125.000 - 400.000");
                    txtCuidadosEspeciales.Text = ("1. No hay que comer frutos secos, chicle y dulces\n 2.Cepillar los dientes inmediatamente después de cada comida\n3.Completar la limpieza con hilo dental");
                    pbxRelacionadas.Image = Properties.Resources.Limpieza;
                    break;

            }

        }

       
    }
}
