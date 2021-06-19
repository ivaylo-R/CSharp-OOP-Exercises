using Raiding.Factories;
using Raiding.IO.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raiding.Core
{
    public class Engine
    {
        private readonly IReadable reader;
        private readonly IWritable writer;
        private readonly HeroFactory heroFactory;
        private readonly ICollection<BaseHero> heroes;
        public Engine(IReadable reader, IWritable writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroes = new List<BaseHero>();
            this.heroFactory = new HeroFactory();
        }

        public void Run()
        {
            CreateHeroes();
            int bossHP = int.Parse(this.reader.ReadLine());
            int heroesPower = 0;
            if (this.heroes.Count != 0)
            {
                foreach (var hero in this.heroes)
                {
                    writer.WriteLine(hero.CastAbility());
                }
                heroesPower = this.heroes.Sum(h => h.Power);  
            }

            this.writer.WriteLine(heroesPower>=bossHP ? "Victory!" : "Defeat...");
        }

        

        private void CreateHeroes()
        {
            int n = int.Parse(reader.ReadLine());
            while (n > this.heroes.Count)
            {
                BaseHero hero = null;
                try
                {
                    string name = this.reader.ReadLine();
                    string type = this.reader.ReadLine();
                    hero = heroFactory.CreateHero(name, type);
                }
                catch (ArgumentException fe)
                {
                    this.writer.WriteLine(fe.Message);
                    continue;
                }

                if (hero != null)
                {
                    this.heroes.Add(hero);
                }
            }

        }
    }
}
