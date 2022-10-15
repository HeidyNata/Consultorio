using System;
using Entidades;
using Repositorio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro
    {
        IRepositorioMaestro respositorioMaestro;
        public NegocioMaestro(IRepositorioMaestro respositorioMaestro)
        {
            this.respositorioMaestro = respositorioMaestro;
        }
        public List<Tipo_Documento> ObtenerTipos_Documento()
        {
            return respositorioMaestro.ObtenerTipos_Documento();
        }
    }
}
