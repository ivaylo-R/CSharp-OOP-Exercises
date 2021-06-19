using Raiding.Common;
using Raiding.Models;
using System;

namespace Raiding.Factories
{
    public class HeroFactory
    {
        
        public BaseHero CreateHero(string name,string type)
        {
            BaseHero hero = null;
            switch (type)
            {
                case "Paladin":
                    hero = new Paladin(name);
                    break;
                case "Druid":
                    hero = new Druid(name);
                    break;
                case "Rogue":
                    hero = new Rogue(name);
                    break;
                case "Warrior":
                    hero = new Warrior(name);
                    break;
            }

            if (hero == null)
            {
                throw new ArgumentException(ExceptionMessages.INV_HERO);
            }

            return hero;
        }
    }
}
