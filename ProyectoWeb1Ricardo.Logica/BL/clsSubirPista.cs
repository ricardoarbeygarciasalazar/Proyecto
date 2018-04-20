using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ProyectoWeb1Ricardo.Logica.BL
{
     public class clsSubirPista
    {
        SqlConnection _sqlConnection = null; //me permite establecer comunicacion con la base de datos
        SqlCommand _sqlCommand = null; //me permite ejecutar comandos sql
        SqlDataAdapter _SqlDataAdapter = null; //me permite adaptar un conjunto de datos sql
        String stConexion = string.Empty; //cadena de conexion

        SqlParameter _SqlParameter = null;


        public clsSubirPista()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// Consulta Consultar Pista
        /// </summary>
        /// <returns>Registros De todas las pistas</returns>



        public DataSet getConsultarPistas()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();


                _sqlCommand = new SqlCommand("spConsultarPistas", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                

                _sqlCommand.ExecuteNonQuery();


                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { _sqlConnection.Close(); }
        }

        /// <summary>
        /// Administrar Pistas
        /// </summary>
        /// <param name="obclsPistas">objeto</param>
        /// <param name="inOpcion">Opcion de ejecuccion</param>
        /// <returns>mensaje de operacion</returns>
        public string setAdministrarPistas(Models.clsPistas obclsPistas, int inOpcion)
        {
            try
            {
                

                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();


                _sqlCommand = new SqlCommand("spAdministrarPistas", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@nCodigo",obclsPistas.inCodigo));
                _sqlCommand.Parameters.Add(new SqlParameter("@cNombre",obclsPistas.stNombre));
                _sqlCommand.Parameters.Add(new SqlParameter("@cGenero",obclsPistas.stGenero));
                _sqlCommand.Parameters.Add(new SqlParameter("@cDemo",obclsPistas.stDemo));
                _sqlCommand.Parameters.Add(new SqlParameter("@cObservacion",obclsPistas.stObservacion));
                _sqlCommand.Parameters.Add(new SqlParameter("@nOpcion",inOpcion));


                

                _SqlParameter = new SqlParameter();
                _SqlParameter.ParameterName = "@cMensaje";
                _SqlParameter.Direction = ParameterDirection.Output;
                _SqlParameter.SqlDbType = SqlDbType.VarChar;
                _SqlParameter.Size = 50;


                _sqlCommand.Parameters.Add(_SqlParameter);
                _sqlCommand.ExecuteNonQuery();


                return _SqlParameter.Value.ToString();

            }
            catch (Exception ex) { throw ex; }
            finally { _sqlConnection.Close(); }
        }

    }
}
