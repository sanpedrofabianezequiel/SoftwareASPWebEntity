using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrosAPI.Entidades
{

    public class Autor
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
    }
}
