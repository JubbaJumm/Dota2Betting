using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2Betting
{
    public enum Teams
    {

    }

    public enum Heroes
    {

    }

    public class Player
    {
        public string Name;
        public Teams Team;
    }

    public class MatchPlayer
    {
        public Player Player;
        public Heroes Hero;
        public int GPM;
        public int XPM;

    }
}
