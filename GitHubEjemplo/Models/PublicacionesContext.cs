using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GitHubEjemplo.Models
{
    public class PublicacionesContext : DbContext
    {
        public PublicacionesContext() : base("PublicacionesConnection")
        {

        }
        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}