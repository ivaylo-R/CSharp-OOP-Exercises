using System;
using System.Collections.Generic;

namespace _05
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            Name = name;
        }


        public string Name
        {
            get => this.name;
            private set
            {
                CommonValidator.ValidateName(value);

                this.name = value;
            }
        }

        public int SkillLevel => CalculateSkillLevel();

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                CommonValidator.ValidateStatsPoints(value, nameof(this.Endurance));

                this.endurance = value;
            }


        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                CommonValidator.ValidateStatsPoints(value, nameof(this.Sprint));

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                CommonValidator.ValidateStatsPoints(value, nameof(this.Dribble));

                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                CommonValidator.ValidateStatsPoints(value, nameof(this.Passing));

                this.passing = value;
            }
        }

        internal int Shooting
        {
            get => this.shooting;
            private set
            {
                CommonValidator.ValidateStatsPoints(value, nameof(this.Shooting));

                this.shooting = value;
            }
        }



        private int CalculateSkillLevel()
        {
            return (int)Math.Round((double)(this.Endurance + this.Sprint
                + this.Dribble + this.Passing
                + this.Shooting) / 5);
        }


    }
}
