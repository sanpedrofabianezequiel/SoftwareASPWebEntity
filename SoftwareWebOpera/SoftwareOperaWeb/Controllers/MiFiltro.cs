using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareOperaWeb.Controllers
{
    //Le agregamos el using Sytem.Web.Mvc
    //gregamos la herencia de actionfilteratttribute
    public class MiFiltro:ActionFilterAttribute
    {


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            Debug.Write("Se produjo el evento OnActionExecuting");

        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            //Clase systemDiagnostis.Debug
            //Debug nos permite usar la consola de 
            //CUANDO INVOQUEMOS AL METODO ACTION DE OPERA CONTROLLER
            Debug.Write("Se produjo el evento OnActionExecuted");
        }

    }
}