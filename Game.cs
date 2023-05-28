using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Dictionary<int, FootballPlayer> Goals = new Dictionary<int, FootballPlayer>();
        public int Team1Goals = 0;
        public int Team2Goals = 0;
        public Game(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;

        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            Goals.Add(minute, player);
            if (Team1.Players.Contains(player))
                Team1Goals += 1;
            else if (Team2.Players.Contains(player))
                Team2Goals += 1;

        }
        public void GetGameREsults()

        {
            Console.WriteLine("{0} - {1}", Team1Goals, Team2Goals);
            if (Team1Goals > Team2Goals)
                Console.WriteLine("Team 1 wins!");
            else if (Team2Goals < Team1Goals)
                Console.WriteLine("Team 2 wins!");
            else
                Console.WriteLine("Draw!");
        }
    }
}
