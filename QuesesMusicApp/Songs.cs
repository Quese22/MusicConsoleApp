using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuesesMusicApp
{
    public class Songs
    {
        public Songs() { }
        public string Name { get; set; }
        public double Rating { get; set; }
        public GenreType Genre { get; set; }

        public Mood Energy { get; set; }
        public Label Category { get; set; }

        public bool isSomethingToSpin
        {
            get
            {
                switch (Energy)
                {
                    case Mood.dangerous:
                    case Mood.intense:
                    case Mood.prideful:
                    case Mood.smooth:
                    case Mood.stimulating:
                        return true;

                    case Mood.inquisitive:
                    case Mood.relaxing:
                    case Mood.sad:
                    case Mood.reminicent:
                    case Mood.goofy:

                    default:
                        return false;

                }
            }
        }

        public Songs(string name, double rating, GenreType genre, Mood energy, Label category)
        {
            Name = name;
            Rating = rating;
            Genre = genre;
            Energy = energy;
            Category = category;

        }
    }
        public enum Label
        {
            Workout, Cleaning, Commute, Break_up, Everyday, Turn_up_the_Party,
            LowKey_likes, Shower_Singing, SharingList
        }
        public enum GenreType
        {
            Hip_Hop, RnB, Jazz, Blues, Rock,
            Indie, Folk, AfroBeats, Reggaeton,
            Classical, Instrumental, Classic_Rock,
            Funk,
        }
        public enum Mood
        {
            smooth, intense, relaxing, high_paced,
            sad, prideful, dangerous, stimulating,
            inquisitive, reminicent, goofy
        }
 
}
