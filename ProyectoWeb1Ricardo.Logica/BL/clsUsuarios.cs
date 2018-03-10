using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoWeb1Ricardo.Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _sqlConnection = null; //me permite establecer comunicacion con la base de datos
        SqlCommand _sqlCommand = null; //me permite ejecutar comandos sql
        SqlDataAdapter _SqlDataAdapter = null; //me permite adaptar un conjunto de datos sql
        String stConexion = string.Empty; //cadena de conexion

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        /// <summary>
        /// Validar Usuario
        /// </summary>
        /// <param name="obclUsuarios">Objeto usuario </param>
        /// <returns>Confirmacion</returns>

        public bool getValidarUsuario(Models.clsUsuarios obclUsuarios) {
            try
            {
                DataSet dsConsulta = new DataSet();

                _sqlConnection = new SqlConnection(stConexion);
                _sqlConnection.Open();


                _sqlCommand = new SqlCommand("spConsultarUsuario", _sqlConnection);
                _sqlCommand.CommandType = CommandType.StoredProcedure;

                _sqlCommand.Parameters.Add(new SqlParameter("@cLogin", obclUsuarios.stLogin));
                _sqlCommand.Parameters.Add(new SqlParameter("@cPassword", obclUsuarios.stPassword));


                _sqlCommand.ExecuteNonQuery();


                _SqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;

            }
            catch (Exception ex) { throw ex; }
            finally { _sqlConnection.Close(); }
        }

        }

        }
    
