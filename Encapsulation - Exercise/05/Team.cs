using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team()
        {
            this.players = new List<Player>();

        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }


        public string Name
        {
            get => this.name;
            set
            {
                CommonValidator.ValidateName(value);

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            if (!players.Contains(player))
                players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }

            Player player = this.players.First(p => p.Name == playerName);
            players.Remove(player);
        }

        public int Rating()
        {
            if (!this.players.Any())
                return 0;

            return (int)Math.Round(this.players.Average(p => p.SkillLevel));

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating()}";
        }
    }
}
