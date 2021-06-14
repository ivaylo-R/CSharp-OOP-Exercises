using MilitaryElite.Enums;
using MilitaryElite.Intefaces;
using System;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }


        public Corps Corps { get; }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.Corps}";
        }
    }
}
