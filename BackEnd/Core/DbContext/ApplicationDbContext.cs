using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        #region Dbset
        public DbSet<Artist> Artistas { get; set; }
        public DbSet<Song> Canciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
        #endregion

    }



}
