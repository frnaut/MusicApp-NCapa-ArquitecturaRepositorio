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
    public class SongController : ControllerBase
    {
        private readonly SongManager songManager;

        public SongController(SongManager songManager)
        {
            this.songManager = songManager;
        }

        [HttpGet]
        public async Task<List<Song>> GetAllAsync()
        {
            return await songManager.GetAllSongAsyng();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Song>> GetAsync(int id)
        {
            var song = await songManager.GetSongAsync(id);
            if(song == null)
            {
                return NotFound();
            }
            return song;
        }

        [HttpPost]
        public async Task<Song> PostAsync(Song song)
        {
            return await songManager.PostSongAsync(song);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, Song song)
        {
            var updateSong = await songManager.GetSongAsync(id);
            if (updateSong == null)
            {
                return NotFound();
            }

            await songManager.PutSongAsync(id, song);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Song>> DeleteAsync(int id)
        {
            var song = await songManager.GetSongAsync(id);
            if (song == null)
            {
                return NotFound();
            }

            return await songManager.DeleteSongAsync(id);
        }
    }
}