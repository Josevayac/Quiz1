using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizCurri.Models
{
    public class Lenguajes
    {
        [Key]
        public int LenguajeId { get; set; }

        [Required]
        [DisplayName("Nombre de Lenguaje")]
        public string LenguajeName { get; set; }

    }
}