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
    public class GenerosController : ControllerBase
    {
        private readonly GeneroManager generoManager;

        public GenerosController(GeneroManager generoManager)
        {
            this.generoManager = generoManager;
        }

        [HttpGet]
        public async Task<List<Genero>> GetAllAsync()
        {
            return await generoManager.GetAllGeneroAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> GetAsync(int id)
        {
            var genero = await generoManager.GetGeneroAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return genero;
        }

        [HttpPost]
        public async Task<Genero> PostAsync(Genero genero)
        {
            return await generoManager.PostGeneroAsync(genero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, Genero genero)
        {
            var updategenero = await generoManager.GetGeneroAsync(id);
            if(updategenero == null)
            {
                return NotFound();
            }

            await generoManager.PutGeneroAsync(id, genero);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Genero>> DeleteAsync(int id)
        {
            var genero = await generoManager.GetGeneroAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return await generoManager.DeleteGeneroAsyng(id);
        }
    }
}