using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SoftwareOperaWeb.Models
{
    //Agregamos el Using de System.Data.Entity
    //Heredamos de DbContext
    
    public class OperasDBContext: DbContext
    {
        //Creaamos Colecciones que representen a nuestros MODELOS
        //Nombre en Plural

        
        public OperasDBContext() : base("KeyOperaDB")//Agregamos un constructor en el caso que utilicemos un nombre diferente en la conexion String
        {

        }

        public DbSet<Opera> Operas { get; set; }




    }
}