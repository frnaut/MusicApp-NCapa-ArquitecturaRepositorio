using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;
using Core.Respositories;

namespace MusicApp.DataAccess.Respositories
{
    public class GeneroRespository : Crud<Genero>, IGeneroRespository
    {
        public GeneroRespository(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}
