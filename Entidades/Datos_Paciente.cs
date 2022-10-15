using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Datos_Paciente
    {
        public void IngresarDatosPaciente(Datos_Paciente datosPaciente)
        {
            throw new NotImplementedException();
        }
        public int Id_Paciente { get; set; }
        public string Nombres_Completos { get; set; }
        public string Id_Documento { get; set; }
        public int Numero_Identificacion { get; set; }
        public string Id_Genero { get; set; }
        public string Id_Estado_Civil { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Barrio_Residencia { get; set; }          
        public string Direccion { get; set; }
        public int Telefono_Contacto { get; set; }
        public string Ocupación { get; set; }
        public string Id_Nivel_Escolaridad { get; set; }
        public string E_Mail { get; set; }
        public string Id_Eps { get; set; }
        public string Id_Regimen { get; set; }
        public string Id_Tratamiento_Realizar { get; set; }
        public string Antecedentes_Medicos { get; set; }
        public string Nombre_Contacto_Emergencia { get; set; }
        public int Telefono_Contacto_Emergencia { get; set; }


       

    }
}
