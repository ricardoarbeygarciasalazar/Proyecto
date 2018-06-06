using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWeb1Ricardo.Logica.BL
{
   public class clsPistas
    {

        public string addLasPistas(Models.clsPistas obclsLasPistas) {

            try {

                using (Entidades.DrumsyLoopsEntities obDrumsyLoopsEntities = new Entidades.DrumsyLoopsEntities()) {

                    Entidades.Pistas obPistas = new Entidades.Pistas
                    {
                        Codigo= obclsLasPistas.inCodigo,
                        Nombre= obclsLasPistas.stNombre,
                        Genero= obclsLasPistas.stGenero,
                        Demo= obclsLasPistas.stDemo,
                        Observacion= obclsLasPistas.stObservacion

                    };

                    obDrumsyLoopsEntities.Pistas.Add(obPistas);
                    obDrumsyLoopsEntities.SaveChanges();
                    return "Se realizo proceso con exito";
                }

            } catch (Exception ex)
            { throw ex; }



        }







        public string updateLasPistas(Models.clsPistas obclsLasPistas)
        {

            try
            {

                using (Entidades.DrumsyLoopsEntities obDrumsyLoopsEntities = new Entidades.DrumsyLoopsEntities())
                {

                    Entidades.Pistas obPistas = (from q in obDrumsyLoopsEntities.Pistas
                                                 where q.Codigo == obclsLasPistas.inCodigo
                                                 select q).FirstOrDefault();
                    obPistas.Nombre = obclsLasPistas.stNombre;
                    obPistas.Genero = obclsLasPistas.stGenero;
                    obPistas.Demo = obclsLasPistas.stDemo;
                    obPistas.Observacion = obclsLasPistas.stObservacion;


                    obDrumsyLoopsEntities.SaveChanges();
                    return "Se realizo proceso con exito";
                }

            }
            catch (Exception ex)
            { throw ex; }



        }








        public string deleteLasPistas(Models.clsPistas obclsLasPistas)
        {

            try
            {

                using (Entidades.DrumsyLoopsEntities obDrumsyLoopsEntities = new Entidades.DrumsyLoopsEntities())
                {

                    Entidades.Pistas obPistas = (from q in obDrumsyLoopsEntities.Pistas
                                                 where q.Codigo == obclsLasPistas.inCodigo
                                                 select q).FirstOrDefault();
                    obDrumsyLoopsEntities.Pistas.Remove(obPistas);

                    obDrumsyLoopsEntities.SaveChanges();
                    return "Se realizo proceso con exito";
                }

            }
            catch (Exception ex)
            { throw ex; }


        
        }




        public List<Models.clsPistas> getLasPistas()
        {

            try
            {

                using (Entidades.DrumsyLoopsEntities obDrumsyLoopsEntities = new Entidades.DrumsyLoopsEntities())
                {
                    return (from q in obDrumsyLoopsEntities.Pistas
                            select new Models.clsPistas {
                                inCodigo= q.Codigo,
                                stNombre=q.Nombre,
                                stGenero=q.Genero,
                                stDemo=q.Demo,
                                stObservacion=q.Observacion,

                            }).ToList();
                }

            }
            catch (Exception ex)
            { throw ex; }



        }
        public List<Models.clsPistas> getLasPistas(Models.clsPistas obclsPistas)
        {

            try
            {

                using (Entidades.DrumsyLoopsEntities obDrumsyLoopsEntities = new Entidades.DrumsyLoopsEntities())
                {
                    return (from q in obDrumsyLoopsEntities.Pistas
                            where q.Codigo== obclsPistas.inCodigo
                            select new Models.clsPistas
                            {
                                inCodigo = q.Codigo,
                                stNombre = q.Nombre,
                                stGenero = q.Genero,
                                stDemo = q.Demo,
                                stObservacion = q.Observacion,

                            }).ToList();
                }

            }
            catch (Exception ex)
            { throw ex; }



        }
    }
}
