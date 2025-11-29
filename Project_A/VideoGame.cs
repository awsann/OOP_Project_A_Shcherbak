using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class VideoGame : IPlayable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public Platform Platform { get; set; } // агрегація
        public List<Achievement> Achievements { get; set; } // композиція

        public VideoGame(int id, string title, Genre genre, Platform platform)
        {
            throw new NotImplementedException();
        }

        public void AddAchievement(Achievement achievement)
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }

        public void PauseGame()
        {
            throw new NotImplementedException();
        }

        public int GetPlayTime()
        {
            throw new NotImplementedException();
        }
    }
}