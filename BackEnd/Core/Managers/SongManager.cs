using Core.Models;
using Core.Respositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Managers
{
    public class SongManager
    {
        private readonly ISongRespository songRespository;

        public SongManager(ISongRespository songRespository)
        {
            this.songRespository = songRespository;
        }

        public async Task<List<Song>> GetAllSongAsyng()
        {
            var songs = await songRespository.GetAllAsync();
            return songs;
        }

        public async Task<Song> GetSongAsync(int id)
        {
            var song = await songRespository.GetAsync(id);
            return song;
        }

        public async Task<Song> PostSongAsync(Song song)
        {
            var newSong = await songRespository.PostAsync(song);
            return newSong;
        }
        public async Task PutSongAsync(int id, Song song)
        {
            await songRespository.UpdateAsync(id, song);
        }

        public async Task<Song> DeleteSongAsync(int id)
        {
            var song = await songRespository.DeleteAsync(id);
            return song;
        }
    }
}
