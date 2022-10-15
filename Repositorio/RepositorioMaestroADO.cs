using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List <Tipo_Documento> ObtenerTipos_Documento()
        {
            var tiposDocumento = new List<Tipo_Documento>();

            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConsultorioOdontologico"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var comando = new SqlCommand();
                comando.CommandText = "ObtenerTipos_Documento";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;



                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDocumento.Add(new Tipo_Documento());

                    }
                }
            }


            return tiposDocumento;         
        }
    }
}
