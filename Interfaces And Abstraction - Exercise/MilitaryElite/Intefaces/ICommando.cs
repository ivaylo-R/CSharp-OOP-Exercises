using MilitaryElite.Models;
using System.Collections.Generic;

namespace MilitaryElite.Intefaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public void AddMisions(IMission mission);

        public IReadOnlyCollection<IMission> Misions { get; }
    }
}
