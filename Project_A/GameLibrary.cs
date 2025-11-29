using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class GameLibrary
    {
        public string Name { get; set; }
        public List<VideoGame> Games { get; set; } // композиція
        public List<GameSession> Sessions { get; set; } // композиція

        public GameLibrary(string name)
        {
            throw new NotImplementedException();
        }

        public void AddGame(VideoGame game)
        {
            throw new NotImplementedException();
        }

        public void RemoveGame(int gameId)
        {
            throw new NotImplementedException();
        }

        public GameSession StartSession(VideoGame game)
        {
            throw new NotImplementedException();
        }

        public List<VideoGame> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}