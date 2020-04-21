using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public  class Genero : BasicEntity
    { 
        public string Nombre { get; set; }
        public List<Artist> Artistas { get; set; }
        public List<Song> Canciones { get; set; }
    }
}
