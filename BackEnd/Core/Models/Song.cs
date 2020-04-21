using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Song : BasicEntity
    {

        public string Nombre { get; set; }
        public Artist Artista { get; set; }
        public Genero Genero { get; set; }

    }
}
