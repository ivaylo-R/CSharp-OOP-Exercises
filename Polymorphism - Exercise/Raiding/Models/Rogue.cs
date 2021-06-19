using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int power = 80;
        public Rogue(string name)
            : base(name)
        {
            this.Power = power;
        }
        public override string CastAbility()
        => $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
    }
}
