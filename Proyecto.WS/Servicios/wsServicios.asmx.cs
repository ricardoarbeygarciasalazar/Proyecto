using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Services;


namespace Proyecto.WS.Servicios
{
    /// <summary>
    /// Descripción breve de wsServicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsServicios : System.Web.Services.WebService
    {

        [WebMethod]
        public string getPistasWS()
        {
            ProyectoWeb1Ricardo.Logica.BL.clsPistas obclsPistas = new ProyectoWeb1Ricardo.Logica.BL.clsPistas();
            return JsonConvert.SerializeObject(obclsPistas.getLasPistas());

        }




        [WebMethod]
        public List<ProyectoWeb1Ricardo.Logica.Models.clsPistas> getPistasWS_XML()
        {
            ProyectoWeb1Ricardo.Logica.BL.clsPistas obclsPistas = new ProyectoWeb1Ricardo.Logica.BL.clsPistas();
            return obclsPistas.getLasPistas();

        }
    }
}
