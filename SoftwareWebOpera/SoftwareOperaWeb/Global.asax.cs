using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using SoftwareOperaWeb.Models;

namespace SoftwareOperaWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Maneja eventos del tipo MVC
        protected void Application_Start()
        {


            #region Inicializacion del DataBase

            //Llamamos al using de EntityFrameWork
            //Llamamos a  la clase de EntityFramwWork DataBase
            //el parametro SetInitializer
            //necesita nuestro DbContext creado es decir : OperaDBContext => es decir nuestro ENTITYFRAMEWORK
            //En los parentesis => constructor indicamos la NUEVA CLASE INICIALIZADORA
            Database.SetInitializer<OperasDBContext>(new OperasInitializer());

            #endregion
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);





        }



    }
}
