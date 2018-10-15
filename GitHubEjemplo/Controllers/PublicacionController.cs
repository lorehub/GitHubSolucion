using GitHubEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitHubEjemplo.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (var context = new PublicacionesContext())
            {
                return context.Publicaciones.ToList();
            }
        }

        [HttpGet]
        public Publicacion Get(int id)
        {
            using (var context = new PublicacionesContext())
            {
                return context.Publicaciones.FirstOrDefault(x => x.Id == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Post(Publicacion publicacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            using (var context = new PublicacionesContext())
            {
                context.Publicaciones.Add(publicacion);
                context.SaveChanges();
                return Ok (publicacion);
            }
        }


        [HttpPut]
        public Publicacion Put(Publicacion publicacion)
        {
            using (var context = new PublicacionesContext())
            {
                var publicacionUpd = context.Publicaciones.FirstOrDefault(x => x.Id == publicacion.Id);
                publicacionUpd.Usuario = publicacion.Usuario;
                publicacionUpd.Descripcion = publicacion.Descripcion;
                publicacionUpd.FechaPublicacion = publicacion.FechaPublicacion;
                publicacionUpd.MeGusta = publicacion.MeGusta;
                publicacionUpd.MeDisgusta = publicacion.MeDisgusta;
                publicacionUpd.VecesCompartido = publicacion.VecesCompartido;
                publicacionUpd.EsPrivado = publicacion.EsPrivado;

                context.SaveChanges();
                return publicacion;
            }
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new PublicacionesContext())
            {
                var publicacionDel = context.Publicaciones.FirstOrDefault(x => x.Id == id);
                context.Publicaciones.Remove(publicacionDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
