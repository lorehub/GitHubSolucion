using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GitHubEjemplo.Models
{
    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int      Id               { get; set; }

        [MaxLength(50)]
        [Required]
        public string   Usuario          { get; set; }

        [MaxLength(200)]
        public string   Descripcion      { get; set; }

        
        public DateTime FechaPublicacion { get; set; }

        public int      MeGusta          { get; set; }

        public int      MeDisgusta       { get; set; }

        public int      VecesCompartido  { get; set; }

        public bool     EsPrivado        { get; set; }
    }
}