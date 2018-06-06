using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ProyectoWeb1Ricardo.Web.Controllers
{
    public class SubirPistaController
    {

        /// <summary>
        /// Obtiene Registros de pistas
        /// </summary>
        /// <returns>Data Consultar Pistas</returns>
        
       // public DataSet getConsultarPistasController() {

         //   try {
           //     Logica.BL.clsSubirPista obclsSubirPista = new Logica.BL.clsSubirPista();
             //   return obclsSubirPista.getConsultarPistas();

            //} catch (Exception ex) { throw ex; }

            
        //}
        /// <summary>
        /// Administra posibles clientes
        /// </summary>
        /// <param name="obclsPistasModels">objeto</param>
        /// <param name="inOpcion">opcion de ejecuccion</param>
        /// <returns>mensaje de proceso</returns>
        ///public string setAdministrarPistasController(Logica.Models.clsPistas obclsPistasModels, int inOpcion)
        //{
          //  try {
            ///    Logica.BL.clsSubirPista obclsSubirPista = new Logica.BL.clsSubirPista();
              //  return obclsSubirPista.setAdministrarPistas(obclsPistasModels,inOpcion);

            //} catch (Exception ex){ throw ex; }

        //}


        public string addPistasController(Logica.Models.clsPistas  obclsPistasModel) {

            try {

                Logica.BL.clsPistas obclsPistas = new Logica.BL.clsPistas();
                return obclsPistas.addLasPistas(obclsPistasModel);



            } catch (Exception ex){ throw ex; }



        }




        public string updatePistasController(Logica.Models.clsPistas obclsPistasModel)
        {

            try
            {

                Logica.BL.clsPistas obclsPistas = new Logica.BL.clsPistas();
                return obclsPistas.updateLasPistas(obclsPistasModel);



            }
            catch (Exception ex) { throw ex; }



        }






        public string deletePistasController(Logica.Models.clsPistas obclsPistasModel)
        {

            try
            {

                Logica.BL.clsPistas obclsPistas = new Logica.BL.clsPistas();
                return obclsPistas.deleteLasPistas(obclsPistasModel);



            }
            catch (Exception ex) { throw ex; }



        }


        public List<Logica.Models.clsPistas> getPistasController(Logica.Models.clsPistas obclsPistasModel)
        {

            try
            {

                Logica.BL.clsPistas obclsPistas = new Logica.BL.clsPistas();
                return obclsPistas.getLasPistas(obclsPistasModel);



            }
            catch (Exception ex) { throw ex; }



        }



        public List<Logica.Models.clsPistas> getPistasController()
        {

            try
            {

                Logica.BL.clsPistas obclsPistas = new Logica.BL.clsPistas();
                return obclsPistas.getLasPistas();



            }
            catch (Exception ex) { throw ex; }



        }


    }
}