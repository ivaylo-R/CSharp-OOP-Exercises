using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name) 
            : base(name)
        {
            this.Power = power;
        }
        public override string CastAbility()
        => $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
    }
}
