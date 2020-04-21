
using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public class ArtistManager
    {
        private readonly IArtistRepository artistRepository;

        public ArtistManager(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public async Task<List<Artist>> GetAllArtistAsync()
        {
            return await artistRepository.GetAllAsync();

        }

        public async Task<Artist> GetArtistAsync(int id)
        {
            var artista = await artistRepository.GetAsync(id);
            return artista;
        }

        public async Task<Artist> PostArtistAsync(Artist artist)
        {
            var artista = await artistRepository.PostAsync(artist);
            return artista;
        }
        public async Task PutArtistAsync(int id, Artist artista)
        {
            await artistRepository.UpdateAsync(id, artista);
        }

        public async Task<Artist> DeleteArtistAsyng(int id)
        {
            var artista = await artistRepository.DeleteAsync(id);
            return artista;
        }
    }
}
