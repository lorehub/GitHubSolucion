﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubXamarin
{

    public class Publicacion
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivado { get; set; }        
    }

}
