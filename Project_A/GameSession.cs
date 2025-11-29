using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    public class GameSession
    {
        public int SessionId { get; set; }
        public VideoGame Game { get; set; } // асоціація
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }

        public GameSession(int sessionId, VideoGame game)
        {
            throw new NotImplementedException();
        }

        public void EndSession()
        {
            throw new NotImplementedException();
        }
    }
}