using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agendamiento_Citas
    {
        public String Id_Paciente { get; set; }
        public string Nombres_Completos { get; set; }
        public int Numero_Identificacion { get; set; }
        public int Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public String Id_Tratamiento { get; set; }
}
}
