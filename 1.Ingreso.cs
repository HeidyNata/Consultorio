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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            
        }
        //var form = new.Ingreso();
        //form.Show();
          //  this.Hide();

        private void lblSONRISAPERFECTA_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtIngresoContraseña.PasswordChar == (Char)0)
                txtIngresoContraseña.PasswordChar = '*';
            else
                txtIngresoContraseña.PasswordChar = (char)0;
        }
        


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            {
                if (!ValidarDatos())
                { return; }
                this.Hide ();
                frm.ShowDialogo();

            }  

            string IUsuario;
            IUsuario = txtUsuario.Text;
            string IContraseña;
            IContraseña = txtIngresoContraseña.Text;

            if (IUsuario == "Nataly.Franco" && IContraseña == "1013658183")
            {
                MessageBox.Show("Bienvenido a Sonrisa Perfecta");
                this.Hide();
                MenúPrincipal frm = new MenúPrincipal();
                frm.Show();
                
            }
            else if (IUsuario == "Mariana.Arango" && IContraseña == "1000872977")
            {
                MessageBox.Show("Bienvenido a Sonrisa Perfecta");
                this.Hide();
                MenúPrincipal frm = new MenúPrincipal();
                frm.Show();
            }
            else if (IUsuario == "Ana.Giraldo" && IContraseña == "1035852892")
            {
                MessageBox.Show("Bienvenido a Sonrisa Perfecta");
                this.Hide();
                MenúPrincipal frm = new MenúPrincipal();
                frm.Show();
            }
            else if (IUsuario == "Yeimi.Forero" && IContraseña == "32182769")
            {
                MessageBox.Show("Bienvenido a Sonrisa Perfecta");
                this.Hide();
                MenúPrincipal frm = new MenúPrincipal();
                frm.Show();
            }
            else
            { MessageBox.Show("error"); }

        }

        private bool ValidarDatos()
        { }

    }   
}
