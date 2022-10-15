using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class PacienteRepositorioADO: IPacienteRepositorio 
    {
        public void IngresarPaciente(Datos_Paciente datos_Paciente)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConsultorioOdontologico"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var comando = new SqlCommand();
                comando.CommandText = "IngresarPaciente";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;


                comando.Parameters.Add("@Id_Paciente", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Paciente;
                comando.Parameters.Add("@Nombres_Completos", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Nombres_Completos;
                comando.Parameters.Add("@Id_Documento", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Documento;
                comando.Parameters.Add("@Numero_Identificacion", System.Data.SqlDbType.Int, 50).Value = datos_Paciente.@Numero_Identificacion;
                comando.Parameters.Add("@Id_Genero", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Genero;
                comando.Parameters.Add("@Id_Estado_Civil", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Estado_Civil;
                comando.Parameters.Add("@Fecha_Nacimiento", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Fecha_Nacimiento;
                comando.Parameters.Add("@Barrio_Residencia", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Barrio_Residencia;
                comando.Parameters.Add("@Direccion", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Direccion;
                comando.Parameters.Add("@Telefono_Contacto ", System.Data.SqlDbType.Int).Value = datos_Paciente.Telefono_Contacto;
                comando.Parameters.Add("@Ocupación", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Ocupación;
                comando.Parameters.Add("@Id_Nivel_Escolaridad", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Nivel_Escolaridad;
                comando.Parameters.Add("@E_Mail", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.E_Mail;
                comando.Parameters.Add("@Id_Eps", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Eps;
                comando.Parameters.Add("@Id_Regimen", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Regimen;
                comando.Parameters.Add("@Id_Tratamiento_Realizar", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Id_Tratamiento_Realizar;
                comando.Parameters.Add("@Antecedentes_Medicos", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Antecedentes_Medicos;
                comando.Parameters.Add("@Nombre_Contacto_Emergencia", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Nombre_Contacto_Emergencia;
                comando.Parameters.Add("@Telefono_Contacto_Emergencia", System.Data.SqlDbType.NVarChar, 50).Value = datos_Paciente.Telefono_Contacto_Emergencia;



                comando.ExecuteNonQuery();
               
            }
        
        }
    }
}
