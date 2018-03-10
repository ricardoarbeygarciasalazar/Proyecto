using System.Configuration;

namespace ProyectoWeb1Ricardo.Logica.BL
{
    public class clsConexion
    {
        public string getConexion()
        {

            /// <sumary>
            /// Obtiene conexion a Base De Datos
            /// </sumary>
            /// <returns>Cadena De Conexion</returns>

            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
