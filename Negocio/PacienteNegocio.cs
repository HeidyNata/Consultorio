using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PacienteNegocio
    {
        IPacienteRepositorio pacienteRepositorio;
        public PacienteNegocio(IPacienteRepositorio pacienteRepositorio)
        { this.pacienteRepositorio = pacienteRepositorio;
        }
        public void IngresarPaciente(Datos_Paciente datos_Paciente)
        {
            //Aplicar Reglas de negocio

            //guardar en el repositorio

            pacienteRepositorio.IngresarPaciente(datos_Paciente);
        }
    }
}
