using QuesesMusicApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppRepository
{
    public class Songrepository
    {
        //Get all Songs

        private List<Songs> _songs = new List<Songs>();


        public List<Songs> GetAllSongs()
        {
             return _songs;
        }
        public Songs GetSongByName(string name)
        {
            foreach(Songs song in _songs)
            {
                if (song.Name == name)
                    return song;
            }
            Console.WriteLine("Wrong one buddy");
            return null;

        }
        public void AddSongsToList(Songs song)
        {
            _songs.Add(song);
        }

        public bool UpdateSongs(Songs updatedSongs, string name)
        {
            foreach(Songs song in _songs)
            {
                if (song.Name.ToLower() == name.ToLower())
                {
                    song.Name = updatedSongs.Name;
                    //rating genre energy category isSomethingtoSpin
                    song.Rating = updatedSongs.Rating;
                    song.Genre = updatedSongs.Genre;
                    song.Energy = updatedSongs.Energy;
                    song.Category = updatedSongs.Category;

                    int itemIndex = _songs.IndexOf(song);
                    _songs[itemIndex] = updatedSongs;
                    return true;
                }
                
            }
            return false;
        }

        public bool DeleteTheSong(Songs song)
        {
          return _songs.Remove(song);
           

        }
        public bool DeleteTheSongByName(Songs song, string name)
        {
            foreach (Songs hits in _songs)
            {
                if (song.Name == hits.Name)
                    _songs.Remove(hits);
                return true;
            }
            return false;
        }
    }
}
