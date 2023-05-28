using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertsFootballModel
{
    class Team
    {
        public Coach Coach { get; set; }

        public List<FootballPlayer> Players { get; set; }
        public double AvrgAgeOfPlayers { get; set; }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
            if (players.Count >= 11 && players.Count <= 22)
            {
                Coach = coach;
                Players = players;
                int sumOfAges = 0;
                foreach (FootballPlayer player in Players)
                    sumOfAges += player.Age;
                double avrgAge = sumOfAges / Players.Count;
                AvrgAgeOfPlayers = avrgAge;
            }
            else
            {
                Console.WriteLine("A team consists of 11-22 players!");
            }
            
            
            
           
        }
    }
}
