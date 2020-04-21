using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;

namespace MusicApp.DataAccess.Respositories
{
    public class ArtistRespository : Crud<Artist>, IArtistRepository
    {
        public ArtistRespository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
