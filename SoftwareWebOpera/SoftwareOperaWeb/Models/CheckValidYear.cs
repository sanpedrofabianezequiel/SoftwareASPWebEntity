using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareOperaWeb.Models
{
    public class CheckValidYear:ValidationAttribute //Necesitamos Heredar para poder crear nuestra PROPIA VALIDACION
    {
      

        public CheckValidYear()
        {
            ErrorMessage = "Debe ser Mayor a 1598";// Usamos la propiedad de la clase BASE
        }
        public override bool IsValid(object value)
        {

            int year = (int)value;

            if (year<1598)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}