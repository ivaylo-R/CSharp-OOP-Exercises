using MilitaryElite.Enums;
using MilitaryElite.Intefaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary,corps)
        {
            missions = new List<IMission>();
        }


        public IReadOnlyCollection<IMission> Misions => this.missions;

        public void AddMisions(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var item in this.missions)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString().Trim();
        }
    }
}
