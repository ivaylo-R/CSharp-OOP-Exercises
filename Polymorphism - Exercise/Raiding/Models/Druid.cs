using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int power = 80;

        public Druid(string name)
            :base(name)
        {
            this.Power = power;
        }

        public override string CastAbility()
            => $"{this.GetType().Name} - {this.Name} healed for {this.Power}";

        
    }
}
