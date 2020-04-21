using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public class GeneroManager
    {
        private readonly IGeneroRespository generoRespository;

        public GeneroManager( IGeneroRespository generoRespository )
        {
            this.generoRespository = generoRespository;
        }

        public async Task<List<Genero>> GetAllGeneroAsync()
        {
            var generos = await generoRespository.GetAllAsync();
            return generos;
        }

        public async Task<Genero> GetGeneroAsync(int id)
        {
            var genero = await generoRespository.GetAsync(id);
            return genero;
        }

        public async Task<Genero> PostGeneroAsync(Genero genero)
        {
            var newgenero = await generoRespository.PostAsync(genero);
            return newgenero;
        }

        public async Task PutGeneroAsync(int id, Genero genero)
        {
            await generoRespository.UpdateAsync(id, genero);
        }

        public async Task<Genero> DeleteGeneroAsyng(int id)
        {
            var genero = await generoRespository.DeleteAsync(id);
            return genero;
        }
    }
}
