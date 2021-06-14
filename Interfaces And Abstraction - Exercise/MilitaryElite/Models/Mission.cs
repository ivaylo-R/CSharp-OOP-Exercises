using MilitaryElite.Enums;
using MilitaryElite.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionsStates state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; private set; }

        public MissionsStates State { get; private set; }

        public void CompeteMission()
        {
            this.State = MissionsStates.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
