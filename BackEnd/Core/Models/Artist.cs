using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Artist : BasicEntity
    { 
        public string Nombre { get; set; }
        public List<Song> Canciones { get; set; }
    }
}
