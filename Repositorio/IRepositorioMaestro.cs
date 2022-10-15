using Entidades;
using System.Collections.Generic;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Tipo_Documento> ObtenerTipos_Documento();
    }
}