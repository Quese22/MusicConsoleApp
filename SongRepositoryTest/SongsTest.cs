using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicAppRepository;
using QuesesMusicApp;

namespace SongRepositoryTest
{
    [TestClass]
    public class SongsTest
    {
        private Songs _song = new Songs("beat",.9d, GenreType.Classical, Mood.high_paced, Label.Cleaning);

            private Songrepository _songRepo = new Songrepository();

            private List<Songs> _songList = new List<Songs>();
           
        [TestInitialize]
        public void TestData()
        {
            Songs song1 = new Songs("about that beat", 8.9d, GenreType.Hip_Hop, Mood.high_paced, Label.Workout);
            Songs song2 = new Songs("cunnnnttrrryyyy", 6.7d, GenreType.Folk, Mood.relaxing, Label.LowKey_likes);

            _songList.Add(song1);
            _songList.Add(song2);
            _songRepo.AddSongsToList(_song);



        }

        [TestMethod]
        public void GetAllSongs_ShouldReturnSongs()
        {
            _songList.Add(_song);

            List<Songs> listOf = _songRepo.GetAllSongs();

            bool betterHaveMySong = _songList.Contains(_song);

            Assert.IsTrue(betterHaveMySong);


        }
        [TestMethod]
        public void DeleteSongs_ShouldReturnListWithoutSong()
        {
            bool songRemoved = _songRepo.DeleteTheSong(_song);

            Assert.IsTrue(songRemoved);
            
        }
    }
}
