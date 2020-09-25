using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SoftwareOperaWeb.Models
{        //Integramos Entity FrameWork

    //Usamos una CLASE BASE DE ENTITY FRAMEWORK del tipo GENERICA
        //y le enviamos la tabla Context
    public class OperasInitializer:DropCreateDatabaseAlways<OperasDBContext>
    {


        protected override void Seed(OperasDBContext context)//Cuando se crea la base de datos determinamos los registros que se va a insertar
        {
            // base.Seed(context);

            //Anotaciones Declarativas
            //Creamos una lista de tipo declarativa
            var operas = new List<Opera>
           {
               new Opera{Title="Cosi Fan Tutte",Composer="Mozart",Year=1970}
           };



            //Ahora llamamos
            //context" Parametro" REPRESENTA A NUESTRO ENTITY FRAMEWORK

            //Recorremos la lista de Operas//Recorreromos todos los elementos de la coleccion

            // public DbSet<Opera> Operas { get; set; } sale de ahi OPERAS
            //LLamamos a nuestro ContextEntity+DbSet.funcion
            operas.ForEach(s => context.Operas.Add(s));
            //Operacion Lambda =
            //Nuestro ObjetoEntityFramework.NuestraLista.Add(Elementos de mi lista)
            //Esto se guarda en memoria
            context.SaveChanges();//Con esto nos conectamos a la Base de datos e INSERTANDOLO en la BD

        }
        //Enable-Migrations   
        //Add-Migration
        //Update-Database

       

    }
}