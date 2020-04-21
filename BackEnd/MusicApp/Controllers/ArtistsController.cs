using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Managers;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly ArtistManager artistManager;

        public ArtistsController( ArtistManager artistManager )
        {
            this.artistManager = artistManager;
        }

        [HttpGet]
        public async Task<List<Artist>> GetAllAsync()
        {
            return await artistManager.GetAllArtistAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtistAsync(int id)
        {
            var artista = await artistManager.GetArtistAsync(id);
            if(artista == null)
            {
                return NotFound();
            }
            return artista;
        }

        [HttpPost]
        public async Task<Artist> PostAsync(Artist artist)
        {
            return await artistManager.PostArtistAsync(artist);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, Artist artist )
        {
            var artista = await artistManager.GetArtistAsync(id);
            if (artist == null)
            {
                return NotFound();
            }
            await artistManager.PutArtistAsync(id, artist);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Artist>> DeleteAsync(int id)
        {
            var artista = await artistManager.GetArtistAsync(id);
            if(artista == null)
            {
                return NotFound();
            }
            return await artistManager.DeleteArtistAsyng(id);
        }
    }
}