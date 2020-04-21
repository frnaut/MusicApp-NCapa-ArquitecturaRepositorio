using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;
using Core.Respositories;

namespace MusicApp.DataAccess.Respositories
{
    public class SongRespository : Crud<Song>, ISongRespository
    {
        public SongRespository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
