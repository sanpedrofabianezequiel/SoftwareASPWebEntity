using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SoftwareOperaWeb.Models;
using System.Diagnostics;

namespace SoftwareOperaWeb.Controllers
{

    //Creamos una clase personalizada CON FILTROS/EVENTOS
    //va por encima de la clase la anotacion de la clase FILTRO
    [MiFiltro]
    public class OperasController : Controller
    {

        //Creamos una instancia de nuestra clase ENTITY FRAMEWORK
        private OperasDBContext db = new OperasDBContext();//Gestionamos el Entity
                                                           // GET: Operas



        //Metodo que devuelve una TODAS LAS OPERAS
        //Get  /operas
        public ActionResult Index()
        {
            //Podiamos usar un solo parametro de los 8
            //Ya que indicariamos que la vista sea la del ActionREsult
            return View("Index",db.Operas.ToList()) ;
            
            //Indicamos la (vista,ToList=> adminitracia 
            //la colecion y materializaros en memria y se envian ala lista Index )
        }



        //Metodo que devuelve una sola OPERA
        //esto es: GET: Operas/Details/5
        public ActionResult Details(int id)
        {
            //Llamos a nuestro objeto DBCONTEXT=>ENTITY
            //LLamamos a nuestra coleccion dentro del mismo
            //Usamos metodos YA programados
            //Find usa las clausulas SQL y materializa los datos
            Opera opera = db.Operas.Find(id);

            if(opera!= null)
            {
                //No especificamos la vista, por ende => view(Details)
                return View(opera);
            }
            else
            {
                //Cuando no encotramos, lo re enviamos ahi
                return HttpNotFound();
            }
            
           
        }

        //GET: Operas/Create
        public ActionResult Create()
        {
            //Creamos una instancia de Opera
            Opera opera = new Opera();
            //Le enviamos el Objeto Opera a la vista CREATE

            return View("Create",opera);
        }



        //POST: Operas/Create/newOpera

        [HttpPost]
        public ActionResult Create(Opera newOpera)
        {

            //Chequiamos que la informacion todas las decoracion
            //de datanotacion y tipos de datos
            if (ModelState.IsValid)
            {
                //Usamos nuestra instancia de ENTITY para almacenarla en MEMORIA
                db.Operas.Add(newOpera);
                //Ejecutamos en la base
                db.SaveChanges();

                //Ahora que nos redirija
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", newOpera);
            }

        }


        //Filtros de accion
       
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    //base.OnActionExecuting(filterContext);
        //    Debug.Write("Se produjo el evento OnActionExecuting");

        //}
        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    //base.OnActionExecuted(filterContext);
        //    //Clase systemDiagnostis.Debug
        //    //Debug nos permite usar la consola de 
        //    //CUANDO INVOQUEMOS AL METODO ACTION DE OPERA CONTROLLER
        //    Debug.Write("Se produjo el evento OnActionExecuted");
        //}

    }
}