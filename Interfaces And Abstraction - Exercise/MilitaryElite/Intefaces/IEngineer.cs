using MilitaryElite.Models;
using System.Collections.Generic;

namespace MilitaryElite.Intefaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public IReadOnlyCollection<IRepair> Repairs { get; }
        void AddRepair(IRepair repair);
        
    }
}
