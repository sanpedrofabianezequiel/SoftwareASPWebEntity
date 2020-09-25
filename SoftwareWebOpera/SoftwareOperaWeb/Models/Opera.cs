using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoftwareOperaWeb.Models
{
    public class Opera
    {

        #region Propiedades

        public int OperaId { get; set; }


        [Required]
        [StringLength(20)]
        public string Title { get; set; }

        [CheckValidYear]
        public int Year { get; set; }

        [Required]
        public string Composer { get; set; }

        //El ? PERMITE aceptar nullos
        public int? UserId { get; set; }
        #endregion


    }
}