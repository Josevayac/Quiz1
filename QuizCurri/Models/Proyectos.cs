using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace QuizCurri.Models
{
    public class Proyectos
    {
        [Key]
        public int PrjId { get; set; }

        [Required]
        [DisplayName("Nombre del proyecto")]

        public string PrjName { get; set; }

        [Required]
        [DisplayName("Descripcion del Proyecto")]
        public string PrjDescription { get; set; }

        [DisplayName("Fecha Inicio del Proyecto")]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Fecha Finalización Proyecto")]
        public DateTime FechaFinal { get; set; }

        [DisplayName("Lugar elaboración de Proyecto")]
        public string Ubicacion { get; set; }
    }
}