using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Intefaces
{
    public interface IMission
    {
        public string CodeName { get; }
        public MissionsStates State { get; }

        void CompeteMission();
    }
}
